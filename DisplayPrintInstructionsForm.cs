using CPW211_MurderMystery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW211_MurderMystery
{
    public partial class DisplayPrintInstructionsForm : Form
    {
        public DisplayPrintInstructionsForm()
        {
            InitializeComponent();
        }

        public void SetThemeLabel(string theme, string description)
        {
            rtbThemeSelection.Text = theme + ": " + description;
        }

        private void DisplayPrintInstructionsForm_Load(object sender, EventArgs e)
        {

        }
        /*
        public void SetListBoxItems(List<string> items)
        {
           listBox1.Items.Clear();
           foreach (var item in items)
           {
               listBox1.Items.Add(item);
           }
        }*/
    }
}




