using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Notas : Form
    {        
        Nota NotaSeleccionada { get; set; }

        int CantidadNotas = 0;    

        public Notas()
        {
            NotaSeleccionada = null;
            InitializeComponent();
        }

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            VerPanelNotas(false);
            VerPanelNuevaNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNuevoTexto.Text = string.Empty;
            txtNuevoTitulo.Text = string.Empty;
            NotaSeleccionada = null;
            BorrarPantallaNota();            
            VerPanelNotas(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nota NuevaNota = new Nota(txtNuevoTitulo.Text, txtNuevoTexto.Text, this);

            ContenedorNotas.SuspendLayout();

            ContenedorNotas.Controls.Add(NuevaNota);

            NuevaNota.Visible = true;
            NuevaNota.Enabled = true;

            ContenedorNotas.ResumeLayout(false);

            BorrarPantallaNota();
            VerPanelNotas(true);

            CantidadNotas++;
            if (CantidadNotas > 8 && ContenedorNotas.AutoScroll == false)
            {
                ContenedorNotas.AutoScroll = true;
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (NotaSeleccionada == null)
            {
                return;
            }
            NotaSeleccionada.lblTitulo.Text = txtNuevoTitulo.Text;
            NotaSeleccionada.lblTexto.Text = txtNuevoTexto.Text;
            NotaSeleccionada.lblFechaHora.Text = "Mod " + DateTime.Now.ToString();

            NotaSeleccionada = null;

            BorrarPantallaNota();
            VerPanelNotas(true);
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            if (NotaSeleccionada == null)
            {
                return;
            }

            CantidadNotas--;

            ContenedorNotas.Controls.Remove(NotaSeleccionada);
            NotaSeleccionada = null;
            BorrarPantallaNota();
            VerPanelNotas(true);

            if (ContenedorNotas.AutoScroll == true && CantidadNotas <= 8)
            {
                ContenedorNotas.AutoScroll = false;
            }
        }

        private void VerPanelNotas(bool opcion)
        {
            btnNuevaNota.Enabled = opcion;
            btnNuevaNota.Visible = opcion;            

            ContenedorNotas.Enabled = opcion;
            ContenedorNotas.Visible = opcion;
        }

        private void VerPanelNuevaNota()
        {
            lblTitulo.Visible = true;
            lblTitulo.Enabled = true;

            lblTexto.Visible = true;
            lblTexto.Enabled = true;

            txtNuevoTitulo.Visible = true;
            txtNuevoTitulo.Enabled = true;
            txtNuevoTitulo.Text = "";           

            txtNuevoTexto.Visible = true;
            txtNuevoTexto.Enabled = true;
            txtNuevoTexto.Text = "";
            
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            
            btnCancelar.Left = txtNuevoTexto.Left + txtNuevoTexto.Width - btnCancelar.Width;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;            
        }

        public void AbrirNotaSeleccionada(Nota NotaSeleccionada)
        {
            VerPanelNotas(false);
            verPanelModificarNota(NotaSeleccionada, true);
        }

        public void verPanelModificarNota(Nota nota, bool opcion)
        {
            NotaSeleccionada = nota;

            lblTitulo.Visible = true;
            lblTitulo.Enabled = true;

            lblTexto.Visible = true;
            lblTexto.Enabled = true;

            txtNuevoTitulo.Text = nota.lblTitulo.Text;
            txtNuevoTitulo.Visible = true;
            txtNuevoTitulo.Enabled = true;

            txtNuevoTexto.Text = nota.lblTexto.Text;
            txtNuevoTexto.Visible = true;            
            txtNuevoTexto.Enabled = true;
                                  
            this.btnModificarNota.Enabled = true;
            this.btnModificarNota.Visible = true;

            this.btnCancelar.Left = this.btnModificarNota.Left + this.btnModificarNota.Width + 10;
            this.btnCancelar.Visible = true;
            this.btnCancelar.Enabled = true;

            this.btnEliminarNota.Left = this.btnCancelar.Left + 75 + 10;
            this.btnEliminarNota.Visible = true;
            this.btnEliminarNota.Enabled = true;
        }

        public void BorrarPantallaNota()
        {
            lblTitulo.Visible = false;
            lblTitulo.Enabled = false;

            lblTexto.Visible = false;
            lblTexto.Enabled = false;

            txtNuevoTitulo.Visible = false;
            txtNuevoTitulo.Enabled = false;
            
            txtNuevoTexto.Visible = false;
            txtNuevoTexto.Enabled = false;

            btnGuardar.Visible = false;
            btnGuardar.Enabled = false;

            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;

            btnEliminarNota.Visible = false;
            btnEliminarNota.Enabled = false;

            btnModificarNota.Visible = false;
            btnModificarNota.Enabled = false;

        }
    }
}
