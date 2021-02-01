using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TarkovAmmoForm.Properties;
using TarkovAmmoForm;

namespace WindowsForm
{
    public partial class MainForm : Form
    {
        bool vitalBreakpoints, limbBreakpoints, armorBreakpoints, ammoPrice, toggleAll, isResizing, colorChanged;
        int colorScheme;
        Color MainAccent;
        Color OtherAccent;
        public MainForm()
        {
            InitializeComponent();

            testLabel.Visible = false;
            testLabel2.Visible = false;
            
            vitalBreakpoints = true;
            limbBreakpoints = false;
            armorBreakpoints = true;
            ammoPrice = true;
            toggleAll = false;
            isResizing = false;
            colorChanged = true;

            colorScheme = 0;

            MainAccent = Color.FromArgb(255, 255, 65, 55);
            OtherAccent = Color.FromArgb(255, 15, 15, 19);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) // had to make move window function
        {
            int mouseX = e.X + this.DesktopLocation.X;
            int mouseY = e.Y + this.DesktopLocation.Y;
            if (mouseX > this.DesktopLocation.X && mouseX < this.DesktopLocation.X + (this.Width - 50) &&
                mouseY > this.DesktopLocation.Y && mouseY < this.DesktopLocation.Y + 35)
            {
                windowTicks = 0;
                moveWindowTimer.Enabled = true;
            }
        }
        
        private void Form1_MouseUp(object sender, MouseEventArgs e)// ^ see above
        {
            moveWindowTimer.Enabled = false;
        }

        private void nameLabel_MouseDown(object sender, MouseEventArgs e)//same here, so the text allows it to be moved aswell
        {
            int mouseX = e.X + this.DesktopLocation.X;
            int mouseY = e.Y + this.DesktopLocation.Y;
            if (mouseX > this.DesktopLocation.X && mouseX < this.DesktopLocation.X + (this.Width - 50) &&
                mouseY > this.DesktopLocation.Y && mouseY < this.DesktopLocation.Y + 35)
            {
                windowTicks = 0;
                moveWindowTimer.Enabled = true;
            }
        }

        private void nameLabel_MouseUp(object sender, MouseEventArgs e)
        {
            moveWindowTimer.Enabled = false;
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int windowTicks = 0;
        int offsetX;
        int offsetY;
        private void moveWindowTimer_Tick(object sender, EventArgs e)
        {
            windowTicks++;

            int mouseX = System.Windows.Forms.Cursor.Position.X;
            int mouseY = System.Windows.Forms.Cursor.Position.Y;

            if (windowTicks <= 1)
            {
                offsetX = this.DesktopLocation.X - mouseX;
                offsetY = this.DesktopLocation.Y - mouseY;
            }

            this.Location = new Point(mouseX + offsetX, mouseY + offsetY);
        }

        private void closeBttn_MouseEnter(object sender, EventArgs e)
        {
            closeBttn.ForeColor = Color.White;
        }
        private void closeBttn_MouseLeave(object sender, EventArgs e)
        {
            closeBttn.ForeColor = MainAccent;
        }

        private void minimizeBttn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBttn.ForeColor = Color.White;
        }

        private void minimizeBttn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBttn.ForeColor = MainAccent;
        }
        bool its4am = false;
        private void updateColors()
        {
            switch (colorScheme)
            {
                case 0:
                    MainAccent = Color.FromArgb(255, 255, 65, 55);
                    OtherAccent = Color.FromArgb(255, 15, 15, 19);
                    break;
                case 1:
                    MainAccent = Color.FromArgb(255, 81, 77, 51);
                    OtherAccent = Color.FromArgb(255, 11, 11, 11);
                    break;
                case 2: 
                    
                    break;
                default: break;
            }

            closeBttn.FlatAppearance.MouseOverBackColor = MainAccent;
            closeBttn.ForeColor = MainAccent;
            minimizeBttn.FlatAppearance.MouseOverBackColor = MainAccent;
            minimizeBttn.ForeColor = MainAccent;
            settingsBttn.FlatAppearance.MouseOverBackColor = MainAccent;
            settingsBttn.ForeColor = MainAccent;
            yueplol.ForeColor = MainAccent;

            this.BackColor = OtherAccent;

            this.Refresh();
            closeBttn.Refresh();
            minimizeBttn.Refresh();
        }
        protected override void OnPaint(PaintEventArgs e)//default form panel paint outline shit idk
        {
            if (!isResizing || colorChanged)
            {
                if(isResizing)
                    its4am = true;
                if (colorChanged)
                {
                    colorChanged = false;
                    updateColors();
                }

                Graphics grfx = e.Graphics;
                int thiccness = 1;
                Pen pen = new Pen(MainAccent, thiccness);
                Rectangle rect = new Rectangle(thiccness / 2, thiccness / 2, this.Width - thiccness, this.Height - thiccness);

                grfx.DrawRectangle(pen, rect);
                grfx.DrawLine(pen, 1, 36, this.Width, 36);
            }
            else if (its4am && isResizing)
            {
                its4am = false;
                this.Refresh();
            }
                
        }

        int[] bulletArray = new int[] { };

        List<Part> bulletList = new List<Part>();

