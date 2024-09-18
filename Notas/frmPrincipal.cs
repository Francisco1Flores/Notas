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
    public partial class frmPrincipal : Form
    {        
        Nota NotaSeleccionada { get; set; }

        int CantidadNotas = 0;    

        public frmPrincipal()
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
            txtTextoNota.Text = string.Empty;
            txtTituloNota.Text = string.Empty;
            NotaSeleccionada = null;
            BorrarPantallaNota();            
            VerPanelNotas(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nota NuevaNota = new Nota(txtTituloNota.Text, txtTextoNota.Text, this);            

            pnlContenedorNotas.Controls.Add(NuevaNota);

            NuevaNota.Visible = true;
            NuevaNota.Enabled = true;            

            BorrarPantallaNota();
            VerPanelNotas(true);

            CantidadNotas++;
            if (CantidadNotas > 8 && pnlContenedorNotas.AutoScroll == false)
            {
                pnlContenedorNotas.AutoScroll = true;                                
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (NotaSeleccionada == null)
            {
                return;
            }
            NotaSeleccionada.lblTitulo.Text = txtTituloNota.Text;
            NotaSeleccionada.lblTexto.Text = txtTextoNota.Text;
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

            pnlContenedorNotas.Controls.Remove(NotaSeleccionada);
            CantidadNotas--;
            NotaSeleccionada = null;
            BorrarPantallaNota();
            VerPanelNotas(true);

            if (pnlContenedorNotas.AutoScroll == true && CantidadNotas <= 8)
            {
                pnlContenedorNotas.AutoScroll = false;                                
            }
        }

        public void AbrirNotaSeleccionada(Nota NotaSeleccionada)
        {
            VerPanelNotas(false);
            verPanelModificarNota(NotaSeleccionada, true);
        }

        private void VerPanelNotas(bool opcion)
        {
            btnNuevaNota.Enabled = opcion;
            btnNuevaNota.Visible = opcion;            

            pnlContenedorNotas.Enabled = opcion;
            pnlContenedorNotas.Visible = opcion;
        }

        private void VerPanelNuevaNota()
        {
            lblTitulo.Visible = true;
            lblTitulo.Enabled = true;

            lblTexto.Visible = true;
            lblTexto.Enabled = true;

            txtTituloNota.Visible = true;
            txtTituloNota.Enabled = true;
            txtTituloNota.Clear();

            txtTextoNota.Visible = true;
            txtTextoNota.Enabled = true;
            txtTextoNota.Clear();
            
            btnGuardar.Visible = true;
            btnGuardar.Enabled = true;
            
            btnCancelar.Left = txtTextoNota.Left + txtTextoNota.Width - btnCancelar.Width;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;            
        }

        public void verPanelModificarNota(Nota nota, bool opcion)
        {
            NotaSeleccionada = nota;

            lblTitulo.Visible = true;
            lblTitulo.Enabled = true;

            lblTexto.Visible = true;
            lblTexto.Enabled = true;

            txtTituloNota.Text = nota.lblTitulo.Text;
            txtTituloNota.Visible = true;
            txtTituloNota.Enabled = true;

            txtTextoNota.Text = nota.lblTexto.Text;
            txtTextoNota.Visible = true;            
            txtTextoNota.Enabled = true;
                                  
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

            txtTituloNota.Visible = false;
            txtTituloNota.Enabled = false;
            
            txtTextoNota.Visible = false;
            txtTextoNota.Enabled = false;

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
