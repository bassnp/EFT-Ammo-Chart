using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovAmmoForm
{
    public delegate void DataSentHandler(bool vitalCheck, bool limbCheck, bool armorCheck, bool priceCheck, 
                                                                     bool toggleAllCheck, int colorScheme);
    public partial class OptionsForm : Form
    {     
        public event DataSentHandler DataSent;

        Point initPos;
        bool toogleAmoo = false;
        Color mainColor, otherColor;
        public OptionsForm(Point iPos, bool iVital, bool iLimb, bool iArmor, bool iPrice, bool toggle, int sColor)
        {
            InitializeComponent();
            initPos = iPos;

            vitalCheckbox.Checked = iVital;
            limbCheckbox.Checked = iLimb;
            armorCheckbox.Checked = iArmor;
            ammoPriceCheckbox.Checked = iPrice;

            colorSchemeBox.SelectedIndex = sColor;

            updateColors(sColor);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics grfx = e.Graphics;
            int thiccness = 1;
            Pen pen = new Pen(mainColor, thiccness);
            Rectangle rect = new Rectangle(thiccness / 2, thiccness / 2, this.Width - thiccness, this.Height - thiccness);

            grfx.DrawRectangle(pen, rect);
        }

        private void cb_Toggle(CheckBox cb, bool Checked)
        {
            if (Checked)
            {
                cb.ForeColor = mainColor;
                cb.BackColor = Color.FromArgb(0, 255, 255, 255);
            }
            else
            {
                cb.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cb.BackColor = Color.FromArgb(0, 255, 255, 255);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = initPos;
        }
        //  cb_Toggle(x, x.Checked);
        private void vitalCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(vitalCheckbox, vitalCheckbox.Checked);
        }

        private void limbCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(limbCheckbox, limbCheckbox.Checked);
        }

        private void armorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(armorCheckbox, armorCheckbox.Checked);
        }

        private void ammoPriceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(ammoPriceCheckbox, ammoPriceCheckbox.Checked);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activeFormTimer_Tick(object sender, EventArgs e)
        {
            this.DataSent(
                vitalCheckbox.Checked,
                limbCheckbox.Checked,
                armorCheckbox.Checked,
                ammoPriceCheckbox.Checked,
                toogleAmoo,
                colorSchemeBox.SelectedIndex);
            toogleAmoo = false;
            if (ActiveForm != this)
            {
                this.Close();
            }
        }

        private void toggleAmmo_Click(object sender, EventArgs e)
        {
            toogleAmoo = !toogleAmoo;
        }

        private void toggleAmmo_MouseEnter(object sender, EventArgs e)
        {
            toggleAmmo.ForeColor = Color.Black;
        }

        private void toggleAmmo_MouseLeave(object sender, EventArgs e)
        {
            toggleAmmo.ForeColor = Color.White;
        }

        private void updateColors(int s)
        {
            switch (s)
            {
                case 0:
                    mainColor = Color.FromArgb(255, 255, 65, 55);
                    otherColor = Color.FromArgb(255, 15, 15, 19);
                    break;
                case 1:
                    mainColor = Color.FromArgb(255, 81, 77, 51);
                    otherColor = Color.FromArgb(255, 11, 11, 11);
                    break;
                case 2:

                    break;
                default: break;
            }

            toggleAmmo.FlatAppearance.MouseOverBackColor = mainColor;

            cb_Toggle(vitalCheckbox, vitalCheckbox.Checked);
            cb_Toggle(limbCheckbox, limbCheckbox.Checked);
            cb_Toggle(armorCheckbox, armorCheckbox.Checked);
            cb_Toggle(ammoPriceCheckbox, ammoPriceCheckbox.Checked);

            this.BackColor = otherColor;
        }

        private void colorSchemeBox_MouseMove(object sender, MouseEventArgs e)
        {

        }
        int lastIndex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (colorSchemeBox.SelectedIndex != lastIndex)
            {
                lastIndex = colorSchemeBox.SelectedIndex;
                updateColors(colorSchemeBox.SelectedIndex);
            }       
        }

        private void colorSchemeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateColors(colorSchemeBox.SelectedIndex);
        }
    }
}
