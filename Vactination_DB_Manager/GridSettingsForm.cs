using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vactination_DB_Manager
{
    public partial class GridSettingsForm : Form
    {
        public GridSettingsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;
            //MyDialog.Color;
            MyDialog.Color = MainGridVievSettings.alternativeCellColorBackground;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                MainGridVievSettings.alternativeCellColorBackground = MyDialog.Color;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            MainGridVievSettings.q_of_patients_on_page = (int)numericUpDown1.Value;
            this.Close();
        }
    }
}
