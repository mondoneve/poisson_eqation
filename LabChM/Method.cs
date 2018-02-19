using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM {
  public class Method {
    double eps;
    int Nmax;
    int k;
    double[] parameters;

    public Method(double _eps, int _Nmax, int _k) {
      eps = _eps;
      Nmax = _Nmax;
      k = _k;
      parameters = new double[k];
      for(int i = 0; i < k; i++) parameters[i] = 0.0;
    }

    private Result run(Task g) {
      Result res = new Result(g);

      fillParameters(g.h, g.k, g.n, g.m);

      res.error = 1000000.0;
      while(res.nIter < Nmax && res.error > eps) {
        res.error = 0;
        double[,] nextLayer = (double[,])res.v.Clone();
        for(int j = 1; j < res.m; j++)
          for(int i = 1; i < res.n; i++) {
            double Av = (res.v[i + 1, j] - 2 * res.v[i, j] + res.v[i - 1, j]) / res.h / res.h + (res.v[i, j + 1] - 2 * res.v[i, j] + res.v[i, j - 1]) / res.k / res.k;
            nextLayer[i,j] = res.v[i, j] + tau(res.nIter) * (res.f[i, j] + Av);
            double error = Math.Abs(res.v[i, j] - nextLayer[i,j]);
            if(error > res.error) res.error = error;
          }
        res.v = (double[,])nextLayer.Clone();
        res.nIter++;
      }
      
      return res;
    }

    public Result solve(Task t) {
      Result res = run(t);

      try {
        res.values2 = t.trueSolve();
      } catch (NotImplementedException) {
        MainTask tt = new MainTask(t.a, t.b, t.c, t.d, t.m * 2, t.n * 2);
        Result res2 = run(tt);
        for(int i = 0; i <= res.n; i++)
          for(int j = 0; j <= res.m; j++)
            res.values2[i, j] = res2.v[i * 2, j * 2];
        res.nIter2 = res2.nIter;
        res.error2 = res2.error;
      }
      /*if(t.GetType() == typeof(TestTask)) { res.values2 = t.trueSolve(); return res; }

      MainTask tt = new MainTask(t.a, t.b, t.c, t.d, t.m * 2, t.n * 2);
      Result res2 = run(tt);
      for(int i = 0; i <= res.n; i++)
        for(int j = 0; j <= res.m; j++)
          res.values2[i, j] = res2.v[i * 2, j * 2];
      res.nIter2 = res2.nIter;
      res.error2 = res2.error;*/

      return res;
    }

    private double tau(int i) {
      return parameters[i % k];
    }

    private void fillParameters(double h, double k, double n, double m) {
      double minL = Math.Sin(Math.PI / 2.0 / n) * Math.Sin(Math.PI / 2.0 / n) * 4.0 / h / h + Math.Sin(Math.PI / 2.0 / m) * Math.Sin(Math.PI / 2.0 / m) * 4.0 / k / k;
      double maxL = Math.Sin(Math.PI*(n-1) / 2.0 / n) * Math.Sin(Math.PI*(n-1) / 2.0 / n) * 4.0 / h / h + Math.Sin(Math.PI *(m-1) / 2.0 / m) * Math.Sin(Math.PI * (m-1) / 2.0 / m) * 4.0 / k / k;
      for(int i = 0; i < this.k; i++) parameters[i] = 1 / (0.5 * (minL + maxL) + 0.5 * (maxL - minL) * Math.Cos(Math.PI * (1 + 2 * i) * 0.5 / this.k));
    }

  }
}
