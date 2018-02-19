using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabChM
{
  public partial class Form1 : Form
    {

    Task myTask;
    Method myMethod;
    Result myResult;
    int n;
    int m;

    public Form1()
        {
            InitializeComponent();
        }

    private void calcButton_Click(object sender, EventArgs e) {
      tabTextCorrect();

      if(mainTRadiobutton.Checked) myTask = new MainTask(0.0, 3.0, 0.0, 1.0, Int32.Parse(grid_mTB.Text), Int32.Parse(grid_nTB.Text));
      else myTask = new TestTask(0.0, 3.0, 0.0, 1.0, Int32.Parse(grid_mTB.Text), Int32.Parse(grid_nTB.Text));

      myMethod = new Method(Double.Parse(epsTB.Text), Int32.Parse(n_iterTB.Text), Int32.Parse(n_paramTB.Text));

      myResult = myMethod.solve(myTask);

      if(myResult.m < 100) m = myResult.m; else m = 100; if(myResult.n < 100) n = myResult.n; else n = 100;

      printTable();
    }

    private void mainTRadiobutton_CheckedChanged(object sender, EventArgs e) {
    }

    private void tabTextCorrect() {
      if(mainTRadiobutton.Checked) uTabPage.Text = "ТОЧНЕЕ";
      else uTabPage.Text = "ТОЧНО";
    }

    private void printTable() {
      double maxDiff = 0.0;
      double x = 0.0;
      double y = 0.0;
      vDGV.Visible = true;
      uDGV.Visible = true;
      dDGV.Visible = true;

      vDGV.ColumnCount = n + 2;
      uDGV.ColumnCount = n + 2;
      dDGV.ColumnCount = n + 2;

      vDGV.RowCount = m + 2;
      uDGV.RowCount = m + 2;
      dDGV.RowCount = m + 2;

      vDGV[0, 0].Value = "Y/X";
      uDGV[0, 0].Value = "Y/X";
      dDGV[0, 0].Value = "Y/X";
      vDGV.Columns[0].Name = "i";
      vDGV.Rows[0].HeaderCell.Value = "j";
      uDGV.Columns[0].Name = "i";
      uDGV.Rows[0].HeaderCell.Value = "j";
      dDGV.Columns[0].Name = "i";
      dDGV.Rows[0].HeaderCell.Value = "j";

      for(int j = m; j >= 0; j--) {
        vDGV[0, j + 1].Value = Convert.ToString(myResult.y[m - j]);
        vDGV.Rows[j + 1].HeaderCell.Value = (m - j).ToString();
        uDGV[0, j + 1].Value = Convert.ToString(myResult.y[m - j]);
        uDGV.Rows[j + 1].HeaderCell.Value = (m - j).ToString();
        dDGV[0, j + 1].Value = Convert.ToString(myResult.y[m - j]);
        dDGV.Rows[j + 1].HeaderCell.Value = (m - j).ToString();

        for(int i = 0; i <= n; i++) {
          vDGV.Columns[i + 1].Name = Convert.ToString(i);
          vDGV[i + 1, 0].Value = Convert.ToString(myResult.x[i]);
          uDGV.Columns[i + 1].Name = Convert.ToString(i);
          uDGV[i + 1, 0].Value = Convert.ToString(myResult.x[i]);
          dDGV.Columns[i + 1].Name = Convert.ToString(i);
          dDGV[i + 1, 0].Value = Convert.ToString(myResult.x[i]);

          vDGV[i + 1, j + 1].Value = myResult.v[i, m - j].ToString("0.###");
          uDGV[i + 1, j + 1].Value = myResult.values2[i, m - j].ToString("0.###");
          double diff = Math.Abs(myResult.v[i, m - j] - myResult.values2[i, m - j]);
          dDGV[i + 1, j + 1].Value = diff.ToString("0.000e+00");
          if (diff > maxDiff) { maxDiff = diff; x = myResult.x[i]; y = myResult.y[m - j]; }
        }
      }
      iterDefaultLabel.Text = myResult.nIter.ToString();
      precDefaultLabel.Text = myResult.error.ToString("0.000e+00");
      if(mainTRadiobutton.Checked) {
        iterDoubleLabel.Text = myResult.nIter2.ToString();
        precDoubleLabel.Text = myResult.error2.ToString("0.000e+00");
      } else {
        iterDoubleLabel.Text = "Н/Д";
        precDoubleLabel.Text = "Н/Д";
      }
      maxDiffLabel.Text = maxDiff.ToString("0.000e+00");
      pointMaxDiffLabel.Text = "( " + x.ToString() + " ; " + y.ToString() + " )";


    }

  }
}
