
namespace TarkovAmmoForm
{
    partial class HoverForm
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
            this.mouseLeaveTimer = new System.Windows.Forms.Timer(this.components);
            this.damLabel1 = new System.Windows.Forms.Label();
            this.penLabel1 = new System.Windows.Forms.Label();
            this.caliberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.damLabel = new System.Windows.Forms.Label();
            this.penLabel = new System.Windows.Forms.Label();
            this.bulletPanel = new System.Windows.Forms.Panel();
            this.tLabel = new System.Windows.Forms.Label();
            this.traderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mouseLeaveTimer
            // 
            this.mouseLeaveTimer.Enabled = true;
            this.mouseLeaveTimer.Tick += new System.EventHandler(this.mouseLeaveTimer_Tick);
            // 
            // damLabel1
            // 
            this.damLabel1.AutoSize = true;
            this.damLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.damLabel1.Location = new System.Drawing.Point(30, 86);
            this.damLabel1.Name = "damLabel1";
            this.damLabel1.Size = new System.Drawing.Size(80, 25);
            this.damLabel1.TabIndex = 6;
            this.damLabel1.Text = "Damage : ";
            // 
            // penLabel1
            // 
            this.penLabel1.AutoSize = true;
            this.penLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.penLabel1.Location = new System.Drawing.Point(4, 118);
            this.penLabel1.Name = "penLabel1";
            this.penLabel1.Size = new System.Drawing.Size(106, 25);
            this.penLabel1.TabIndex = 7;
            this.penLabel1.Text = "Penetration : ";
            // 
            // caliberLabel
            // 
            this.caliberLabel.AutoSize = true;
            this.caliberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caliberLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caliberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.caliberLabel.Location = new System.Drawing.Point(88, 9);
            this.caliberLabel.Name = "caliberLabel";
            this.caliberLabel.Size = new System.Drawing.Size(63, 29);
            this.caliberLabel.TabIndex = 8;
            this.caliberLabel.Text = "Label1";
            this.caliberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(88, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 29);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Label2";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // damLabel
            // 
            this.damLabel.AutoSize = true;
            this.damLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damLabel.ForeColor = System.Drawing.Color.White;
            this.damLabel.Location = new System.Drawing.Point(101, 87);
            this.damLabel.Name = "damLabel";
            this.damLabel.Size = new System.Drawing.Size(39, 25);
            this.damLabel.TabIndex = 10;
            this.damLabel.Text = "000";
            // 
            // penLabel
            // 
            this.penLabel.AutoSize = true;
            this.penLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penLabel.ForeColor = System.Drawing.Color.White;
            this.penLabel.Location = new System.Drawing.Point(101, 118);
            this.penLabel.Name = "penLabel";
            this.penLabel.Size = new System.Drawing.Size(39, 25);
            this.penLabel.TabIndex = 11;
            this.penLabel.Text = "000";
            // 
            // bulletPanel
            // 
            this.bulletPanel.BackColor = System.Drawing.Color.White;
            this.bulletPanel.Location = new System.Drawing.Point(12, 12);
            this.bulletPanel.Name = "bulletPanel";
            this.bulletPanel.Size = new System.Drawing.Size(64, 64);
            this.bulletPanel.TabIndex = 0;
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(55)))));
            this.tLabel.Location = new System.Drawing.Point(146, 99);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(69, 25);
            this.tLabel.TabIndex = 12;
            this.tLabel.Text = "Trader : ";
            // 
            // traderLabel
            // 
            this.traderLabel.AutoSize = true;
            this.traderLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traderLabel.ForeColor = System.Drawing.Color.White;
            this.traderLabel.Location = new System.Drawing.Point(206, 99);
            this.traderLabel.Name = "traderLabel";
            this.traderLabel.Size = new System.Drawing.Size(129, 25);
            this.traderLabel.TabIndex = 15;
            this.traderLabel.Text = "Peacekeeper LL4";
            // 
            // HoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(166, 150);
            this.Controls.Add(this.traderLabel);
            this.Controls.Add(this.tLabel);
            this.Controls.Add(this.penLabel);
            this.Controls.Add(this.damLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.caliberLabel);
            this.Controls.Add(this.penLabel1);
            this.Controls.Add(this.damLabel1);
            this.Controls.Add(this.bulletPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoverForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HoverForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mouseLeaveTimer;
        private System.Windows.Forms.Panel bulletPanel;
        private System.Windows.Forms.Label damLabel1;
        private System.Windows.Forms.Label penLabel1;
        private System.Windows.Forms.Label caliberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label damLabel;
        private System.Windows.Forms.Label penLabel;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label traderLabel;
    }
}