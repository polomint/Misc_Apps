using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3xPlus1
{
    public partial class FrmMain : Form
    {
        enum CalculationType
        {
            SINGLE,
            RANGE
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculationType cT = CalculationType.SINGLE;
            if (rbSingle.Checked)
            {
                cT = CalculationType.SINGLE;
            }
            if (rbRange.Checked)
            {
                cT = CalculationType.RANGE;
            }
            int limit = Convert.ToInt32(nudLimit.Value);
            (bool success, List<decimal> data) = DoTheCalculation(nudStart.Value, nudEnd.Value, cT, limit);
            if (success)
            {
                lbData.Items.Clear();
                foreach (decimal d in data)
                {
                    lbData.Items.Add(d.ToString());
                }
            }
            else
            {
                lbData.Items.Clear();
                lbData.Items.Add("ERROR!");
            }
        }

        private (bool success, List<decimal> data) DoTheCalculation(decimal start, decimal end, CalculationType cT, decimal limit)
        {
            CalculationClass calcClass = new CalculationClass();
            switch (cT)
            {
                case CalculationType.SINGLE:
                    calcClass.SetSingle(start, limit);
                    return calcClass.Calculate();
                    // break;

                case CalculationType.RANGE:
                    calcClass.SetRange(start, end, limit);
                    return calcClass.Calculate();
                    // break;
            }
            return (false, null);
        }
    }
}
