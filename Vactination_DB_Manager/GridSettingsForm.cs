using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
            MyDialog.Color = MainGridVievSettings.alternativeCellColorBackground;
            UnPairColor.BackColor = MyDialog.Color;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                MainGridVievSettings.alternativeCellColorBackground = MyDialog.Color;
                UnPairColor.BackColor = MyDialog.Color;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            MainGridVievSettings.q_of_patients_on_page = (int)qOfPatientsOnPage.Value;
            MainGridVievSettings.GridViewFont = new Font(FontFamily.Text, float.Parse(FontSize.Text));


            for (int i = 0; i < VisibleRows.Items.Count; i++)
            {
                if (VisibleRows.GetItemChecked(i))
                MainGridVievSettings.VisibleColums[i] = true;
                else MainGridVievSettings.VisibleColums[i] = false;
            }
            this.Close();
        }

        private void GridSettingsForm_Load(object sender, EventArgs e)
        {
            qOfPatientsOnPage.Value = MainGridVievSettings.q_of_patients_on_page;
            UnPairColor.BackColor = MainGridVievSettings.alternativeCellColorBackground;
            PairColor.BackColor = MainGridVievSettings.CellColorBackground;
            FontSize.Text = MainGridVievSettings.GridViewFont.Size.ToString();
            FontFamily.Text = MainGridVievSettings.GridViewFont.Name.ToString();
            makeColumsCheked();
        }

        private void PairColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.Color = MainGridVievSettings.CellColorBackground;
            PairColor.BackColor = MyDialog.Color;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                MainGridVievSettings.CellColorBackground = MyDialog.Color;
                PairColor.BackColor = MyDialog.Color;
        }
        private void makeColumsCheked()
        {
            for (int i = 0; i < VisibleRows.Items.Count; i++)
            {
                if (MainGridVievSettings.VisibleColums[i])
                {
                    VisibleRows.SetItemChecked(i, true);
                }
            }
        }
    }
}
