using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLenguajeC.Vista;
using ProyectoLenguajeC.Vista.VistaReportes;

namespace ProyectoLenguajeC.Vista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

    
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

        }

        private void BtonInquilios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInquilinos());
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtonMaN_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMantenimiento());
        }

        private void BtonSalones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormSalones());
        }

        private void ReporteBtn_Click(object sender, EventArgs e)
        {
            if (SubMenuRep.Visible)
            {
                SubMenuRep.Visible = false;
            }
            else
            {
                SubMenuRep.Visible = true;
            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormSettings());   
        }

        private void BtonUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new UsuariosForm());
        }

        private void BtnReInqui_Click(object sender, EventArgs e)
        {
            SubMenuRep.Visible = false;
            AbrirFormEnPanel(new InquilinosRepForm());
        }

        private void BtnManRep_Click(object sender, EventArgs e)
        {
            SubMenuRep.Visible = false;
            AbrirFormEnPanel(new MantenimientosRepForm1());
        }

        private void BtnRepSalones_Click(object sender, EventArgs e)
        {
            SubMenuRep.Visible = false;
            AbrirFormEnPanel(new SalonesRepForm());
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void PanelM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
