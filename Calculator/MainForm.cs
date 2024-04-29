namespace Calculator
{
    public partial class MainForm : Form
    {
        internal static Tech tech = new();
        public MainForm()
        {
            InitializeComponent();
        }

        #region Legacy code. Don't delete.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click_CalculateCost(object sender, EventArgs e)
        {
            int lowerCost = tech.GetLowerCost();
            int higherCost = tech.GetHigherCost();
            textBox_Cost.Text = $"{lowerCost}~{higherCost}";
        }
        private void Button_SaveTech_Click(object sender, EventArgs e)
        {
            try { tech.WealthyResistance = double.Parse(textBox_WealthyR.Text); }
            catch { tech.WealthyResistance = 0; }
            finally { textBox_WealthyR.Text = tech.WealthyResistance.ToString(); }

            try { tech.PovertyResistance = double.Parse(textBox_PovertyR.Text); }
            catch { tech.PovertyResistance = 0; }
            finally { textBox_PovertyR.Text = tech.PovertyResistance.ToString(); }

            try { tech.HotResistance = double.Parse(textBox_HotR.Text); }
            catch { tech.HotResistance = 0; }
            finally { textBox_HotR.Text = tech.HotResistance.ToString(); }

            try { tech.ColdResistance = double.Parse(textBox_ColdR.Text); }
            catch { tech.ColdResistance = 0; }
            finally { textBox_ColdR.Text = tech.ColdResistance.ToString(); }

            try { tech.UrbanResistance = double.Parse(textBox_UrbanR.Text); }
            catch { tech.UrbanResistance = 0; }
            finally { textBox_UrbanR.Text = tech.UrbanResistance.ToString(); }

            try { tech.RuralResistance = double.Parse(textBox_RuralR.Text); }
            catch { tech.RuralResistance = 0; }
            finally { textBox_RuralR.Text = tech.RuralResistance.ToString(); }

            try { tech.AridResistance = double.Parse(textBox_AridR.Text); }
            catch { tech.AridResistance = 0; }
            finally { textBox_AridR.Text = tech.AridResistance.ToString(); }

            try { tech.HumidResistance = double.Parse(textBox_HumidR.Text); }
            catch { tech.HumidResistance = 0; }
            finally { textBox_HumidR.Text = tech.HumidResistance.ToString(); }

            try { tech.Infectivity = double.Parse(textBox_Infectivity.Text); }
            catch { tech.Infectivity = 0; }
            finally { textBox_Infectivity.Text = tech.Infectivity.ToString(); }

            try { tech.Severity = double.Parse(textBox_Severity.Text); }
            catch { tech.Severity = 0; }
            finally { textBox_Severity.Text = tech.Severity.ToString(); }

            try { tech.Lethality = double.Parse(textBox_Lethality.Text); }
            catch { tech.Lethality = 0; }
            finally { textBox_Lethality.Text = tech.Lethality.ToString(); }

            try { tech.CureBaseMultiplier = double.Parse(textBox_CureBase.Text); }
            catch { tech.CureBaseMultiplier = 0; }
            finally { textBox_CureBase.Text = tech.CureBaseMultiplier.ToString(); }

            try { tech.ResearchInefficiency = double.Parse(textBox_ResInefficiency.Text); }
            catch { tech.ResearchInefficiency = 0; }
            finally { textBox_ResInefficiency.Text = tech.ResearchInefficiency.ToString(); }

            try { tech.ResearchInefficiency = int.Parse(textBox_Cost.Text); }
            catch { tech.Cost = 0; }
            finally { textBox_ResInefficiency.Text = tech.Cost.ToString(); }

            try { tech.Mutation = double.Parse(textBox_Mutation.Text); }
            catch { tech.Mutation = 0; }
            finally { textBox_Mutation.Text = tech.Mutation.ToString(); }
        }
        private void button_UpdatePlaces_Click(object sender, EventArgs e)
        {
            List<string> Places = new List<string>()
            {
                $"富抗：{Tech.LowerPlaces[0]}~{Tech.HigherPlaces[0]}",
                $"贫抗：{Tech.LowerPlaces[1]}~{Tech.HigherPlaces[1]}",
                $"城抗：{Tech.LowerPlaces[2]}~{Tech.HigherPlaces[2]}",
                $"农抗：{Tech.LowerPlaces[3]}~{Tech.HigherPlaces[3]}",
                $"寒抗：{Tech.LowerPlaces[4]}~{Tech.HigherPlaces[4]}",
                $"热抗：{Tech.LowerPlaces[5]}~{Tech.HigherPlaces[5]}",
                $"干抗：{Tech.LowerPlaces[6]}~{Tech.HigherPlaces[6]}",
                $"潮抗：{Tech.LowerPlaces[7]}~{Tech.HigherPlaces[7]}",
                $"传染：{Tech.LowerPlaces[8]}~{Tech.HigherPlaces[8]}",
                $"严重：{Tech.LowerPlaces[9]}~{Tech.HigherPlaces[9]}",
                $"致命：{Tech.LowerPlaces[10]}~{Tech.HigherPlaces[10]}",
                $"突变：{Tech.LowerPlaces[11]}~{Tech.HigherPlaces[11]}",
                $"需求：{Tech.LowerPlaces[12]}~{Tech.HigherPlaces[12]}",
                $"阻滞：{Tech.LowerPlaces[13]}~{Tech.HigherPlaces[13]}"
            };
            string lines = String.Join("\r\n", Places);
            richTextBox_CurrentPlace.Text = lines;
        }
    }
}
