namespace ProyectoLenguajeC.Vista
{
    partial class FormMantenimiento
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
            this.btnReservar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlComentarios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlZonaMant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeZonaComun = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReservar.IconColor = System.Drawing.Color.Black;
            this.btnReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservar.Location = new System.Drawing.Point(272, 402);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(134, 48);
            this.btnReservar.TabIndex = 17;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 38);
            this.label4.TabIndex = 16;
            this.label4.Text = "Comentarios\r\n\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.PnlComentarios);
            this.panel3.Location = new System.Drawing.Point(26, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 27);
            this.panel3.TabIndex = 15;
            // 
            // PnlComentarios
            // 
            this.PnlComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlComentarios.Location = new System.Drawing.Point(0, 0);
            this.PnlComentarios.Name = "PnlComentarios";
            this.PnlComentarios.Size = new System.Drawing.Size(251, 22);
            this.PnlComentarios.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zona de Mantenimiento\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mantenimiento\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.PnlZonaMant);
            this.panel1.Location = new System.Drawing.Point(25, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 27);
            this.panel1.TabIndex = 13;
            // 
            // PnlZonaMant
            // 
            this.PnlZonaMant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZonaMant.Location = new System.Drawing.Point(0, 0);
            this.PnlZonaMant.Name = "PnlZonaMant";
            this.PnlZonaMant.Size = new System.Drawing.Size(251, 22);
            this.PnlZonaMant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de mantenimiento\r\n\r\n";
            // 
            // dateTimeZonaComun
            // 
            this.dateTimeZonaComun.Location = new System.Drawing.Point(25, 148);
            this.dateTimeZonaComun.Name = "dateTimeZonaComun";
            this.dateTimeZonaComun.Size = new System.Drawing.Size(285, 22);
            this.dateTimeZonaComun.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.dateTimeZonaComun);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(377, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 498);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoLenguajeC.Properties.Resources.kisspng_apartamentos_liv_condominium_edificios_de_apartame_apartamento_edificio_el_rosario_5b250bdeb65a42_2314325415291545267469;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormMantenimiento
            // 
            this.ClientSize = new System.Drawing.Size(804, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantenimiento";
            this.Load += new System.EventHandler(this.FormMantenimiento_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TreeView treeView1;
        private FontAwesome.Sharp.IconButton btnReservar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PnlComentarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PnlZonaMant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeZonaComun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}