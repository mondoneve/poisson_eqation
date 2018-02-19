using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM {
  public class Result : Grid {
    public double error;
    public int nIter;

    public double[,] values2;
    public double error2;
    public int nIter2;

    public Result(double a, double b, double c, double d, int m, int n) : base(a, b, c, d, m, n) { error = 0.0; nIter = 0; values2 = new double[n + 1, m + 1]; }
    public Result(Grid g) : base(g.a, g.b, g.c, g.d, g.m, g.n) {
      v = (double[,])g.v.Clone();
      x = (double[])g.x.Clone();
      y = (double[])g.y.Clone();
      f = (double[,])g.f.Clone();
      error = 0.0; nIter = 0;
      values2 = new double[n + 1, m + 1];
    }
  }
}
