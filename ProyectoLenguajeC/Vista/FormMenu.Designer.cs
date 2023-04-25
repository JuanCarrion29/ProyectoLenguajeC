namespace ProyectoLenguajeC.Vista
{
    partial class FormMenu
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
            this.PanelM = new System.Windows.Forms.Panel();
            this.SubMenuRep = new System.Windows.Forms.Panel();
            this.PnlDNombre = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.BtnRepSalones = new FontAwesome.Sharp.IconButton();
            this.BtnManRep = new FontAwesome.Sharp.IconButton();
            this.BtnReInqui = new FontAwesome.Sharp.IconButton();
            this.ReporteBtn = new FontAwesome.Sharp.IconButton();
            this.SettingBtn = new FontAwesome.Sharp.IconButton();
            this.BtonUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtonSalones = new FontAwesome.Sharp.IconButton();
            this.BtonMaN = new FontAwesome.Sharp.IconButton();
            this.BtonInquilios = new FontAwesome.Sharp.IconButton();
            this.PanelM.SuspendLayout();
            this.SubMenuRep.SuspendLayout();
            this.PnlDNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelM
            // 
            this.PanelM.AutoScroll = true;
            this.PanelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelM.Controls.Add(this.SubMenuRep);
            this.PanelM.Controls.Add(this.ReporteBtn);
            this.PanelM.Controls.Add(this.SettingBtn);
            this.PanelM.Controls.Add(this.BtonUsuarios);
            this.PanelM.Controls.Add(this.BtonSalones);
            this.PanelM.Controls.Add(this.BtonMaN);
            this.PanelM.Controls.Add(this.BtonInquilios);
            this.PanelM.Controls.Add(this.PnlDNombre);
            this.PanelM.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelM.Location = new System.Drawing.Point(0, 0);
            this.PanelM.Name = "PanelM";
            this.PanelM.Size = new System.Drawing.Size(309, 613);
            this.PanelM.TabIndex = 0;
            this.PanelM.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelM_Paint);
            // 
            // SubMenuRep
            // 
            this.SubMenuRep.Controls.Add(this.BtnRepSalones);
            this.SubMenuRep.Controls.Add(this.BtnManRep);
            this.SubMenuRep.Controls.Add(this.BtnReInqui);
            this.SubMenuRep.Location = new System.Drawing.Point(94, 442);
            this.SubMenuRep.Name = "SubMenuRep";
            this.SubMenuRep.Size = new System.Drawing.Size(215, 157);
            this.SubMenuRep.TabIndex = 7;
            this.SubMenuRep.Visible = false;
            // 
            // PnlDNombre
            // 
            this.PnlDNombre.Controls.Add(this.labelNombreUser);
            this.PnlDNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDNombre.Location = new System.Drawing.Point(0, 0);
            this.PnlDNombre.Name = "PnlDNombre";
            this.PnlDNombre.Size = new System.Drawing.Size(309, 136);
            this.PnlDNombre.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(309, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(881, 613);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreUser.Location = new System.Drawing.Point(111, 49);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(7, 16);
            this.labelNombreUser.TabIndex = 0;
            this.labelNombreUser.Text = "\r\n";
            // 
            // BtnRepSalones
            // 
            this.BtnRepSalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtnRepSalones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRepSalones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRepSalones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepSalones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRepSalones.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BtnRepSalones.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnRepSalones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRepSalones.IconSize = 30;
            this.BtnRepSalones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepSalones.Location = new System.Drawing.Point(0, 100);
            this.BtnRepSalones.Name = "BtnRepSalones";
            this.BtnRepSalones.Size = new System.Drawing.Size(215, 54);
            this.BtnRepSalones.TabIndex = 9;
            this.BtnRepSalones.Text = "Area Comun";
            this.BtnRepSalones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRepSalones.UseVisualStyleBackColor = false;
            this.BtnRepSalones.Click += new System.EventHandler(this.BtnRepSalones_Click);
            // 
            // BtnManRep
            // 
            this.BtnManRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtnManRep.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnManRep.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManRep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnManRep.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BtnManRep.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnManRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnManRep.IconSize = 30;
            this.BtnManRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManRep.Location = new System.Drawing.Point(0, 50);
            this.BtnManRep.Name = "BtnManRep";
            this.BtnManRep.Size = new System.Drawing.Size(215, 50);
            this.BtnManRep.TabIndex = 8;
            this.BtnManRep.Text = "Mantenimientos";
            this.BtnManRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnManRep.UseVisualStyleBackColor = false;
            this.BtnManRep.Click += new System.EventHandler(this.BtnManRep_Click);
            // 
            // BtnReInqui
            // 
            this.BtnReInqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtnReInqui.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReInqui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReInqui.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReInqui.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReInqui.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BtnReInqui.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReInqui.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReInqui.IconSize = 30;
            this.BtnReInqui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReInqui.Location = new System.Drawing.Point(0, 0);
            this.BtnReInqui.Name = "BtnReInqui";
            this.BtnReInqui.Size = new System.Drawing.Size(215, 50);
            this.BtnReInqui.TabIndex = 7;
            this.BtnReInqui.Text = "Inquilinos";
            this.BtnReInqui.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReInqui.UseVisualStyleBackColor = false;
            this.BtnReInqui.Click += new System.EventHandler(this.BtnReInqui_Click);
            // 
            // ReporteBtn
            // 
            this.ReporteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.ReporteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReporteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReporteBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReporteBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.ReporteBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ReporteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReporteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReporteBtn.Location = new System.Drawing.Point(0, 386);
            this.ReporteBtn.Name = "ReporteBtn";
            this.ReporteBtn.Size = new System.Drawing.Size(309, 50);
            this.ReporteBtn.TabIndex = 6;
            this.ReporteBtn.Text = "Reportes";
            this.ReporteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReporteBtn.UseVisualStyleBackColor = false;
            this.ReporteBtn.Click += new System.EventHandler(this.ReporteBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingBtn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.SettingBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.SettingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingBtn.Location = new System.Drawing.Point(0, 336);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(309, 50);
            this.SettingBtn.TabIndex = 5;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // BtonUsuarios
            // 
            this.BtonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtonUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtonUsuarios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtonUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtonUsuarios.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtonUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtonUsuarios.IconSize = 40;
            this.BtonUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonUsuarios.Location = new System.Drawing.Point(0, 286);
            this.BtonUsuarios.Name = "BtonUsuarios";
            this.BtonUsuarios.Size = new System.Drawing.Size(309, 50);
            this.BtonUsuarios.TabIndex = 4;
            this.BtonUsuarios.Text = "Usuarios";
            this.BtonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtonUsuarios.UseVisualStyleBackColor = false;
            this.BtonUsuarios.Click += new System.EventHandler(this.BtonUsuarios_Click);
            // 
            // BtonSalones
            // 
            this.BtonSalones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtonSalones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtonSalones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtonSalones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonSalones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtonSalones.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.BtonSalones.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtonSalones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtonSalones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonSalones.Location = new System.Drawing.Point(0, 236);
            this.BtonSalones.Name = "BtonSalones";
            this.BtonSalones.Size = new System.Drawing.Size(309, 50);
            this.BtonSalones.TabIndex = 3;
            this.BtonSalones.Text = "Area Comun";
            this.BtonSalones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtonSalones.UseVisualStyleBackColor = false;
            this.BtonSalones.Click += new System.EventHandler(this.BtonSalones_Click);
            // 
            // BtonMaN
            // 
            this.BtonMaN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtonMaN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtonMaN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtonMaN.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonMaN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtonMaN.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.BtonMaN.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtonMaN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtonMaN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonMaN.Location = new System.Drawing.Point(0, 186);
            this.BtonMaN.Name = "BtonMaN";
            this.BtonMaN.Size = new System.Drawing.Size(309, 50);
            this.BtonMaN.TabIndex = 2;
            this.BtonMaN.Text = "Mantenimiento";
            this.BtonMaN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtonMaN.UseVisualStyleBackColor = false;
            this.BtonMaN.Click += new System.EventHandler(this.BtonMaN_Click);
            // 
            // BtonInquilios
            // 
            this.BtonInquilios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.BtonInquilios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtonInquilios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtonInquilios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonInquilios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtonInquilios.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.BtonInquilios.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtonInquilios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtonInquilios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonInquilios.Location = new System.Drawing.Point(0, 136);
            this.BtonInquilios.Name = "BtonInquilios";
            this.BtonInquilios.Size = new System.Drawing.Size(309, 50);
            this.BtonInquilios.TabIndex = 1;
            this.BtonInquilios.Text = "Inquilinos";
            this.BtonInquilios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtonInquilios.UseVisualStyleBackColor = false;
            this.BtonInquilios.Click += new System.EventHandler(this.BtonInquilios_Click);
            // 
            // FormMenu
            // 
            this.ClientSize = new System.Drawing.Size(1190, 613);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.PanelM);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.PanelM.ResumeLayout(false);
            this.SubMenuRep.ResumeLayout(false);
            this.PnlDNombre.ResumeLayout(false);
            this.PnlDNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private FontAwesome.Sharp.IconButton BtnSalones;
        private FontAwesome.Sharp.IconButton BtnMantenimiento;
        private FontAwesome.Sharp.IconButton BtnInquilinos;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel PanelM;
        private FontAwesome.Sharp.IconButton BtonSalones;
        private FontAwesome.Sharp.IconButton BtonMaN;
        private FontAwesome.Sharp.IconButton BtonInquilios;
        private System.Windows.Forms.Panel PnlDNombre;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel SubMenuRep;
        private FontAwesome.Sharp.IconButton BtnRepSalones;
        private FontAwesome.Sharp.IconButton BtnManRep;
        private FontAwesome.Sharp.IconButton BtnReInqui;
        private FontAwesome.Sharp.IconButton ReporteBtn;
        private FontAwesome.Sharp.IconButton SettingBtn;
        private FontAwesome.Sharp.IconButton BtonUsuarios;
        private System.Windows.Forms.Label labelNombreUser;
    }
}