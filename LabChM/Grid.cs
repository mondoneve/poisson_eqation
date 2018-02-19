using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM {
  abstract public class Grid {
    public double[,] v;
    public double[] x, y;
    public double[,] f;
    public double a, b, c, d;
    public int m, n;
    public double h, k;

    public Grid(double _a, double _b, double _c, double _d, int _m, int _n) {
      a = _a; b = _b; c = _c; d = _d; m = _m; n = _n;
      h = (b - a) / n; k = (d - c) / m;

      x = new double[n+1]; y = new double[m+1]; v = new double[n+1, m+1]; f = new double[n + 1, m + 1];

      for(int i = 0; i <= n; i++)
        for(int j = 0; j <= m; j++) {
          v[i, j] = 0.0;
          f[i, j] = 0.0;
          x[i] = i * h;
          y[j] = j * k;
        }

    }
  }
}
