
namespace WindowsForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.closeBttn = new System.Windows.Forms.Button();
            this.minimizeBttn = new System.Windows.Forms.Button();
            this.tabbedOutTimer = new System.Windows.Forms.Timer(this.components);
            this.moveWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.Panel();
            this.yueplol = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cb_545x39mm = new System.Windows.Forms.CheckBox();
            this.ammo_Group = new System.Windows.Forms.Panel();
            this.cb_40x46mm = new System.Windows.Forms.CheckBox();
            this.cb_30x29mm = new System.Windows.Forms.CheckBox();
            this.cb_23x75mm = new System.Windows.Forms.CheckBox();
            this.cb_20x70mm = new System.Windows.Forms.CheckBox();
            this.cb_12x70mm = new System.Windows.Forms.CheckBox();
            this.cb_127x108mm = new System.Windows.Forms.CheckBox();
            this.cb_127x55mm = new System.Windows.Forms.CheckBox();
            this.cb_366TKM = new System.Windows.Forms.CheckBox();
            this.cb_9x39mm = new System.Windows.Forms.CheckBox();
            this.cb_338LapuaMagnum = new System.Windows.Forms.CheckBox();
            this.cb_762x54mmR = new System.Windows.Forms.CheckBox();
            this.cb_762x51mm = new System.Windows.Forms.CheckBox();
            this.cb_762x39mm = new System.Windows.Forms.CheckBox();
            this.cb_300Blackout = new System.Windows.Forms.CheckBox();
            this.cb_556x45mm = new System.Windows.Forms.CheckBox();
            this.cb_57x28mm = new System.Windows.Forms.CheckBox();
            this.cb_46x30mm = new System.Windows.Forms.CheckBox();
            this.cb_45acp = new System.Windows.Forms.CheckBox();
            this.cb_9x21mm = new System.Windows.Forms.CheckBox();
            this.cb_9x19mm = new System.Windows.Forms.CheckBox();
            this.cb_9x18mm = new System.Windows.Forms.CheckBox();
            this.cb_762x25mm = new System.Windows.Forms.CheckBox();
            this.testLabel2 = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.settingsBttn = new System.Windows.Forms.Button();
            this.leftSizePanel = new System.Windows.Forms.Panel();
            this.sizeWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.rightSizePanel = new System.Windows.Forms.Panel();
            this.topSizePanel = new System.Windows.Forms.Panel();
            this.bottomSizePanel = new System.Windows.Forms.Panel();
            this.canvas.SuspendLayout();
            this.ammo_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBttn
            // 
            this.closeBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBttn.BackColor = System.Drawing.Color.Transparent;
            this.closeBttn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeBttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeBttn.FlatAppearance.BorderSize = 0;
            this.closeBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.closeBttn.Location = new System.Drawing.Point(1016, 1);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(35, 35);
            this.closeBttn.TabIndex = 2;
            this.closeBttn.Text = "✕";
            this.closeBttn.UseVisualStyleBackColor = false;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            this.closeBttn.MouseEnter += new System.EventHandler(this.closeBttn_MouseEnter);
            this.closeBttn.MouseLeave += new System.EventHandler(this.closeBttn_MouseLeave);
            // 
            // minimizeBttn
            // 
            this.minimizeBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBttn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBttn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimizeBttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minimizeBttn.FlatAppearance.BorderSize = 0;
            this.minimizeBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.minimizeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.minimizeBttn.Location = new System.Drawing.Point(980, 1);
            this.minimizeBttn.Name = "minimizeBttn";
            this.minimizeBttn.Size = new System.Drawing.Size(35, 35);
            this.minimizeBttn.TabIndex = 3;
            this.minimizeBttn.Text = "⎯";
            this.minimizeBttn.UseVisualStyleBackColor = false;
            this.minimizeBttn.Click += new System.EventHandler(this.minimizeBttn_Click);
            this.minimizeBttn.MouseEnter += new System.EventHandler(this.minimizeBttn_MouseEnter);
            this.minimizeBttn.MouseLeave += new System.EventHandler(this.minimizeBttn_MouseLeave);
            // 
            // moveWindowTimer
            // 
            this.moveWindowTimer.Interval = 1;
            this.moveWindowTimer.Tick += new System.EventHandler(this.moveWindowTimer_Tick);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.Transparent;
            this.canvas.Controls.Add(this.yueplol);
            this.canvas.ForeColor = System.Drawing.Color.Red;
            this.canvas.Location = new System.Drawing.Point(0, 131);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1051, 801);
            this.canvas.TabIndex = 4;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // yueplol
            // 
            this.yueplol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yueplol.AutoSize = true;
            this.yueplol.Cursor = System.Windows.Forms.Cursors.Help;
            this.yueplol.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yueplol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.yueplol.Location = new System.Drawing.Point(953, 780);
            this.yueplol.Name = "yueplol";
            this.yueplol.Size = new System.Drawing.Size(93, 18);
            this.yueplol.TabIndex = 16;
            this.yueplol.Text = "Created by Bassn";
            this.yueplol.Click += new System.EventHandler(this.yueplol_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(21, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(208, 42);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "EFT Ammo Chart";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseDown);
            this.nameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseUp);
            // 
            // cb_545x39mm
            // 
            this.cb_545x39mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_545x39mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_545x39mm.AutoEllipsis = true;
            this.cb_545x39mm.AutoSize = true;
            this.cb_545x39mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_545x39mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_545x39mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_545x39mm.FlatAppearance.BorderSize = 0;
            this.cb_545x39mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_545x39mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_545x39mm.ForeColor = System.Drawing.Color.White;
            this.cb_545x39mm.Location = new System.Drawing.Point(569, 7);
            this.cb_545x39mm.Name = "cb_545x39mm";
            this.cb_545x39mm.Size = new System.Drawing.Size(87, 31);
            this.cb_545x39mm.TabIndex = 0;
            this.cb_545x39mm.Text = "5.45x39mm";
            this.cb_545x39mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_545x39mm.UseVisualStyleBackColor = false;
            this.cb_545x39mm.CheckedChanged += new System.EventHandler(this.cb_545x39mm_CheckedChanged);
            // 
            // ammo_Group
            // 
            this.ammo_Group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ammo_Group.BackColor = System.Drawing.Color.Transparent;
            this.ammo_Group.Controls.Add(this.cb_40x46mm);
            this.ammo_Group.Controls.Add(this.cb_30x29mm);
            this.ammo_Group.Controls.Add(this.cb_23x75mm);
            this.ammo_Group.Controls.Add(this.cb_20x70mm);
            this.ammo_Group.Controls.Add(this.cb_12x70mm);
            this.ammo_Group.Controls.Add(this.cb_127x108mm);
            this.ammo_Group.Controls.Add(this.cb_127x55mm);
            this.ammo_Group.Controls.Add(this.cb_366TKM);
            this.ammo_Group.Controls.Add(this.cb_9x39mm);
            this.ammo_Group.Controls.Add(this.cb_338LapuaMagnum);
            this.ammo_Group.Controls.Add(this.cb_762x54mmR);
            this.ammo_Group.Controls.Add(this.cb_762x51mm);
            this.ammo_Group.Controls.Add(this.cb_762x39mm);
            this.ammo_Group.Controls.Add(this.cb_300Blackout);
            this.ammo_Group.Controls.Add(this.cb_556x45mm);
            this.ammo_Group.Controls.Add(this.cb_57x28mm);
            this.ammo_Group.Controls.Add(this.cb_46x30mm);
            this.ammo_Group.Controls.Add(this.cb_45acp);
            this.ammo_Group.Controls.Add(this.cb_9x21mm);
            this.ammo_Group.Controls.Add(this.cb_9x19mm);
            this.ammo_Group.Controls.Add(this.cb_9x18mm);
            this.ammo_Group.Controls.Add(this.cb_762x25mm);
            this.ammo_Group.Controls.Add(this.cb_545x39mm);
            this.ammo_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.ammo_Group.Location = new System.Drawing.Point(1, 54);
            this.ammo_Group.Name = "ammo_Group";
            this.ammo_Group.Size = new System.Drawing.Size(1050, 83);
            this.ammo_Group.TabIndex = 7;
            this.ammo_Group.Paint += new System.Windows.Forms.PaintEventHandler(this.ammo_Group_Paint);
            // 
            // cb_40x46mm
            // 
            this.cb_40x46mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_40x46mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_40x46mm.AutoEllipsis = true;
            this.cb_40x46mm.AutoSize = true;
            this.cb_40x46mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_40x46mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_40x46mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_40x46mm.FlatAppearance.BorderSize = 0;
            this.cb_40x46mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_40x46mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_40x46mm.ForeColor = System.Drawing.Color.White;
            this.cb_40x46mm.Location = new System.Drawing.Point(938, 44);
            this.cb_40x46mm.Name = "cb_40x46mm";
            this.cb_40x46mm.Size = new System.Drawing.Size(77, 31);
            this.cb_40x46mm.TabIndex = 22;
            this.cb_40x46mm.Text = "40x46mm";
            this.cb_40x46mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_40x46mm.UseVisualStyleBackColor = false;
            this.cb_40x46mm.CheckedChanged += new System.EventHandler(this.cb_40x46mm_CheckedChanged_1);
            // 
            // cb_30x29mm
            // 
            this.cb_30x29mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_30x29mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_30x29mm.AutoEllipsis = true;
            this.cb_30x29mm.AutoSize = true;
            this.cb_30x29mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_30x29mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_30x29mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_30x29mm.FlatAppearance.BorderSize = 0;
            this.cb_30x29mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_30x29mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_30x29mm.ForeColor = System.Drawing.Color.White;
            this.cb_30x29mm.Location = new System.Drawing.Point(855, 44);
            this.cb_30x29mm.Name = "cb_30x29mm";
            this.cb_30x29mm.Size = new System.Drawing.Size(77, 31);
            this.cb_30x29mm.TabIndex = 21;
            this.cb_30x29mm.Text = "30x29mm";
            this.cb_30x29mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_30x29mm.UseVisualStyleBackColor = false;
            this.cb_30x29mm.CheckedChanged += new System.EventHandler(this.cb_30x29mm_CheckedChanged);
            // 
            // cb_23x75mm
            // 
            this.cb_23x75mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_23x75mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_23x75mm.AutoEllipsis = true;
            this.cb_23x75mm.AutoSize = true;
            this.cb_23x75mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_23x75mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_23x75mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_23x75mm.FlatAppearance.BorderSize = 0;
            this.cb_23x75mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_23x75mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_23x75mm.ForeColor = System.Drawing.Color.White;
            this.cb_23x75mm.Location = new System.Drawing.Point(773, 44);
            this.cb_23x75mm.Name = "cb_23x75mm";
            this.cb_23x75mm.Size = new System.Drawing.Size(76, 31);
            this.cb_23x75mm.TabIndex = 20;
            this.cb_23x75mm.Text = "23x75mm";
            this.cb_23x75mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_23x75mm.UseVisualStyleBackColor = false;
            this.cb_23x75mm.CheckedChanged += new System.EventHandler(this.cb_23x75mm_CheckedChanged);
            // 
            // cb_20x70mm
            // 
            this.cb_20x70mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_20x70mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_20x70mm.AutoEllipsis = true;
            this.cb_20x70mm.AutoSize = true;
            this.cb_20x70mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_20x70mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_20x70mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_20x70mm.FlatAppearance.BorderSize = 0;
            this.cb_20x70mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_20x70mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_20x70mm.ForeColor = System.Drawing.Color.White;
            this.cb_20x70mm.Location = new System.Drawing.Point(691, 44);
            this.cb_20x70mm.Name = "cb_20x70mm";
            this.cb_20x70mm.Size = new System.Drawing.Size(76, 31);
            this.cb_20x70mm.TabIndex = 19;
            this.cb_20x70mm.Text = "20x70mm";
            this.cb_20x70mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_20x70mm.UseVisualStyleBackColor = false;
            this.cb_20x70mm.CheckedChanged += new System.EventHandler(this.cb_20x70mm_CheckedChanged);
            // 
            // cb_12x70mm
            // 
            this.cb_12x70mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_12x70mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_12x70mm.AutoEllipsis = true;
            this.cb_12x70mm.AutoSize = true;
            this.cb_12x70mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_12x70mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_12x70mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_12x70mm.FlatAppearance.BorderSize = 0;
            this.cb_12x70mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_12x70mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_12x70mm.ForeColor = System.Drawing.Color.White;
            this.cb_12x70mm.Location = new System.Drawing.Point(611, 44);
            this.cb_12x70mm.Name = "cb_12x70mm";
            this.cb_12x70mm.Size = new System.Drawing.Size(74, 31);
            this.cb_12x70mm.TabIndex = 18;
            this.cb_12x70mm.Text = "12x70mm";
            this.cb_12x70mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_12x70mm.UseVisualStyleBackColor = false;
            this.cb_12x70mm.CheckedChanged += new System.EventHandler(this.cb_12x70mm_CheckedChanged);
            // 
            // cb_127x108mm
            // 
            this.cb_127x108mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_127x108mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_127x108mm.AutoEllipsis = true;
            this.cb_127x108mm.AutoSize = true;
            this.cb_127x108mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_127x108mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_127x108mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_127x108mm.FlatAppearance.BorderSize = 0;
            this.cb_127x108mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_127x108mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_127x108mm.ForeColor = System.Drawing.Color.White;
            this.cb_127x108mm.Location = new System.Drawing.Point(516, 44);
            this.cb_127x108mm.Name = "cb_127x108mm";
            this.cb_127x108mm.Size = new System.Drawing.Size(89, 31);
            this.cb_127x108mm.TabIndex = 17;
            this.cb_127x108mm.Text = "12.7x108mm";
            this.cb_127x108mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_127x108mm.UseVisualStyleBackColor = false;
            this.cb_127x108mm.CheckedChanged += new System.EventHandler(this.cb_127x108mm_CheckedChanged);
            // 
            // cb_127x55mm
            // 
            this.cb_127x55mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_127x55mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_127x55mm.AutoEllipsis = true;
            this.cb_127x55mm.AutoSize = true;
            this.cb_127x55mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_127x55mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_127x55mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_127x55mm.FlatAppearance.BorderSize = 0;
            this.cb_127x55mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_127x55mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_127x55mm.ForeColor = System.Drawing.Color.White;
            this.cb_127x55mm.Location = new System.Drawing.Point(426, 44);
            this.cb_127x55mm.Name = "cb_127x55mm";
            this.cb_127x55mm.Size = new System.Drawing.Size(84, 31);
            this.cb_127x55mm.TabIndex = 16;
            this.cb_127x55mm.Text = "12.7x55mm";
            this.cb_127x55mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_127x55mm.UseVisualStyleBackColor = false;
            this.cb_127x55mm.CheckedChanged += new System.EventHandler(this.cb_127x55mm_CheckedChanged);
            // 
            // cb_366TKM
            // 
            this.cb_366TKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_366TKM.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_366TKM.AutoEllipsis = true;
            this.cb_366TKM.AutoSize = true;
            this.cb_366TKM.BackColor = System.Drawing.Color.Transparent;
            this.cb_366TKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_366TKM.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_366TKM.FlatAppearance.BorderSize = 0;
            this.cb_366TKM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_366TKM.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_366TKM.ForeColor = System.Drawing.Color.White;
            this.cb_366TKM.Location = new System.Drawing.Point(351, 44);
            this.cb_366TKM.Name = "cb_366TKM";
            this.cb_366TKM.Size = new System.Drawing.Size(69, 31);
            this.cb_366TKM.TabIndex = 15;
            this.cb_366TKM.Text = ".366 TKM";
            this.cb_366TKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_366TKM.UseVisualStyleBackColor = false;
            this.cb_366TKM.CheckedChanged += new System.EventHandler(this.cb_366TKM_CheckedChanged);
            // 
            // cb_9x39mm
            // 
            this.cb_9x39mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_9x39mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_9x39mm.AutoEllipsis = true;
            this.cb_9x39mm.AutoSize = true;
            this.cb_9x39mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_9x39mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_9x39mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x39mm.FlatAppearance.BorderSize = 0;
            this.cb_9x39mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_9x39mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_9x39mm.ForeColor = System.Drawing.Color.White;
            this.cb_9x39mm.Location = new System.Drawing.Point(275, 44);
            this.cb_9x39mm.Name = "cb_9x39mm";
            this.cb_9x39mm.Size = new System.Drawing.Size(70, 31);
            this.cb_9x39mm.TabIndex = 14;
            this.cb_9x39mm.Text = "9x39mm";
            this.cb_9x39mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x39mm.UseVisualStyleBackColor = false;
            this.cb_9x39mm.CheckedChanged += new System.EventHandler(this.cb_9x39mm_CheckedChanged);
            // 
            // cb_338LapuaMagnum
            // 
            this.cb_338LapuaMagnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_338LapuaMagnum.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_338LapuaMagnum.AutoEllipsis = true;
            this.cb_338LapuaMagnum.AutoSize = true;
            this.cb_338LapuaMagnum.BackColor = System.Drawing.Color.Transparent;
            this.cb_338LapuaMagnum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_338LapuaMagnum.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_338LapuaMagnum.FlatAppearance.BorderSize = 0;
            this.cb_338LapuaMagnum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_338LapuaMagnum.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_338LapuaMagnum.ForeColor = System.Drawing.Color.White;
            this.cb_338LapuaMagnum.Location = new System.Drawing.Point(137, 44);
            this.cb_338LapuaMagnum.Name = "cb_338LapuaMagnum";
            this.cb_338LapuaMagnum.Size = new System.Drawing.Size(132, 31);
            this.cb_338LapuaMagnum.TabIndex = 13;
            this.cb_338LapuaMagnum.Text = ".338 Lapua Magnum";
            this.cb_338LapuaMagnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_338LapuaMagnum.UseVisualStyleBackColor = false;
            this.cb_338LapuaMagnum.CheckedChanged += new System.EventHandler(this.cb_338LapuaMagnum_CheckedChanged);
            // 
            // cb_762x54mmR
            // 
            this.cb_762x54mmR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_762x54mmR.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_762x54mmR.AutoEllipsis = true;
            this.cb_762x54mmR.AutoSize = true;
            this.cb_762x54mmR.BackColor = System.Drawing.Color.Transparent;
            this.cb_762x54mmR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_762x54mmR.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x54mmR.FlatAppearance.BorderSize = 0;
            this.cb_762x54mmR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_762x54mmR.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_762x54mmR.ForeColor = System.Drawing.Color.White;
            this.cb_762x54mmR.Location = new System.Drawing.Point(37, 44);
            this.cb_762x54mmR.Name = "cb_762x54mmR";
            this.cb_762x54mmR.Size = new System.Drawing.Size(94, 31);
            this.cb_762x54mmR.TabIndex = 12;
            this.cb_762x54mmR.Text = "7.62x54mmR";
            this.cb_762x54mmR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x54mmR.UseVisualStyleBackColor = false;
            this.cb_762x54mmR.CheckedChanged += new System.EventHandler(this.cb_762x54mmR_CheckedChanged);
            // 
            // cb_762x51mm
            // 
            this.cb_762x51mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_762x51mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_762x51mm.AutoEllipsis = true;
            this.cb_762x51mm.AutoSize = true;
            this.cb_762x51mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_762x51mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_762x51mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x51mm.FlatAppearance.BorderSize = 0;
            this.cb_762x51mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_762x51mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_762x51mm.ForeColor = System.Drawing.Color.White;
            this.cb_762x51mm.Location = new System.Drawing.Point(948, 7);
            this.cb_762x51mm.Name = "cb_762x51mm";
            this.cb_762x51mm.Size = new System.Drawing.Size(84, 31);
            this.cb_762x51mm.TabIndex = 11;
            this.cb_762x51mm.Text = "7.62x51mm";
            this.cb_762x51mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x51mm.UseVisualStyleBackColor = false;
            this.cb_762x51mm.CheckedChanged += new System.EventHandler(this.cb_762x51mm_CheckedChanged);
            // 
            // cb_762x39mm
            // 
            this.cb_762x39mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_762x39mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_762x39mm.AutoEllipsis = true;
            this.cb_762x39mm.AutoSize = true;
            this.cb_762x39mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_762x39mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_762x39mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x39mm.FlatAppearance.BorderSize = 0;
            this.cb_762x39mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_762x39mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_762x39mm.ForeColor = System.Drawing.Color.White;
            this.cb_762x39mm.Location = new System.Drawing.Point(856, 7);
            this.cb_762x39mm.Name = "cb_762x39mm";
            this.cb_762x39mm.Size = new System.Drawing.Size(86, 31);
            this.cb_762x39mm.TabIndex = 10;
            this.cb_762x39mm.Text = "7.62x39mm";
            this.cb_762x39mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x39mm.UseVisualStyleBackColor = false;
            this.cb_762x39mm.CheckedChanged += new System.EventHandler(this.cb_762x39mm_CheckedChanged);
            // 
            // cb_300Blackout
            // 
            this.cb_300Blackout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_300Blackout.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_300Blackout.AutoEllipsis = true;
            this.cb_300Blackout.AutoSize = true;
            this.cb_300Blackout.BackColor = System.Drawing.Color.Transparent;
            this.cb_300Blackout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_300Blackout.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_300Blackout.FlatAppearance.BorderSize = 0;
            this.cb_300Blackout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_300Blackout.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_300Blackout.ForeColor = System.Drawing.Color.White;
            this.cb_300Blackout.Location = new System.Drawing.Point(755, 7);
            this.cb_300Blackout.Name = "cb_300Blackout";
            this.cb_300Blackout.Size = new System.Drawing.Size(95, 31);
            this.cb_300Blackout.TabIndex = 9;
            this.cb_300Blackout.Text = ".300 Blackout";
            this.cb_300Blackout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_300Blackout.UseVisualStyleBackColor = false;
            this.cb_300Blackout.CheckedChanged += new System.EventHandler(this.cb_300Blackout_CheckedChanged);
            // 
            // cb_556x45mm
            // 
            this.cb_556x45mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_556x45mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_556x45mm.AutoEllipsis = true;
            this.cb_556x45mm.AutoSize = true;
            this.cb_556x45mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_556x45mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_556x45mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_556x45mm.FlatAppearance.BorderSize = 0;
            this.cb_556x45mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_556x45mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_556x45mm.ForeColor = System.Drawing.Color.White;
            this.cb_556x45mm.Location = new System.Drawing.Point(662, 7);
            this.cb_556x45mm.Name = "cb_556x45mm";
            this.cb_556x45mm.Size = new System.Drawing.Size(87, 31);
            this.cb_556x45mm.TabIndex = 8;
            this.cb_556x45mm.Text = "5.56x45mm";
            this.cb_556x45mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_556x45mm.UseVisualStyleBackColor = false;
            this.cb_556x45mm.CheckedChanged += new System.EventHandler(this.cb_556x45mm_CheckedChanged);
            // 
            // cb_57x28mm
            // 
            this.cb_57x28mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_57x28mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_57x28mm.AutoEllipsis = true;
            this.cb_57x28mm.AutoSize = true;
            this.cb_57x28mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_57x28mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_57x28mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_57x28mm.FlatAppearance.BorderSize = 0;
            this.cb_57x28mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_57x28mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_57x28mm.ForeColor = System.Drawing.Color.White;
            this.cb_57x28mm.Location = new System.Drawing.Point(484, 7);
            this.cb_57x28mm.Name = "cb_57x28mm";
            this.cb_57x28mm.Size = new System.Drawing.Size(79, 31);
            this.cb_57x28mm.TabIndex = 7;
            this.cb_57x28mm.Text = "5.7x28mm";
            this.cb_57x28mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_57x28mm.UseVisualStyleBackColor = false;
            this.cb_57x28mm.CheckedChanged += new System.EventHandler(this.cb_57x28mm_CheckedChanged);
            // 
            // cb_46x30mm
            // 
            this.cb_46x30mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_46x30mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_46x30mm.AutoEllipsis = true;
            this.cb_46x30mm.AutoSize = true;
            this.cb_46x30mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_46x30mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_46x30mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_46x30mm.FlatAppearance.BorderSize = 0;
            this.cb_46x30mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_46x30mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_46x30mm.ForeColor = System.Drawing.Color.White;
            this.cb_46x30mm.Location = new System.Drawing.Point(398, 7);
            this.cb_46x30mm.Name = "cb_46x30mm";
            this.cb_46x30mm.Size = new System.Drawing.Size(80, 31);
            this.cb_46x30mm.TabIndex = 6;
            this.cb_46x30mm.Text = "4.6x30mm";
            this.cb_46x30mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_46x30mm.UseVisualStyleBackColor = false;
            this.cb_46x30mm.CheckedChanged += new System.EventHandler(this.cb_46x30mm_CheckedChanged);
            // 
            // cb_45acp
            // 
            this.cb_45acp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_45acp.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_45acp.AutoEllipsis = true;
            this.cb_45acp.AutoSize = true;
            this.cb_45acp.BackColor = System.Drawing.Color.Transparent;
            this.cb_45acp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_45acp.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_45acp.FlatAppearance.BorderSize = 0;
            this.cb_45acp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_45acp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_45acp.ForeColor = System.Drawing.Color.White;
            this.cb_45acp.Location = new System.Drawing.Point(331, 7);
            this.cb_45acp.Name = "cb_45acp";
            this.cb_45acp.Size = new System.Drawing.Size(61, 31);
            this.cb_45acp.TabIndex = 5;
            this.cb_45acp.Text = ".45 ACP";
            this.cb_45acp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_45acp.UseVisualStyleBackColor = false;
            this.cb_45acp.CheckedChanged += new System.EventHandler(this.cb_45acp_CheckedChanged);
            // 
            // cb_9x21mm
            // 
            this.cb_9x21mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_9x21mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_9x21mm.AutoEllipsis = true;
            this.cb_9x21mm.AutoSize = true;
            this.cb_9x21mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_9x21mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_9x21mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x21mm.FlatAppearance.BorderSize = 0;
            this.cb_9x21mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_9x21mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_9x21mm.ForeColor = System.Drawing.Color.White;
            this.cb_9x21mm.Location = new System.Drawing.Point(257, 7);
            this.cb_9x21mm.Name = "cb_9x21mm";
            this.cb_9x21mm.Size = new System.Drawing.Size(68, 31);
            this.cb_9x21mm.TabIndex = 4;
            this.cb_9x21mm.Text = "9x21mm";
            this.cb_9x21mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x21mm.UseVisualStyleBackColor = false;
            this.cb_9x21mm.CheckedChanged += new System.EventHandler(this.cb_9x21mm_CheckedChanged);
            // 
            // cb_9x19mm
            // 
            this.cb_9x19mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_9x19mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_9x19mm.AutoEllipsis = true;
            this.cb_9x19mm.AutoSize = true;
            this.cb_9x19mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_9x19mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_9x19mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x19mm.FlatAppearance.BorderSize = 0;
            this.cb_9x19mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_9x19mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_9x19mm.ForeColor = System.Drawing.Color.White;
            this.cb_9x19mm.Location = new System.Drawing.Point(183, 7);
            this.cb_9x19mm.Name = "cb_9x19mm";
            this.cb_9x19mm.Size = new System.Drawing.Size(68, 31);
            this.cb_9x19mm.TabIndex = 3;
            this.cb_9x19mm.Text = "9x19mm";
            this.cb_9x19mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x19mm.UseVisualStyleBackColor = false;
            this.cb_9x19mm.CheckedChanged += new System.EventHandler(this.cb_9x19mm_CheckedChanged);
            // 
            // cb_9x18mm
            // 
            this.cb_9x18mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_9x18mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_9x18mm.AutoEllipsis = true;
            this.cb_9x18mm.AutoSize = true;
            this.cb_9x18mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_9x18mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_9x18mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x18mm.FlatAppearance.BorderSize = 0;
            this.cb_9x18mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_9x18mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_9x18mm.ForeColor = System.Drawing.Color.White;
            this.cb_9x18mm.Location = new System.Drawing.Point(109, 7);
            this.cb_9x18mm.Name = "cb_9x18mm";
            this.cb_9x18mm.Size = new System.Drawing.Size(68, 31);
            this.cb_9x18mm.TabIndex = 2;
            this.cb_9x18mm.Text = "9x18mm";
            this.cb_9x18mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_9x18mm.UseVisualStyleBackColor = false;
            this.cb_9x18mm.CheckedChanged += new System.EventHandler(this.cb_9x18mm_CheckedChanged);
            // 
            // cb_762x25mm
            // 
            this.cb_762x25mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_762x25mm.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_762x25mm.AutoEllipsis = true;
            this.cb_762x25mm.AutoSize = true;
            this.cb_762x25mm.BackColor = System.Drawing.Color.Transparent;
            this.cb_762x25mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_762x25mm.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x25mm.FlatAppearance.BorderSize = 0;
            this.cb_762x25mm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_762x25mm.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_762x25mm.ForeColor = System.Drawing.Color.White;
            this.cb_762x25mm.Location = new System.Drawing.Point(17, 7);
            this.cb_762x25mm.Name = "cb_762x25mm";
            this.cb_762x25mm.Size = new System.Drawing.Size(86, 31);
            this.cb_762x25mm.TabIndex = 1;
            this.cb_762x25mm.Text = "7.62x25mm";
            this.cb_762x25mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_762x25mm.UseVisualStyleBackColor = false;
            this.cb_762x25mm.CheckedChanged += new System.EventHandler(this.cb_762x25mm_CheckedChanged);
            // 
            // testLabel2
            // 
            this.testLabel2.AutoSize = true;
            this.testLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.testLabel2.Location = new System.Drawing.Point(266, 21);
            this.testLabel2.Name = "testLabel2";
            this.testLabel2.Size = new System.Drawing.Size(60, 24);
            this.testLabel2.TabIndex = 9;
            this.testLabel2.Text = "label1";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.Color.Transparent;
            this.testLabel.Location = new System.Drawing.Point(566, 21);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(60, 24);
            this.testLabel.TabIndex = 8;
            this.testLabel.Text = "label1";
            // 
            // settingsBttn
            // 
            this.settingsBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBttn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBttn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.settingsBttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsBttn.FlatAppearance.BorderSize = 0;
            this.settingsBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.settingsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.settingsBttn.Location = new System.Drawing.Point(949, 1);
            this.settingsBttn.Name = "settingsBttn";
            this.settingsBttn.Size = new System.Drawing.Size(35, 35);
            this.settingsBttn.TabIndex = 10;
            this.settingsBttn.Text = "⚙️";
            this.settingsBttn.UseVisualStyleBackColor = false;
            this.settingsBttn.Click += new System.EventHandler(this.settingsBttn_Click);
            this.settingsBttn.MouseEnter += new System.EventHandler(this.settingsBttn_MouseEnter);
            this.settingsBttn.MouseLeave += new System.EventHandler(this.settingsBttn_MouseLeave);
            // 
            // leftSizePanel
            // 
            this.leftSizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.leftSizePanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftSizePanel.Location = new System.Drawing.Point(0, 12);
            this.leftSizePanel.Name = "leftSizePanel";
            this.leftSizePanel.Size = new System.Drawing.Size(10, 916);
            this.leftSizePanel.TabIndex = 11;
            this.leftSizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftSizePanel_MouseDown);
            this.leftSizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftSizePanel_MouseUp);
            // 
            // sizeWindowTimer
            // 
            this.sizeWindowTimer.Interval = 1;
            this.sizeWindowTimer.Tick += new System.EventHandler(this.sizeWindowTimer_Tick);
            // 
            // rightSizePanel
            // 
            this.rightSizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.rightSizePanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightSizePanel.Location = new System.Drawing.Point(1041, 38);
            this.rightSizePanel.Name = "rightSizePanel";
            this.rightSizePanel.Size = new System.Drawing.Size(10, 886);
            this.rightSizePanel.TabIndex = 12;
            this.rightSizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightSizePanel_MouseDown);
            this.rightSizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightSizePanel_MouseUp);
            // 
            // topSizePanel
            // 
            this.topSizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.topSizePanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.topSizePanel.Location = new System.Drawing.Point(11, 0);
            this.topSizePanel.Name = "topSizePanel";
            this.topSizePanel.Size = new System.Drawing.Size(938, 10);
            this.topSizePanel.TabIndex = 13;
            this.topSizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topSizePanel_MouseDown);
            this.topSizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topSizePanel_MouseUp);
            // 
            // bottomSizePanel
            // 
            this.bottomSizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomSizePanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomSizePanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomSizePanel.Location = new System.Drawing.Point(0, 928);
            this.bottomSizePanel.Name = "bottomSizePanel";
            this.bottomSizePanel.Size = new System.Drawing.Size(1052, 5);
            this.bottomSizePanel.TabIndex = 14;
            this.bottomSizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottomSizePanel_MouseDown);
            this.bottomSizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bottomSizePanel_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1052, 932);
            this.Controls.Add(this.bottomSizePanel);
            this.Controls.Add(this.topSizePanel);
            this.Controls.Add(this.rightSizePanel);
            this.Controls.Add(this.leftSizePanel);
            this.Controls.Add(this.settingsBttn);
            this.Controls.Add(this.testLabel2);
            this.Controls.Add(this.ammo_Group);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.minimizeBttn);
            this.Controls.Add(this.closeBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EFT Ammo Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ammo_Group.ResumeLayout(false);
            this.ammo_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBttn;
        private System.Windows.Forms.Button minimizeBttn;
        private System.Windows.Forms.Timer tabbedOutTimer;
        private System.Windows.Forms.Timer moveWindowTimer;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox cb_545x39mm;
        private System.Windows.Forms.Panel ammo_Group;
        private System.Windows.Forms.CheckBox cb_762x25mm;
        private System.Windows.Forms.CheckBox cb_9x19mm;
        private System.Windows.Forms.CheckBox cb_9x18mm;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label testLabel2;
        private System.Windows.Forms.CheckBox cb_40x46mm;
        private System.Windows.Forms.CheckBox cb_30x29mm;
        private System.Windows.Forms.CheckBox cb_23x75mm;
        private System.Windows.Forms.CheckBox cb_20x70mm;
        private System.Windows.Forms.CheckBox cb_12x70mm;
        private System.Windows.Forms.CheckBox cb_127x108mm;
        private System.Windows.Forms.CheckBox cb_127x55mm;
        private System.Windows.Forms.CheckBox cb_366TKM;
        private System.Windows.Forms.CheckBox cb_9x39mm;
        private System.Windows.Forms.CheckBox cb_338LapuaMagnum;
        private System.Windows.Forms.CheckBox cb_762x54mmR;
        private System.Windows.Forms.CheckBox cb_762x51mm;
        private System.Windows.Forms.CheckBox cb_762x39mm;
        private System.Windows.Forms.CheckBox cb_300Blackout;
        private System.Windows.Forms.CheckBox cb_556x45mm;
        private System.Windows.Forms.CheckBox cb_57x28mm;
        private System.Windows.Forms.CheckBox cb_46x30mm;
        private System.Windows.Forms.CheckBox cb_45acp;
        private System.Windows.Forms.CheckBox cb_9x21mm;
        private System.Windows.Forms.Button settingsBttn;
        private System.Windows.Forms.Panel leftSizePanel;
        private System.Windows.Forms.Timer sizeWindowTimer;
        private System.Windows.Forms.Panel rightSizePanel;
        private System.Windows.Forms.Panel topSizePanel;
        private System.Windows.Forms.Panel bottomSizePanel;
        private System.Windows.Forms.Label yueplol;
    }
}