        private void add_bullet(int dam, int pen, int arrayPos, string name, string trader)//idk why but this isnt being 100% accurate on the graph, around 85% accurate
        {
            Graphics bg = canvas.CreateGraphics();
            SolidBrush bulletBrush;
            switch (arrayPos)//colors :)
            {
                case 0:  bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));     break;
                case 1:  bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 128, 0));   break;
                case 2:  bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 0));   break;
                case 3:  bulletBrush = new SolidBrush(Color.FromArgb(255, 128, 255, 0));   break;
                case 4:  bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));     break;
                case 5:  bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 128));   break;
                case 6:  bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 255));   break;
                case 7:  bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 128, 255));   break;
                case 8:  bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));     break;
                case 9:  bulletBrush = new SolidBrush(Color.FromArgb(255, 128, 0, 255));   break;
                case 10: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 255));   break;
                case 11: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 128));   break;
                case 12: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 128, 128)); break;
                case 13: bulletBrush = new SolidBrush(Color.FromArgb(255, 128, 255, 128)); break;
                case 14: bulletBrush = new SolidBrush(Color.FromArgb(255, 128, 128, 255)); break;
                case 15: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 128)); break;
                case 16: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 128, 255)); break;
                case 17: bulletBrush = new SolidBrush(Color.FromArgb(255, 128, 255, 255)); break;
                case 18: bulletBrush = new SolidBrush(Color.FromArgb(255, 135, 90, 0));    break;
                case 19: bulletBrush = new SolidBrush(Color.FromArgb(255, 0, 90, 135));    break;
                case 20: bulletBrush = new SolidBrush(Color.FromArgb(255, 135, 0, 90));    break;
                case 21: bulletBrush = new SolidBrush(Color.FromArgb(255, 90, 0, 135));    break;
                case 22: bulletBrush = new SolidBrush(Color.FromArgb(255, 90, 135, 0));    break;

                default: bulletBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255)); break; // white means ivalid array pos
            }

            float canvasX;
            //wierd inaccurcy past 100 and under 100, but this work for some reason lol, math hard
            if (dam >= 100)
                canvasX = (float)Math.Round(50f + ((((float)canvas.Width - 100f) / 240f) * (float)dam));
            else
                canvasX = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * (float)dam));

            float canvasY = (float)Math.Round((float)canvas.Height - 50f - (((canvas.Height - 50f) / 97.5f) * (float)pen));

            bulletList.Add(new Part()
            {
                bulletDamage = dam,
                bulletPen = pen,
                bulletName = name,
                bulletTrader = trader,
                bulletID = arrayPos,
                bulletLoc = new Point((int)canvasX, (int)canvasY)
            });

            SolidBrush bulletBrush2 = new SolidBrush(Color.FromArgb(bulletBrush.Color.A, bulletBrush.Color.R, bulletBrush.Color.G, bulletBrush.Color.B));

            //bg.FillEllipse(bulletBrush2, canvasX - 8, canvasY - 8, 15, 15);
            
            bg.FillEllipse(bulletBrush, canvasX - 7, canvasY - 7, 13, 13);

            bg.FillEllipse(new SolidBrush(Color.FromArgb(bulletBrush.Color.A, bulletBrush.Color.R / 2, bulletBrush.Color.G / 2, bulletBrush.Color.B / 2)), canvasX - 5, canvasY - 5, 9, 9);
           
            bg.FillEllipse(new SolidBrush(Color.FromArgb(bulletBrush.Color.A, bulletBrush.Color.R / 3, bulletBrush.Color.G / 3, bulletBrush.Color.B / 3)), canvasX - 2, canvasY - 2, 4, 4);

            //bg.DrawString(canvasX.ToString(), font, brush, 0, 0, sformat);
        }

        private void rotateText(int x, int y, int degrees, string text, Font font, Graphics g, Brush brush, StringFormat sformat)
        {
            g.TranslateTransform(x, y);
            g.RotateTransform(degrees);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(text, font, brush, 0, 0, sformat);
            g.ResetTransform();
        }

        static string format(string input)
        {
            return string.Format("{0,3}", input);//right justified text for 3 digit numbers
        }

        int[] ammoArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            StringFormat sformat = new StringFormat();
            sformat.Alignment = StringAlignment.Center;

            Graphics g = canvas.CreateGraphics();

            SolidBrush graphBrush = new SolidBrush(Color.FromArgb(145, 255, 255, 255));
            SolidBrush titleBrush = new SolidBrush(Color.FromArgb(245, 255, 255, 255));
            Pen graphPen = new Pen(Color.FromArgb(75, 255, 255, 255), 1);
            Pen breakPointPen = new Pen(Color.FromArgb(175, 255, 255, 255), 1);

            float[] dashValues = { 5, 5, 5, 5 };//found this out, googled the microsoft docs for dashpatterns
            graphPen.DashPattern = dashValues;
            graphPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;

            breakPointPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            rotateText(canvas.Width - 20, canvas.Height / 2, 90, "Penetration", new Font("Bahnschrift Condensed", 15, FontStyle.Regular), g, titleBrush, sformat);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString("Damage", new Font("Bahnschrift Condensed", 15, FontStyle.Regular), titleBrush, canvas.Width / 2, 15, sformat);

            for (int i = 0; i <= 9; i++)//Penetration lines
            {
                int h = (canvas.Height - 50) - (((canvas.Height - 100) / 9) * i);
                g.DrawString(format(i * 10 + ""), new Font("Bahnschrift Condensed", 14, FontStyle.Bold), graphBrush, 15, h - 10);
                if (armorBreakpoints && i > 0 && i < 7)
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    g.DrawString("Armor Class " + i, new Font("Bahnschrift Condensed", 14, FontStyle.Bold), graphBrush, canvas.Width - 100, h - 20, sformat);
                    g.DrawLine(breakPointPen, 50, h, canvas.Width - 50, h);
                }
                else
                {
                    g.DrawLine(graphPen, 50, h, canvas.Width - 50, h);
                }
            }
            
            for (int i = 0; i <= 12; i++)//Damage lines
            {
                int w = (canvas.Width - 50) - (((canvas.Width - 100) / 12) * i);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(format((240 - (i * 20)) + ""), new Font("Bahnschrift Condensed", 14, FontStyle.Bold), graphBrush, w - 15, canvas.Height - 40);
                g.DrawLine(graphPen, w, canvas.Height - 45, w, canvas.Height - 48);
            }
            
            // // vitalBreakpoints, limbBreakpoints, armorBreakpoints, ammoPrice, toggleAll;
            if (vitalBreakpoints)
            {
                float headBreakPoint = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * 35f), 0);
                g.DrawLine(breakPointPen, headBreakPoint, 55, headBreakPoint, canvas.Height - 50);

                rotateText((int)headBreakPoint, 35, 0, "Head", new Font("Bahnschrift Condensed", 14, FontStyle.Regular), g, graphBrush, sformat);

                float thoraxBreakPoint = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * 85f), 0);
                g.DrawLine(breakPointPen, thoraxBreakPoint, 55, thoraxBreakPoint, canvas.Height - 50);

                rotateText((int)thoraxBreakPoint, 35, 0, "Thorax", new Font("Bahnschrift Condensed", 14, FontStyle.Regular), g, graphBrush, sformat);
            }
            if (limbBreakpoints)
            {
                float armBreakPoint = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * 60f), 0);
                g.DrawLine(breakPointPen, armBreakPoint, 55, armBreakPoint, canvas.Height - 50);
                rotateText((int)armBreakPoint, 35, 0, "Arm", new Font("Bahnschrift Condensed", 14, FontStyle.Regular), g, graphBrush, sformat);

                float legBreakPoint = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * 65f), 0);
                g.DrawLine(breakPointPen, legBreakPoint, 55, legBreakPoint, canvas.Height - 50);
                rotateText((int)legBreakPoint, 15, 0, "Leg", new Font("Bahnschrift Condensed", 14, FontStyle.Regular), g, graphBrush, sformat);

                float stomachBreakPoint = (float)Math.Round(50f + ((((float)canvas.Width - 50f) / 245f) * 70f), 0);
                g.DrawLine(breakPointPen, stomachBreakPoint, 55, stomachBreakPoint, canvas.Height - 50);
                rotateText((int)stomachBreakPoint, 35, 0, "Stomach", new Font("Bahnschrift Condensed", 14, FontStyle.Regular), g, graphBrush, sformat);
            }

            /*
            
            NOOW we can add the dots for each ammo type :)
             
            array pos is to differentiate colors later on

            so this is going to look like giant if else statement blocks filled with add bullets for each caliber checked. might be super ineffecient ¯\_(ツ)_/¯
            
             */

            bulletList.Clear();//clear to be ready for new additions

            // 7.62x25mm
            if (ammoArray[0] == 1)
            { 
                add_bullet(50, 25, 0, "TT Pst gzh", "Prapor LL3");
                add_bullet(55, 18, 0, "TT PT gzh", "Prapor LL2");
                add_bullet(58, 14, 0, "TT P gl", "Prapor LL2");
                add_bullet(58, 12, 0, "TT AKBS", "Prapor LL1");
                add_bullet(60, 11, 0, "TT FMJ43", "Prapor LL1");
                add_bullet(64, 8, 0, "TT LRN", "Jaeger LL2");
                add_bullet(66, 7, 0, "TT LRNPC", "Prapor LL2");
            }
            // 9x18mm
            if (ammoArray[1] == 1)
            {
                add_bullet(40, 28, 1, "PM PBM", "Prapor LL2");
                add_bullet(58, 24, 1, "PM PMM", "Prapor LL3");
                add_bullet(53, 18, 1, "PM 9 BZT gzh", "Prapor LL1");
                add_bullet(65, 13, 1, "PM RG028 gzh", "Prapor LL2");
                add_bullet(50, 12, 1, "PM Pst gzh", "Prapor LL1");
                add_bullet(59, 8, 1, "PM PPT gzh", "Prapor LL1");
                add_bullet(61, 7, 1, "PM PPe gzh", "Prapor LL1");
                add_bullet(58, 6, 1, "PM PRS gs", "Prapor LL1");
                add_bullet(55, 6, 1, "PM PS gs PPO", "Prapor LL1");
                add_bullet(50, 5, 1, "PM 9 P gzh", "Prapor LL1");
                add_bullet(54, 5, 1, "PM PSO gzh", "Prapor LL");
                add_bullet(69, 3, 1, "PM PSV", "Prapor LL2");
                add_bullet(77, 2, 1, "PM SP7 gzh", "Prapor LL3");
                add_bullet(67, 1, 1, "PM SP8 gzh", "Prapor LL3");
            }
            // 9x19mm
            if (ammoArray[2] == 1)
            {
                add_bullet(52, 39, 2, "7N31", "Prapor LL4");
                add_bullet(52, 30, 2, "AP 6.3", "Peacekeeper LL3");
                add_bullet(54, 20, 2, "Pst gzh", "Mechanic LL1");
                add_bullet(58, 14, 2, "Green Tracer", "Mechanic LL3");
                add_bullet(70, 10, 2, "Luger CCI", "Skier LL4");
                add_bullet(59, 10, 2, "PSO gzh", "Jaeger LL1");
                add_bullet(85, 8, 2, "Quakemaker", "Peacekeeper LL2");
                add_bullet(102, 2, 2, "RIP", "Jaeger LL4");
            }
            // 9x21mm
            if (ammoArray[3] == 1)
            {
                add_bullet(63, 39, 3, "SP13", "Prapor LL4");
                add_bullet(49, 35, 3, "SP10", "Prapor LL4");
                add_bullet(65, 18, 3, "SP11", "Prapor LL3");
                add_bullet(80, 15, 3, "SP12", "Prapor LL3");
            }
            // .45 ACP
            if (ammoArray[4] == 1)
            {
                add_bullet(70, 36, 4, "AP", "Peacekeeper LL3");
                add_bullet(69, 23, 4, "FMJ", "Peacekeeper LL2");
                add_bullet(74, 19, 4, "Hydra-Shock", "Peacekeeper LL3");
                add_bullet(95, 13, 4, "Lasermatch FMJ", "Peacekeeper LL2");
                add_bullet(127, 1, 4, "RIP", "Mechanic LL4");
            }
            // 4.6x30mm
            if (ammoArray[5] == 1)
            {
                add_bullet(35, 53, 5, "AP SX", "Mechanic LL4");
                add_bullet(43, 40, 5, "FMJ SX", "Peacekeeper");
                add_bullet(45, 36, 5, "Subsonic SX", "Mechanic LL3");
                add_bullet(65, 18, 5, "Action SX", "Mechanic LL1");
            }
            // 5.7x28mm
            if (ammoArray[6] == 1)
            {
                add_bullet(49, 37, 6, "SS190", "Peacekeeper LL3");
                add_bullet(54, 35, 6, "SB193", "Peacekeeper LL4");
                add_bullet(58, 33, 6, "L191", "Peacekeeper LL3");
                add_bullet(62, 20, 6, "SS197SR", "Peacekeeper LL2");
                add_bullet(81, 11, 6, "R37.X", "Mechanic LL4");
                add_bullet(74, 10, 6, "SS198LF", "Peacekeeper LL3");
                add_bullet(98, 8, 6, "R37.F", "Mechanic");
            }
            // 5.45x39mm
            if (ammoArray[7] == 1)
            {
                add_bullet(37, 62, 7, "7N39 Igolnik", "Loot Only");
                add_bullet(40, 51, 7, "BS", "Prapor LL4");
                add_bullet(44, 37, 7, "BT", "Prapor LL3");
                add_bullet(48, 32, 7, "BP", "Prapor LL3");
                add_bullet(46, 30, 7, "PP", "Prapor LL2");
                add_bullet(50, 25, 7, "PS", "Prapor LL1");
                add_bullet(54, 20, 7, "FMJ", "Skeir LL1");
                add_bullet(57, 20, 7, "T", "Prapor LL1");
                add_bullet(65, 15, 7, "US", "Prapor LL2");
                add_bullet(60, 14, 7, "PRS", "Prapor LL1");
                add_bullet(74, 11, 7, "HP", "Skier LL2");
                add_bullet(68, 11, 7, "SP", "Skier LL2");
            }
            // 5.56x45mm
            if (ammoArray[8] == 1)
            {
                add_bullet(40, 53, 8, "M995", "Peacekeeper LL4");
                add_bullet(45, 43, 8, "M855A1", "Peacekeeper LL3");
                add_bullet(51, 37, 8, "M856A1", "Peacekeeper LL2");
                add_bullet(50, 30, 8, "M855", "Peacekeeper LL1");
                add_bullet(52, 24, 8, "55 FMJ", "Skier LL1");
                add_bullet(55, 23, 8, "M856", "Peacekeeper LL2");
                add_bullet(60, 17, 8, "Mk 255 Mod 0", "Peacekeeper LL2");
                add_bullet(72, 9, 8, "55 HP", "Peacekeeper LL2");
                add_bullet(85, 3, 8, "Warmage", "Peacekeeper LL3");
            }
            // .300 Blackout
            if (ammoArray[9] == 1)
            {
                add_bullet(55, 44, 9, "AP", "Peacekeeper LL3");
                add_bullet(60, 28, 9, "BPZ", "Skier LL3");
            }
            // 7.62x39mm
            if (ammoArray[10] == 1)
            {
                add_bullet(58, 47, 10, "BP", "Prapor LL3");
                add_bullet(57, 32, 10, "PS", "Prapor LL1");
                add_bullet(62, 30, 10, "T45M", "Prapor LL2");
                add_bullet(56, 29, 10, "US", "Prapor LL3");
                add_bullet(87, 15, 10, "HP", "Jaeger LL2");
            }
            // 7.62x51mm
            if (ammoArray[11] == 1)
            {
                add_bullet(67, 70, 11, "M993", "Loot Only");
                add_bullet(70, 64, 11, "M61", "Peacekeeper LL4");
                add_bullet(79, 44, 11, "M62", "Peacekeeper LL3");
                add_bullet(80, 41, 11, "M80", "Peacekeeper LL2");
                add_bullet(60, 36, 11, "TPZ SP", "Jaeger LL1");
                add_bullet(88, 31, 11, "BPZ FMJ", "Jaeger LL2");
                add_bullet(107, 15, 11, "Ultra Nosler", "Jaeger LL4");
            }
            // 7.62x54mmR
            if (ammoArray[12] == 1)
            {
                add_bullet(72, 70, 12, "7N37", "Prapor LL4");
                add_bullet(75, 62, 12, "SNB", "Prapor LL4");
                add_bullet(78, 59, 12, "7BT1", "Prapor LL4");
                add_bullet(86, 45, 12, "7N1", "Prapor LL3");
                add_bullet(81, 42, 12, "LPS Gzh", "Prapor LL1");
                add_bullet(82, 41, 12, "T-46M", "Prapor LL2");
            }
            // .338 Lapua Magnum
            if (ammoArray[13] == 1)
            {
                add_bullet(115, 79, 13, "AP", "Loot Only");
                add_bullet(122, 47, 13, "FMJ", "Peacekeeper LL4");
                add_bullet(142, 32, 13, "UPZ", "Jaeger LL4");
                add_bullet(196, 18, 13, "TAC-X", "Mechanic LL4");
            }
            // 9x39mm
            if (ammoArray[14] == 1)
            {
                add_bullet(60, 55, 14, "7N12 BP", "Prapor LL4");
                add_bullet(64, 50, 14, "7N9 SPP", "Prapor LL4");
                add_bullet(58, 46, 14, "SP-6", "Prapor LL3");
                add_bullet(68, 38, 14, "SP-5", "Prapor LL2");
            }
            // .366 TKM
            if (ammoArray[15] == 1)
            {
                add_bullet(90, 42, 15, "AP", "Mechanic LL3");
                add_bullet(73, 30, 15, "EKO", "Jaeger LL2");
                add_bullet(98, 23, 15, "FMJ", "Skier LL1");
                add_bullet(110, 14, 15, "Geksa", "Jaeger LL2");
            }
            // 12.7x55mm
            if (ammoArray[16] == 1)
            {
                add_bullet(102, 46, 16, "PS12B", "Prapor LL4");
                add_bullet(115, 28, 16, "PS12", "Prapor LL4");
                add_bullet(165, 10, 16, "PS12A", "Prapor LL3");
            }
            // 12.7x108mm
            if (ammoArray[17] == 1)
            {
                add_bullet(182, 88, 17, "B-32", "None");
                add_bullet(199, 80, 17, "BZT-44M", "None");
            }
            // 12x70mm
            if (ammoArray[18] == 1)
            {
                add_bullet(164, 37, 18, "AP-20 Slug", "Jaeger LL4");
                add_bullet(25, 31, 18, "Flechette", "Jaeger LL3");
                add_bullet(197, 26, 18, ".50 BMG Slug", "Jaeger LL4");
                add_bullet(150, 20, 18, "Poleva-6u Slug", "Jaeger LL2");
                add_bullet(183, 20, 18, "FTX Custom Lite Slug", "Jaeger LL2");
                add_bullet(140, 17, 18, "Poleva - 3 Slug", "Jaeger LL1");
                add_bullet(85, 17, 18, "Dual Sabot Slug", "Prapor LL3");
                add_bullet(167, 15, 18, "Led slug", "Prapor LL1");
                add_bullet(206, 14, 18, "HP Slug Copper Sabot Premier", "Prapor LL3");
                add_bullet(190, 12, 18, "Grizzly 40 Slug", "Prapor LL2");
                add_bullet(35, 3, 18, "6.5 mm Express Buckshot", "Prapor LL2");
                add_bullet(39, 3, 18, "7mm Buckshot", "Prapor LL1");
                add_bullet(50, 2, 18, "8.5 mm Magnum Buckshot", "Jaeger LL2");
                add_bullet(220, 2, 18, "HP Slug SuperFormance", "Jaeger LL4");
                add_bullet(37, 1, 18, "5.25mm Buckshot", "Jaeger LL1");
                add_bullet(265, 0, 18, "RIP", "Jaeger LL4");
            }
            // 20x70mm
            if (ammoArray[19] == 1)
            {
                add_bullet(135, 17, 19, "Slug Poleva-6u", "Jaeger LL2");
                add_bullet(154, 16, 19, "Star Slug", "Jaeger LL3");
                add_bullet(120, 14, 19, "Slug Poleva - 3", "Jaeger LL1");
                add_bullet(198, 5, 19, "Devastator Slug", "Jaeger LL2");
                add_bullet(23, 3, 19, "7.3mm Buckshot", "Jaeger LL2");
                add_bullet(25, 3, 19, "7.5mm Buckshot", "Jaeger LL1");
                add_bullet(22, 2, 19, "6.2mm Buckshot", "Jaeger LL2");
                add_bullet(26, 1, 19, "5.6mm Buckshot", "Jaeger LL1");
            }
            // 23x75mm
            if (ammoArray[20] == 1)
            {
                add_bullet(192, 39, 20, "Barricade", "Prapor LL4");
                add_bullet(87, 11, 20, "Shrapnel-10", "Prapor LL2");
                add_bullet(78, 10, 20, "Shrapnel-25", "Prapor LL3");
                add_bullet(0, 0, 20, "Star", "Prapor LL3");
            }
            // 30x29mm
            if (ammoArray[21] == 1)
            {
                add_bullet(199, 1, 21, "VOG-30", "None");
            }
            // 40x46 mm
            if (ammoArray[22] == 1)
            {
                add_bullet(160, 5, 22, "M576", "Loot Only");
                add_bullet(199, 1, 22, "M381", "Peacekeeper LL3");
                add_bullet(199, 1, 22, "M386", "Peacekeeper LL4");
                add_bullet(199, 1, 22, "M406", "Loot Only");
                add_bullet(199, 1, 22, "M433", "Loot Only");
                add_bullet(199, 1, 22, "M441", "Loot Only");
            }
        }

        private void ammo_Group_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = ammo_Group.CreateGraphics();
            Pen borderPen = new Pen(MainAccent, 1);
            g.DrawRectangle(borderPen, 0, 0, ammo_Group.Width, ammo_Group.Height - 1);


        }

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

            float dx = (float)Math.Round(((float)e.X - 50f) / (((float)canvas.Width - 50f) / 245f), 0);
            float py = (float)Math.Round(((float)canvas.Height - (float)e.Y - 50f) / (((float)canvas.Height - 50f) / 95f), 0);

            if (dx < 0) dx = 0;
            if (dx > 240) dx = 240;

            if (py < 0) py = 0;
            if (py > 90) py = 90;

            testLabel2.Text = toggleAll.ToString();

            bool BulletHover = false;
            foreach (Part aBullet in bulletList)//canvasX - 8, canvasY - 8, 15, 15);
            {
                if ((e.X >= aBullet.bulletLoc.X - 5 && e.X <= aBullet.bulletLoc.X + 5) &&
                    (e.Y >= aBullet.bulletLoc.Y - 5 && e.Y <= aBullet.bulletLoc.Y + 5))
                {
                    testLabel.Text = aBullet.ToString();
                    BulletHover = true;

                    HoverForm hoverForm = new HoverForm(aBullet.bulletName, aBullet.bulletDamage, aBullet.bulletPen, aBullet.bulletID, aBullet.bulletLoc, 
                        new Point(this.Location.X, this.Location.Y), ammoPrice, aBullet.bulletTrader, aBullet.bulletCost, MainAccent, OtherAccent);

                    if (!CheckOpened("HoverForm"))
                        hoverForm.Show();
                }
            }
            if (!BulletHover)
            {
                testLabel.Text = "";
            }


            //testLabel.Text = "Dam: " + dx + " | Pen: " + py;
        }

        /*
         
        if (o.Checked)
            {//on
                o.Font = new Font("Bahnschrift Condensed", 13, FontStyle.Bold);
                o.ForeColor = Color.Black;
                o.BackColor = MainAccent;

                ammoArray[x] = 1;
            }
            else
            {//off
                o.Font = new Font("Bahnschrift Condensed", 13, FontStyle.Regular);
                o.ForeColor = MainAccent;
                o.BackColor = Color.FromArgb(0, 255, 255, 255);

                ammoArray[x] = 0;
            }
            canvas.Refresh();

         */
        private void cb_Toggle(CheckBox cb, bool Checked, int bulletArrayPos)
        {
            if (Checked)
            {
                Color selectedColor;
                switch (bulletArrayPos)//colors :)
                {
                    case 0: selectedColor = Color.FromArgb(255, 255, 0, 0); break;
                    case 1: selectedColor = Color.FromArgb(255, 255, 128, 0); break;
                    case 2: selectedColor = Color.FromArgb(255, 255, 255, 0); break;
                    case 3: selectedColor = Color.FromArgb(255, 128, 255, 0); break;
                    case 4: selectedColor = Color.FromArgb(255, 0, 255, 0); break;
                    case 5: selectedColor = Color.FromArgb(255, 0, 255, 128); break;
                    case 6: selectedColor = Color.FromArgb(255, 0, 255, 255); break;
                    case 7: selectedColor = Color.FromArgb(255, 0, 128, 255); break;
                    case 8: selectedColor = Color.FromArgb(255, 0, 0, 255); break;
                    case 9: selectedColor = Color.FromArgb(255, 128, 0, 255); break;
                    case 10: selectedColor = Color.FromArgb(255, 255, 0, 255); break;
                    case 11: selectedColor = Color.FromArgb(255, 255, 0, 128); break;
                    case 12: selectedColor = Color.FromArgb(255, 255, 128, 128); break;
                    case 13: selectedColor = Color.FromArgb(255, 128, 255, 128); break;
                    case 14: selectedColor = Color.FromArgb(255, 128, 128, 255); break;
                    case 15: selectedColor = Color.FromArgb(255, 255, 255, 128); break;
                    case 16: selectedColor = Color.FromArgb(255, 255, 128, 255); break;
                    case 17: selectedColor = Color.FromArgb(255, 128, 255, 255); break;
                    case 18: selectedColor = Color.FromArgb(255, 135, 90, 0); break;
                    case 19: selectedColor = Color.FromArgb(255, 0, 90, 135); break;
                    case 20: selectedColor = Color.FromArgb(255, 135, 0, 90); break;
                    case 21: selectedColor = Color.FromArgb(255, 90, 0, 135); break;
                    case 22: selectedColor = Color.FromArgb(255, 90, 135, 0); break;

                    default: selectedColor = Color.FromArgb(255, 255, 255, 255); break; // white means ivalid array pos
                }

                cb.Font = new Font("Bahnschrift Condensed", 12.75f, FontStyle.Bold);
                cb.ForeColor = selectedColor;
                cb.BackColor = Color.FromArgb(0, 255, 255, 255); ;

                ammoArray[bulletArrayPos] = 1;
            }
            else
            {
                cb.Font = new Font("Bahnschrift Condensed", 12.75f, FontStyle.Regular);
                cb.ForeColor = Color.FromArgb(255, 255, 255, 255);
                cb.BackColor = Color.FromArgb(0, 255, 255, 255);

                ammoArray[bulletArrayPos] = 0;
            }

            if(!doingToggle)
                canvas.Refresh();

        }
        //this gets lil bity nasty but its simple, 
        //its just passing the checkbox(aka "cb") and changing the color, acvtivating the array position, updating (via the canvas.refresh)
        private void cb_762x25mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_762x25mm, cb_762x25mm.Checked, 0);
        }

        private void cb_9x18mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_9x18mm, cb_9x18mm.Checked, 1);
        }

        private void cb_9x19mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_9x19mm, cb_9x19mm.Checked, 2);
        }

        private void cb_9x21mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_9x21mm, cb_9x21mm.Checked, 3);
        }

        private void cb_45acp_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_45acp, cb_45acp.Checked, 4);
        }

        private void cb_46x30mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_46x30mm, cb_46x30mm.Checked, 5);
        }

        private void cb_57x28mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_57x28mm, cb_57x28mm.Checked, 6);
        }

        private void cb_545x39mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_545x39mm, cb_545x39mm.Checked, 7);
        }

        private void cb_556x45mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_556x45mm, cb_556x45mm.Checked, 8);
        }

        private void cb_300Blackout_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_300Blackout, cb_300Blackout.Checked, 9);
        }

        private void cb_762x39mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_762x39mm, cb_762x39mm.Checked, 10);
        }

        private void cb_762x51mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_762x51mm, cb_762x51mm.Checked, 11);
        }

        private void cb_762x54mmR_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_762x54mmR, cb_762x54mmR.Checked, 12);
        }

        private void cb_338LapuaMagnum_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_338LapuaMagnum, cb_338LapuaMagnum.Checked, 13);
        }

        private void cb_9x39mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_9x39mm, cb_9x39mm.Checked, 14);
        }

        private void cb_366TKM_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_366TKM, cb_366TKM.Checked, 15);
        }

        private void cb_127x55mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_127x55mm, cb_127x55mm.Checked, 16);
        }

        private void cb_127x108mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_127x108mm, cb_127x108mm.Checked, 17);
        }

        private void cb_12x70mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_12x70mm, cb_12x70mm.Checked, 18);
        }

        private void cb_20x70mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_20x70mm, cb_20x70mm.Checked, 19);
        }

        private void cb_23x75mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_23x75mm, cb_23x75mm.Checked, 20);
        }

        private void cb_30x29mm_CheckedChanged(object sender, EventArgs e)
        {
            cb_Toggle(cb_30x29mm, cb_30x29mm.Checked, 21);
        }

        private void cb_40x46mm_CheckedChanged_1(object sender, EventArgs e)
        {
            cb_Toggle(cb_40x46mm, cb_40x46mm.Checked, 22);
        }

        private void settingsBttn_MouseEnter(object sender, EventArgs e)
        {
            settingsBttn.ForeColor = Color.White;
        }

        private void yeplol_Click(object sender, EventArgs e)
        {
            //self promotion :sunglasses:
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVCK80sRbUc-FXxejeqacCQ"); 
        }
        /*
         int mouseX = e.X + this.DesktopLocation.X;
            int mouseY = e.Y + this.DesktopLocation.Y;
            if (mouseX > this.DesktopLocation.X && mouseX < this.DesktopLocation.X + (this.Width - 50) &&
                mouseY > this.DesktopLocation.Y && mouseY < this.DesktopLocation.Y + 35)
            {
                windowTicks = 0;
                moveWindowTimer.Enabled = true;
            }
         */

        int sizeInitX, sizeInitY, sizeInitW, sizeInitH, sizeChangeType = 0;

        private void sizeingHelp(int pos, bool down)
        {
            if (down)
            {
                isResizing = true;
                sizeChangeType = pos;

                sizeInitX = this.DesktopLocation.X;
                sizeInitY = this.DesktopLocation.Y;
                sizeInitW = this.Width;
                sizeInitH = this.Height;

                canvas.Visible = false;
                ammo_Group.Visible = false;

                sizeWindowTimer.Enabled = true;
            }
            else
            {
                sizeWindowTimer.Enabled = false;

                sizeChangeType = 0;

                ammo_Group.Visible = true;
                canvas.Visible = true;

                sizeInitX = 0;
                sizeInitY = 0;
                sizeInitW = 0;
                sizeInitH = 0;
                isResizing = false;

                ammo_Group.Refresh();
                canvas.Refresh(); 
            }
            this.Refresh();
        }
        //------------------------------------------------------------------
        private void rightSizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            sizeingHelp(3, true);
        }

        private void rightSizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            sizeingHelp(3, false);
        }
        //------------------------------------------------------------------
        private void topSizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            sizeingHelp(1, true);
        }
        
        private void topSizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            sizeingHelp(1, false);
        }
        //------------------------------------------------------------------
        private void bottomSizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            sizeingHelp(4, true);
        }

        private void bottomSizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            sizeingHelp(4, false);
        }

        //------------------------------------------------------------------
        private void leftSizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            sizeingHelp(2, true);
        }

        private void yueplol_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCVCK80sRbUc-FXxejeqacCQ/videos?view=0&sort=p&flow=grid");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void leftSizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            sizeingHelp(2, false);
        }
        //------------------------------------------------------------------
        //int penileCheese = 0;
        private void sizeWindowTimer_Tick(object sender, EventArgs e)
        {  
            int mouseX = System.Windows.Forms.Cursor.Position.X;
            int mouseY = System.Windows.Forms.Cursor.Position.Y;

            int newWidth;
            int newHeight;

            switch (sizeChangeType)
            {
                case 1:
                    newHeight = sizeInitH + (sizeInitY - mouseY);
                    if (newHeight > 550)
                    {
                        this.DesktopLocation = new Point(sizeInitX, mouseY);
                        this.Height = newHeight;
                    }
                    else
                        this.Height = 550;
                    break;
                case 2:
                    newWidth = sizeInitW + (sizeInitX - mouseX);
                    if (newWidth > 1052)
                    {
                        this.DesktopLocation = new Point(mouseX, sizeInitY);
                        this.Width = newWidth;
                    }
                    else
                        this.Width = 1052;
                    break;
                case 3:
                    newWidth = mouseX - sizeInitX;
                    if (newWidth > 1052)
                    {
                        this.Width = newWidth;
                        this.DesktopLocation = new Point(sizeInitX, sizeInitY);
                    }
                    else
                        this.Width = 1052;
                    break;
                case 4:
                    newHeight = mouseY - sizeInitY;
                    if (newHeight > 550)
                    {
                        this.Height = newHeight;
                        this.DesktopLocation = new Point(sizeInitX, sizeInitY);
                    }
                    else
                        this.Height = 550;
                    break;

                default: break;
            }                    
            
            //penileCheese++;
            //if(penileCheese % 5 == 0) // stops those wierd sizeing lines
                //this.Refresh();
        }

        private void settingsBttn_MouseLeave(object sender, EventArgs e)
        {
            settingsBttn.ForeColor = MainAccent;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://escapefromtarkov.gamepedia.com/Ammunition");
        }

        private bool isAllToggle()
        {
            if (cb_762x25mm.Checked &&
                cb_9x18mm.Checked &&
                cb_9x19mm.Checked &&
                cb_9x21mm.Checked &&
                cb_45acp.Checked &&
                cb_46x30mm.Checked &&
                cb_57x28mm.Checked &&
                cb_545x39mm.Checked &&
                cb_556x45mm.Checked &&
                cb_300Blackout.Checked &&
                cb_762x39mm.Checked &&
                cb_762x51mm.Checked &&
                cb_762x54mmR.Checked &&
                cb_338LapuaMagnum.Checked &&
                cb_9x39mm.Checked &&
                cb_366TKM.Checked &&
                cb_127x55mm.Checked &&
                cb_127x108mm.Checked &&
                cb_12x70mm.Checked &&
                cb_20x70mm.Checked &&
                cb_23x75mm.Checked &&
                cb_30x29mm.Checked &&
                cb_40x46mm.Checked)
                return true;
            else
                return false;
        }

        bool doingToggle = false;
        private void doToggleAll(bool state)
        {
            doingToggle = true;
            cb_762x25mm.Checked = state;
            cb_9x18mm.Checked = state;
            cb_9x19mm.Checked = state;
            cb_9x21mm.Checked = state;
            cb_45acp.Checked = state;
            cb_46x30mm.Checked = state;
            cb_57x28mm.Checked = state;
            cb_545x39mm.Checked = state;
            cb_556x45mm.Checked = state;
            cb_300Blackout.Checked = state;
            cb_762x39mm.Checked = state;
            cb_762x51mm.Checked = state;
            cb_762x54mmR.Checked = state;
            cb_338LapuaMagnum.Checked = state;
            cb_9x39mm.Checked = state;
            cb_366TKM.Checked = state;
            cb_127x55mm.Checked = state;
            cb_127x108mm.Checked = state;
            cb_12x70mm.Checked = state;
            cb_20x70mm.Checked = state;
            cb_23x75mm.Checked = state;
            cb_30x29mm.Checked = state;
            cb_40x46mm.Checked = state;
            doingToggle = false;
        }

        private void settingsBttn_Click(object sender, EventArgs e)
        {
            if (!CheckOpened("SettingsForm"))
            {
                OptionsForm settingsForm = new OptionsForm(new Point(this.DesktopLocation.X + this.Width - 1, this.DesktopLocation.Y), vitalBreakpoints, limbBreakpoints, armorBreakpoints, ammoPrice, isAllToggle(), colorScheme);
                settingsForm.DataSent += SettingsForm_DataSent;

                settingsForm.Show();
            }
        }

        // vitalBreakpoints, limbBreakpoints, armorBreakpoints, ammoPrice, toggleAll;
        public void SettingsForm_DataSent(bool vitalCheck, bool limbCheck, bool armorCheck, bool priceCheck, bool toggleAllCheck, int colorS)
        {
            
            bool checkChange = false;
            if (vitalBreakpoints != vitalCheck)
            {
                vitalBreakpoints = vitalCheck;
                checkChange = true;
            }
            
            if (limbBreakpoints != limbCheck)
            {
                limbBreakpoints = limbCheck;
                checkChange = true;
            }
            
            if (armorBreakpoints != armorCheck)
            {
                armorBreakpoints = armorCheck;
                checkChange = true;
            }
            
            if (ammoPrice != priceCheck)
            {
                ammoPrice = priceCheck;// no need to refresh, this accours when hovering over item
            } 
            if (toggleAllCheck)
            {
                if (isAllToggle())
                    doToggleAll(false);
                else
                    doToggleAll(true);
                //toggleAll = toggleAllCheck;
                checkChange = true;
            }
            if (colorScheme != colorS)
            {
                colorChanged = true;
                colorScheme = colorS;// no need to refresh, this accours when hovering over item
                checkChange = true;
            }
            if (checkChange)
                canvas.Refresh();
            /*
            vitalBreakpoints = vitalCheck;
            limbBreakpoints = limbCheck;
            armorBreakpoints = armorCheck;
            ammoPrice = priceCheck;
            toggleAll = toggleAllCheck;*/

        }
    }
    public class Part : IEquatable<Part>
    {
        public int bulletDamage { get; set; }
        public int bulletPen { get; set; }
        public string bulletName { get; set; }
        public string bulletTrader { get; set; }
        public string bulletCost { get; set; }
        public int bulletID { get; set; }
        public Point bulletLoc { get; set; }

        public override string ToString()
        {
            return "Dam: " + bulletDamage + "   Pen: " + bulletPen + "   Name: " + bulletName + "   Array Pos: " + bulletID;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.bulletName.Equals(other.bulletName));
        }
        public override int GetHashCode()
        {
            return bulletID;
        }
        // Should also override == and != operators.
    }
}
