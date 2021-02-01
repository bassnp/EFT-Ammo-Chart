
namespace TarkovAmmoForm
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.vitalCheckbox = new System.Windows.Forms.CheckBox();
            this.limbCheckbox = new System.Windows.Forms.CheckBox();
            this.armorCheckbox = new System.Windows.Forms.CheckBox();
            this.ammoPriceCheckbox = new System.Windows.Forms.CheckBox();
            this.activeFormTimer = new System.Windows.Forms.Timer(this.components);
            this.toggleAmmo = new System.Windows.Forms.Button();
            this.colorSchemeBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // vitalCheckbox
            // 
            this.vitalCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vitalCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.vitalCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.vitalCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vitalCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vitalCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vitalCheckbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.vitalCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vitalCheckbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitalCheckbox.ForeColor = System.Drawing.Color.White;
            this.vitalCheckbox.Location = new System.Drawing.Point(12, 12);
            this.vitalCheckbox.Name = "vitalCheckbox";
            this.vitalCheckbox.Size = new System.Drawing.Size(234, 39);
            this.vitalCheckbox.TabIndex = 2;
            this.vitalCheckbox.Text = "Show Vital Breakpoints";
            this.vitalCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vitalCheckbox.UseVisualStyleBackColor = false;
            this.vitalCheckbox.CheckedChanged += new System.EventHandler(this.vitalCheckbox_CheckedChanged);
            // 
            // limbCheckbox
            // 
            this.limbCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limbCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.limbCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.limbCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limbCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.limbCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limbCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limbCheckbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limbCheckbox.ForeColor = System.Drawing.Color.White;
            this.limbCheckbox.Location = new System.Drawing.Point(12, 57);
            this.limbCheckbox.Name = "limbCheckbox";
            this.limbCheckbox.Size = new System.Drawing.Size(234, 39);
            this.limbCheckbox.TabIndex = 3;
            this.limbCheckbox.Text = "Show Limb Breakpoints";
            this.limbCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.limbCheckbox.UseVisualStyleBackColor = false;
            this.limbCheckbox.CheckedChanged += new System.EventHandler(this.limbCheckbox_CheckedChanged);
            // 
            // armorCheckbox
            // 
            this.armorCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armorCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.armorCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.armorCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.armorCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.armorCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.armorCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.armorCheckbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorCheckbox.ForeColor = System.Drawing.Color.White;
            this.armorCheckbox.Location = new System.Drawing.Point(12, 102);
            this.armorCheckbox.Name = "armorCheckbox";
            this.armorCheckbox.Size = new System.Drawing.Size(234, 39);
            this.armorCheckbox.TabIndex = 4;
            this.armorCheckbox.Text = "Show Armor Breakpoints";
            this.armorCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.armorCheckbox.UseVisualStyleBackColor = false;
            this.armorCheckbox.CheckedChanged += new System.EventHandler(this.armorCheckbox_CheckedChanged);
            // 
            // ammoPriceCheckbox
            // 
            this.ammoPriceCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ammoPriceCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ammoPriceCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ammoPriceCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ammoPriceCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ammoPriceCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ammoPriceCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ammoPriceCheckbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoPriceCheckbox.ForeColor = System.Drawing.Color.White;
            this.ammoPriceCheckbox.Location = new System.Drawing.Point(12, 147);
            this.ammoPriceCheckbox.Name = "ammoPriceCheckbox";
            this.ammoPriceCheckbox.Size = new System.Drawing.Size(234, 39);
            this.ammoPriceCheckbox.TabIndex = 6;
            this.ammoPriceCheckbox.Text = "Show Trader Info";
            this.ammoPriceCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ammoPriceCheckbox.UseVisualStyleBackColor = false;
            this.ammoPriceCheckbox.CheckedChanged += new System.EventHandler(this.ammoPriceCheckbox_CheckedChanged);
            // 
            // activeFormTimer
            // 
            this.activeFormTimer.Enabled = true;
            this.activeFormTimer.Interval = 10;
            this.activeFormTimer.Tick += new System.EventHandler(this.activeFormTimer_Tick);
            // 
            // toggleAmmo
            // 
            this.toggleAmmo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleAmmo.AutoSize = true;
            this.toggleAmmo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.toggleAmmo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.toggleAmmo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.toggleAmmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAmmo.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F);
            this.toggleAmmo.ForeColor = System.Drawing.Color.White;
            this.toggleAmmo.Location = new System.Drawing.Point(12, 192);
            this.toggleAmmo.Name = "toggleAmmo";
            this.toggleAmmo.Size = new System.Drawing.Size(235, 40);
            this.toggleAmmo.TabIndex = 8;
            this.toggleAmmo.Text = "Toggle All Ammo";
            this.toggleAmmo.UseVisualStyleBackColor = true;
            this.toggleAmmo.Click += new System.EventHandler(this.toggleAmmo_Click);
            this.toggleAmmo.MouseEnter += new System.EventHandler(this.toggleAmmo_MouseEnter);
            this.toggleAmmo.MouseLeave += new System.EventHandler(this.toggleAmmo_MouseLeave);
            // 
            // colorSchemeBox
            // 
            this.colorSchemeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.colorSchemeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorSchemeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 17.25F);
            this.colorSchemeBox.ForeColor = System.Drawing.Color.White;
            this.colorSchemeBox.FormattingEnabled = true;
            this.colorSchemeBox.Items.AddRange(new object[] {
            "Defualt",
            "Neutral"});
            this.colorSchemeBox.Location = new System.Drawing.Point(13, 252);
            this.colorSchemeBox.Name = "colorSchemeBox";
            this.colorSchemeBox.Size = new System.Drawing.Size(234, 36);
            this.colorSchemeBox.TabIndex = 9;
            this.colorSchemeBox.Text = "Color Scheme";
            this.colorSchemeBox.SelectedIndexChanged += new System.EventHandler(this.colorSchemeBox_SelectedIndexChanged);
            this.colorSchemeBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorSchemeBox_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(259, 305);
            this.ControlBox = false;
            this.Controls.Add(this.colorSchemeBox);
            this.Controls.Add(this.vitalCheckbox);
            this.Controls.Add(this.toggleAmmo);
            this.Controls.Add(this.ammoPriceCheckbox);
            this.Controls.Add(this.limbCheckbox);
            this.Controls.Add(this.armorCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox vitalCheckbox;
        private System.Windows.Forms.CheckBox limbCheckbox;
        private System.Windows.Forms.CheckBox armorCheckbox;
        private System.Windows.Forms.CheckBox ammoPriceCheckbox;
        private System.Windows.Forms.Timer activeFormTimer;
        private System.Windows.Forms.Button toggleAmmo;
        private System.Windows.Forms.ComboBox colorSchemeBox;
        private System.Windows.Forms.Timer timer1;
    }
}