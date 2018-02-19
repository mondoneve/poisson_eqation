using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM {
  public class TestTask : Task {
    public TestTask(double _a, double _b, double _c, double _d, int _m, int _n) : base(_a, _b, _c, _d, _m, _n) {
    }


    public override double bottom(double x) {
      return uTest(x, c);
    }

    public override double left(double y) {
      return uTest(a, y);
    }

    public override double right(double y) {
      return uTest(b, y);
    }

    public override double top(double x) {
      return uTest(x, d);
    }

    public override double func(double x, double y) {
      return - (4 * x * (2 * x * (Math.Pow(Math.Cos(x * y * y) * y, 2) - Math.Pow(Math.Sin(x * y * y) * y, 2)) + Math.Sin(x * y * y) * Math.Cos(x * y * y)) + 2 * Math.Pow(y, 4) * (Math.Pow(Math.Cos(x * y * y), 2) - Math.Pow(Math.Sin(x * y * y), 2)));
    }

    public override double[,] trueSolve() {
      double[,] result = new double[n + 1, m + 1];
      for(int i = 0; i <= n; i++) for(int j = 0; j <= m; j++)
          result[i, j] = uTest(x[i],y[j]);
      return result;
    }

    private double uTest(double x, double y) { return Math.Pow(Math.Sin(x * y * y), 2);  }

  }
}
