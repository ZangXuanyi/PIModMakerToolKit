namespace Calculator
{
    public partial class FMainForm : Form
    {
        internal static Tech tech = new();
        public FMainForm()
        {
            InitializeComponent();
            SetAllTextToZero();
            UpdateAllPlaces();
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
            SaveTech();
            int lowerCost = tech.GetLowerCost();
            int higherCost = tech.GetHigherCost();
            textBox_Cost.Text = $"{lowerCost}~{higherCost}";
        }
        private void SaveTech()
        {
            try
            {
                tech.WealthyResistance = double.Parse(textBox_WealthyR.Text);
                tech.PovertyResistance = double.Parse(textBox_PovertyR.Text);
                tech.HotResistance = double.Parse(textBox_HotR.Text);
                tech.ColdResistance = double.Parse(textBox_ColdR.Text);
                tech.UrbanResistance = double.Parse(textBox_UrbanR.Text);
                tech.RuralResistance = double.Parse(textBox_RuralR.Text);
                tech.AridResistance = double.Parse(textBox_AridR.Text);
                tech.HumidResistance = double.Parse(textBox_HumidR.Text);
                tech.Infectivity = double.Parse(textBox_Infectivity.Text);
                tech.Severity = double.Parse(textBox_Severity.Text);
                tech.Lethality = double.Parse(textBox_Lethality.Text);
                tech.CureBaseMultiplier = double.Parse(textBox_CureBase.Text);
                tech.ResearchInefficiency = double.Parse(textBox_ResInefficiency.Text);
                tech.Cost = int.Parse(textBox_Cost.Text);
                tech.Mutation = double.Parse(textBox_Mutation.Text);
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

        private void button_UpdatePlaces_Click(object sender, EventArgs e)
        {
            UpdateAllPlaces();
        }

        private void UpdateAllPlaces()
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

        private void SetAllTextToZero()
        {
            textBox_AridR.Text = "0";
            textBox_ColdR.Text = "0";
            textBox_Cost.Text = "0";
            textBox_CureBase.Text = "0";
            textBox_HotR.Text = "0";
            textBox_HumidR.Text = "0";
            textBox_Infectivity.Text = "0";
            textBox_Lethality.Text = "0";
            textBox_Mutation.Text = "0";
            textBox_PovertyR.Text = "0";
            textBox_ResInefficiency.Text = "0";
            textBox_RuralR.Text = "0";
            textBox_Severity.Text = "0";
            textBox_UrbanR.Text = "0";
            textBox_WealthyR.Text = "0";
        }

        private void button_ChangePlaces_Click(object sender, EventArgs e)
        {
            FPlaceChanger placeChanger = new FPlaceChanger();
            placeChanger.Show();
        }
        private void button_ShowDCalculator_Click(object sender, EventArgs e)
        {
            SaveTech();
            FDegreeCalculator degreeCalculator = new FDegreeCalculator();
            degreeCalculator.Show();
        }
        private void button_ShowDMutation_Click(object sender, EventArgs e)
        {
            FMutationCalculator mutationCalculator = new FMutationCalculator();
            mutationCalculator.Show();
        }
    }
}
