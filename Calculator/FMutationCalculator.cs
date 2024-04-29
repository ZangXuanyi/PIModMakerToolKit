using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FMutationCalculator : Form
    {
        public FMutationCalculator()
        {
            InitializeComponent();
        }

        #region Useless code
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double increment = checkBox_IsVirus.Checked ? 1.1 : 1.5;
                int M1 = (int)60;
                int M2 = (int)Math.Pow(increment, 1) * 60;
                int M3 = (int)Math.Pow(increment, 2) * 60;
                double PMPD = double.Parse(textBox_PredictedMutation.Text);
                double NCC = double.Parse(textBox_ncConstant.Text);
                int M1D = (int)(M1 / (PMPD * NCC)) + 1;
                int M2D = (int)(M2 / (PMPD * NCC)) + 1;
                int M3D = (int)(M3 / (PMPD * NCC)) + 1;
                double ita = M3D * PMPD * NCC - M3;

                List<string> output = new()
                {
                    $"一突估计在{M1D}",
                    $"二突估计在{M2D}",
                    $"三突估计在{M3D}",
                    $"三突余项估计是{ita}"
                };
                textBox_output.Text = String.Join("\n", output);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "エラー発生！";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(msg, caption, buttons, MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }
    }
}
