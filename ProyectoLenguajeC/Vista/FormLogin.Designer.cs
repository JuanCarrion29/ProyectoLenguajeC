namespace ProyectoLenguajeC.Vista
{
    partial class FormLogin
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
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxContra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxNombreLog = new System.Windows.Forms.TextBox();
            this.BtnLogin = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl1.SuspendLayout();
            this.PnlLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl1
            // 
            this.Pnl1.Controls.Add(this.pictureBox1);
            this.Pnl1.Controls.Add(this.label1);
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(430, 560);
            this.Pnl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantentenimiento y alquilres\r\nde condominios \r\n";
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.label4);
            this.PnlLogin.Controls.Add(this.panel2);
            this.PnlLogin.Controls.Add(this.label3);
            this.PnlLogin.Controls.Add(this.label2);
            this.PnlLogin.Controls.Add(this.panel1);
            this.PnlLogin.Location = new System.Drawing.Point(428, 0);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(501, 560);
            this.PnlLogin.TabIndex = 1;
            this.PnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLogin_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(75, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBoxContra);
            this.panel2.Location = new System.Drawing.Point(79, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 19);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TextBoxContra
            // 
            this.TextBoxContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxContra.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxContra.Location = new System.Drawing.Point(0, 0);
            this.TextBoxContra.Name = "TextBoxContra";
            this.TextBoxContra.PasswordChar = '*';
            this.TextBoxContra.Size = new System.Drawing.Size(312, 15);
            this.TextBoxContra.TabIndex = 1;
            this.TextBoxContra.TextChanged += new System.EventHandler(this.TextBoxContra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(75, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextBoxNombreLog);
            this.panel1.Location = new System.Drawing.Point(79, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 19);
            this.panel1.TabIndex = 0;
            // 
            // TextBoxNombreLog
            // 
            this.TextBoxNombreLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxNombreLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNombreLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxNombreLog.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBoxNombreLog.Location = new System.Drawing.Point(0, 0);
            this.TextBoxNombreLog.Name = "TextBoxNombreLog";
            this.TextBoxNombreLog.Size = new System.Drawing.Size(312, 15);
            this.TextBoxNombreLog.TabIndex = 1;
            this.TextBoxNombreLog.TextChanged += new System.EventHandler(this.TextBoxNombreLog_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnLogin.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnLogin.Location = new System.Drawing.Point(191, 428);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 47);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::ProyectoLenguajeC.Properties.Resources.condominioFot;
            this.pictureBox1.Location = new System.Drawing.Point(0, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.Pnl1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxNombreLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBoxContra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnLogin;
    }
}