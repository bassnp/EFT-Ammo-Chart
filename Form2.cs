using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm;
using TarkovAmmoForm;

namespace TarkovAmmoForm
{
    public partial class HoverForm : Form
    {
        string currentName, bulletTrader, bulletCost;
        int bulletDamage, bulletPen, bulletID;
        bool ammoPrice;
        Point bulletLoc = new Point();
        Point mainFormLoc = new Point();
        Color mColor;
        public HoverForm(string bName, int bDam, int bPen, int bID, Point loc, Point mLoc, bool aPrice, string bTrade, string bCost, Color mainColor, Color otherColor)
        {
            InitializeComponent();
            currentName = bName;
            bulletDamage = bDam;
            bulletPen = bPen;
            bulletID = bID;
            bulletLoc = loc;
            mainFormLoc = mLoc;
            ammoPrice = aPrice;
            bulletTrader = bTrade;
            bulletCost = bCost;

            caliberLabel.ForeColor = mainColor;
            damLabel1.ForeColor = mainColor;
            penLabel1.ForeColor = mainColor;
            tLabel.ForeColor = mainColor;

            this.BackColor = otherColor;
            mColor = mainColor;
        }

        private void mouseLeaveTimer_Tick(object sender, EventArgs e)
        {
            int mouseX = System.Windows.Forms.Cursor.Position.X;
            int mouseY = System.Windows.Forms.Cursor.Position.Y;

            Point bulletPos = new Point(mainFormLoc.X + bulletLoc.X, mainFormLoc.Y + bulletLoc.Y + 130);

            if (mouseX <= bulletPos.X - 7 || mouseX >= (bulletPos.X + 7) ||
                mouseY <= bulletPos.Y - 7 || mouseY >= (bulletPos.Y + 7))
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(mainFormLoc.X + bulletLoc.X - (this.Width / 2) + 15, mainFormLoc.Y + bulletLoc.Y - 39);
            
            string caliber;
            switch (bulletID)//colors :)
            {
                case 0: caliber = "7.62x25mm"; break;
                case 1: caliber = "9x18mm"; break;
                case 2: caliber = "9x19mm"; break;
                case 3: caliber = "9x21mm"; break;
                case 4: caliber = ".45 ACP"; break;
                case 5: caliber = "4.6x30mm"; break;
                case 6: caliber = "5.7x28mm"; break;
                case 7: caliber = "5.45x39mm"; break;
                case 8: caliber = "5.56x45mm"; break;
                case 9: caliber = ".300 Blackout"; break;
                case 10: caliber = "7.62x39mm"; break;
                case 11: caliber = "7.62x51mm"; break;
                case 12: caliber = "7.62x54mmR"; break;
                case 13: caliber = ".338 Lapua Magnum"; break;
                case 14: caliber = "9x39mm"; break;
                case 15: caliber = ".366 TKM"; break;
                case 16: caliber = "12.7x55mm"; break;
                case 17: caliber = "12.7x108mm"; break;
                case 18: caliber = "12x70mm"; break;
                case 19: caliber = "20x70mm"; break;
                case 20: caliber = "23x75mm"; break;
                case 21: caliber = "30x29mm"; break;
                case 22: caliber = "40x46mm"; break;

                default: caliber = "Invalid"; break;
            }
            caliberLabel.Text = caliber;
            nameLabel.Text = currentName;

            damLabel.Text = bulletDamage.ToString();
            penLabel.Text = bulletPen.ToString();

            //def 205, 150 | other max 335, 150
            Size textSize1 = TextRenderer.MeasureText(currentName, new Font("Bahnschrift Condensed", 18, FontStyle.Bold));
            if (textSize1.Width + 89 >= this.Width)
            {
                this.Width = textSize1.Width + 89;
            }
            Size textSize2 = TextRenderer.MeasureText(caliber, new Font("Bahnschrift Condensed", 18, FontStyle.Bold));
            if (textSize2.Width + 89 >= this.Width)
            {
                this.Width = textSize2.Width + 89;
            }

            if (ammoPrice)
            {
                tLabel.Visible = true;
                traderLabel.Visible = true;

                traderLabel.Text = bulletTrader;

                Size textSize = TextRenderer.MeasureText(bulletTrader, new Font("Bahnschrift Condensed", 16, FontStyle.Regular));
                if (textSize.Width + 206 >= this.Width)
                {
                    this.Width = textSize.Width + 206;
                }

                Size textSize3 = TextRenderer.MeasureText(bulletCost, new Font("Bahnschrift Condensed", 16, FontStyle.Regular));
                if (textSize3.Width + 206 >= this.Width)
                {
                    this.Width = textSize3.Width + 206;
                }
            }
            else
            {
                tLabel.Visible = false;
                traderLabel.Visible = false;
            }

            Object rm = Properties.Resources.ResourceManager.GetObject(bulletID + currentName);
            Bitmap bImage = (Bitmap)rm;

            Image bulletImage = bImage;

            bulletPanel.BackgroundImage = bulletImage;
        }

        protected override void OnPaint(PaintEventArgs e)//default form panel paint outline shit idk
        {
            Graphics grfx = e.Graphics;
            int thiccness = 1;
            Pen pen = new Pen(mColor, thiccness);
            Rectangle rect = new Rectangle(thiccness / 2, thiccness / 2, this.Width - thiccness, this.Height - thiccness);

            grfx.DrawRectangle(pen, rect);


        }
    }
}
