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
    public partial class FDegreeCalculator : Form
    {
        private static List<double> ruledPlaces = new();
        public FDegreeCalculator()
        {
            InitializeComponent();
            SetAllText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            ruledPlaces = Tech.LowerPlaces;
            UpdateAllRuledDegrees();
            double theoricalCost = GetBoundCost();
            int actualCost = FMainForm.tech.Cost;
            List<double> degrees = new List<double>();
            foreach (double rp in ruledPlaces)
            {
                double ap = rp * theoricalCost / actualCost;
                double deg = Math.Max(Math.Abs(ap - rp) / ap, Math.Abs(ap - rp) / rp);
                degrees.Add(deg);
            }
            List<string> lines = new List<string>
            {
                $"富抗的位下度：{degrees[0]:P2}",
                $"贫抗的位下度：{degrees[1]:P2}",
                $"城抗的位下度：{degrees[2]:P2}",
                $"农抗的位下度：{degrees[3]:P2}",
                $"寒抗的位下度：{degrees[4]:P2}",
                $"热抗的位下度：{degrees[5]:P2}",
                $"干抗的位下度：{degrees[6]:P2}",
                $"潮抗的位下度：{degrees[7]:P2}",
                $"传染的位下度：{degrees[8]:P2}",
                $"严重的位下度：{degrees[9]:P2}",
                $"致死的位下度：{degrees[10]:P2}",
                $"突变的位下度：{degrees[11]:P2}",
                $"需求的位下度：{degrees[12]:P2}",
                $"阻滞的位下度：{degrees[13]:P2}"
            };
            richTextBox_DegreeOutput.Clear();
            for (int i = 0; i < 14; i++)
            {
                if (degrees[i] > 0.3)
                    richTextBox_DegreeOutput.SelectionColor = Color.Red;
                else
                    richTextBox_DegreeOutput.SelectionColor = Color.Black;
                richTextBox_DegreeOutput.AppendText(lines[i] + Environment.NewLine);
            }
        }

        private void UpdateAllRuledDegrees()
        {
            try
            {
                ruledPlaces[0] = double.Parse(textBox_WealthyRL.Text);
                ruledPlaces[1] = double.Parse(textBox_PovertyRL.Text);
                ruledPlaces[5] = double.Parse(textBox_HotRL.Text);
                ruledPlaces[4] = double.Parse(textBox_ColdRL.Text);
                ruledPlaces[2] = double.Parse(textBox_UrbanRL.Text);
                ruledPlaces[3] = double.Parse(textBox_RuralRL.Text);
                ruledPlaces[6] = double.Parse(textBox_AridRL.Text);
                ruledPlaces[7] = double.Parse(textBox_HumidRL.Text);
                ruledPlaces[8] = double.Parse(textBox_InfectivityL.Text);
                ruledPlaces[9] = double.Parse(textBox_SeverityL.Text);
                ruledPlaces[10] = double.Parse(textBox_LethalityL.Text);
                ruledPlaces[12] = double.Parse(textBox_CureBaseL.Text);
                ruledPlaces[13] = double.Parse(textBox_ResInefficiencyL.Text);
                ruledPlaces[11] = double.Parse(textBox_MutationL.Text);
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
        private void SetAllText()
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
        }
        private double GetBoundCost()
        {
            double tmpCost = (FMainForm.tech.WealthyResistance / ruledPlaces[0])
                             + (FMainForm.tech.PovertyResistance / ruledPlaces[1])
                             + (FMainForm.tech.UrbanResistance / ruledPlaces[2])
                             + (FMainForm.tech.RuralResistance / ruledPlaces[3])
                             + (FMainForm.tech.ColdResistance / ruledPlaces[4])
                             + (FMainForm.tech.HotResistance / ruledPlaces[5])
                             + (FMainForm.tech.AridResistance / ruledPlaces[6])
                             + (FMainForm.tech.HumidResistance / ruledPlaces[7])
                             + (FMainForm.tech.Infectivity / ruledPlaces[8])
                             + (FMainForm.tech.Severity / ruledPlaces[9])
                             + (FMainForm.tech.Lethality / ruledPlaces[10])
                             + (FMainForm.tech.Mutation / ruledPlaces[11])
                             + (FMainForm.tech.CureBaseMultiplier / ruledPlaces[12])
                             + (FMainForm.tech.ResearchInefficiency / ruledPlaces[13]);
            return tmpCost;
        }
    }
}
