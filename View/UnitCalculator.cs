using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSys.View
{
    public partial class UnitCalculator : Form
    {
        public UnitCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int unit, amountperunit, result;

            unit = Convert.ToInt32(txtbxUnit.Text);
            amountperunit = Convert.ToInt32(txtbxAmountPerUnit.Text);

            result = unit * amountperunit;

            txtbxResult.Text = result.ToString();
        }
    }
}
