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
    public partial class FPlaceChanger : Form
    {
        public FPlaceChanger()
        {
            InitializeComponent();
            Restore();
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void Restore()
        {
            textBox_WealthyRL.Text = Tech.LowerPlaces[0].ToString();
            textBox_PovertyRL.Text = Tech.LowerPlaces[1].ToString();
            textBox_UrbanRL.Text = Tech.LowerPlaces[2].ToString();
            textBox_RuralRL.Text = Tech.LowerPlaces[3].ToString();
            textBox_ColdRL.Text = Tech.LowerPlaces[4].ToString();
            textBox_HotRL.Text = Tech.LowerPlaces[5].ToString();
            textBox_HumidRL.Text = Tech.LowerPlaces[6].ToString();
            textBox_AridRL.Text = Tech.LowerPlaces[7].ToString();
            textBox_InfectivityL.Text = Tech.LowerPlaces[8].ToString();
            textBox_SeverityL.Text = Tech.LowerPlaces[9].ToString();
            textBox_LethalityL.Text = Tech.LowerPlaces[10].ToString();
            textBox_MutationL.Text = Tech.LowerPlaces[11].ToString();
            textBox_CureBaseL.Text = Tech.LowerPlaces[12].ToString();
            textBox_ResInefficiencyL.Text = Tech.LowerPlaces[13].ToString();

            textBox_WealthyRH.Text = Tech.HigherPlaces[0].ToString();
            textBox_PovertyRH.Text = Tech.HigherPlaces[1].ToString();
            textBox_UrbanRH.Text = Tech.HigherPlaces[2].ToString();
            textBox_RuralRH.Text = Tech.HigherPlaces[3].ToString();
            textBox_ColdRH.Text = Tech.HigherPlaces[4].ToString();
            textBox_HotRH.Text = Tech.HigherPlaces[5].ToString();
            textBox_HumidRH.Text = Tech.HigherPlaces[6].ToString();
            textBox_AridRH.Text = Tech.HigherPlaces[7].ToString();
            textBox_InfectivityH.Text = Tech.HigherPlaces[8].ToString();
            textBox_SeverityH.Text = Tech.HigherPlaces[9].ToString();
            textBox_LethalityH.Text = Tech.HigherPlaces[10].ToString();
            textBox_MutationH.Text = Tech.HigherPlaces[11].ToString();
            textBox_CureBaseH.Text = Tech.HigherPlaces[12].ToString();
            textBox_ResInefficiencyH.Text = Tech.HigherPlaces[13].ToString();
        }
        private void UpdateStatistics()
        {
            try
            {
                Tech.LowerPlaces[0] = double.Parse(textBox_WealthyRL.Text);
                Tech.LowerPlaces[1] = double.Parse(textBox_PovertyRL.Text);
                Tech.LowerPlaces[2] = double.Parse(textBox_UrbanRL.Text);
                Tech.LowerPlaces[3] = double.Parse(textBox_RuralRL.Text);
                Tech.LowerPlaces[4] = double.Parse(textBox_ColdRL.Text);
                Tech.LowerPlaces[5] = double.Parse(textBox_HotRL.Text);
                Tech.LowerPlaces[6] = double.Parse(textBox_HumidRL.Text);
                Tech.LowerPlaces[7] = double.Parse(textBox_AridRL.Text);
                Tech.LowerPlaces[8] = double.Parse(textBox_InfectivityL.Text);
                Tech.LowerPlaces[9] = double.Parse(textBox_SeverityL.Text);
                Tech.LowerPlaces[10] = double.Parse(textBox_LethalityL.Text);
                Tech.LowerPlaces[11] = double.Parse(textBox_MutationL.Text);
                Tech.LowerPlaces[12] = double.Parse(textBox_CureBaseL.Text);
                Tech.LowerPlaces[13] = double.Parse(textBox_ResInefficiencyL.Text);

                Tech.HigherPlaces[0] = double.Parse(textBox_WealthyRH.Text);
                Tech.HigherPlaces[1] = double.Parse(textBox_PovertyRH.Text);
                Tech.HigherPlaces[2] = double.Parse(textBox_UrbanRH.Text);
                Tech.HigherPlaces[3] = double.Parse(textBox_RuralRH.Text);
                Tech.HigherPlaces[4] = double.Parse(textBox_ColdRH.Text);
                Tech.HigherPlaces[5] = double.Parse(textBox_HotRH.Text);
                Tech.HigherPlaces[6] = double.Parse(textBox_HumidRH.Text);
                Tech.HigherPlaces[7] = double.Parse(textBox_AridRH.Text);
                Tech.HigherPlaces[8] = double.Parse(textBox_InfectivityH.Text);
                Tech.HigherPlaces[9] = double.Parse(textBox_SeverityH.Text);
                Tech.HigherPlaces[10] = double.Parse(textBox_LethalityH.Text);
                Tech.HigherPlaces[11] = double.Parse(textBox_MutationH.Text);
                Tech.HigherPlaces[12] = double.Parse(textBox_CureBaseH.Text);
                Tech.HigherPlaces[13] = double.Parse(textBox_ResInefficiencyH.Text);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "エラー発生！";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(msg, caption, buttons,MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void button_Store_Click(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            string caption = "消息";
            string msg = "窗体将退出。你要保存更改吗？";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(this, msg, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UpdateStatistics();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
