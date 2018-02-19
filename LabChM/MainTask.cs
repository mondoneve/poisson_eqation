using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabChM {
  public class MainTask : Task {
    public MainTask(double _a, double _b, double _c, double _d, int _m, int _n) : base(_a, _b, _c, _d, _m, _n) {
    }


    public override double bottom(double x) {
      return Math.Cosh(x * x - 3 * x) - 1;
    }
            
    public override double left(double y) {
      return Math.Sin(Math.PI * y) * Math.Sin(Math.PI * y);
    }
            
    public override double right(double y) {
      return 0.0;
    }
            
    public override double top(double x) {
      return 0.0;
    }

    public override double func(double x, double y) {
      return Math.Cosh(x - y);
    }

    public override double[,] trueSolve() {
      throw new NotImplementedException();
    }

  }
}
