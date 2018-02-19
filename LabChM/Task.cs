using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM
{
  abstract public class Task : Grid {

    public Task(double _a, double _b, double _c, double _d, int _m, int _n) : base(_a, _b, _c, _d, _m, _n) {
      for(int i = 0; i <= n; i++) { v[i, 0] = bottom(x[i]); v[i, m] = top(x[i]); }
      for(int i = 0; i <= m; i++) { v[0, i] = left(y[i]); v[n, i] = right(y[i]); }
      for(int i = 0; i <= n; i++) for(int j = 0; j <= m; j++) f[i, j] = func(x[i], y[j]);
    }


    abstract public double bottom(double x);

    abstract public double left(double y);

    abstract public double right(double y);

    abstract public double top(double x);

    abstract public double func(double x, double y);

    abstract public double[,] trueSolve();
  }
}
