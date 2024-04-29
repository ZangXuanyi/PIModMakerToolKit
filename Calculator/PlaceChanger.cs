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
    public partial class PlaceChanger : Form
    {
        public PlaceChanger()
        {
            InitializeComponent();
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            textBox_WealthyRL.Text = Tech.LowerPlaces[0].ToString();
            textBox_PovertyRL.Text = Tech.LowerPlaces[1].ToString();
            textBox_UrbanRL.Text = Tech.LowerPlaces[2].ToString();

        }
    }
}
