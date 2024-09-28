using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Notas
{
    public partial class frmPrincipal : Form
    {
        private Nota NotaSeleccionada;               

        int CantidadNotas = 0; 

        public frmPrincipal()
        {                        
            InitializeComponent();

            NotaSeleccionada = null;                        
            
            this.Resize += ReacomodarElementos;
        }        

        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            VerPanelNotas(false);
            VerPanelNuevaNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTextoNota.Clear();
            txtTituloNota.Clear();
            NotaSeleccionada = null;
            BorrarPantallaNota();
            VerPanelNotas(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nota NuevaNota = new Nota(txtTituloNota.Text, txtTextoNota.Text, this);

            pnlContenedorNotas.Controls.Add(NuevaNota);            

            BorrarPantallaNota();
            VerPanelNotas(true);

            CantidadNotas++;
            if (CantidadNotas > 8
                &&
                pnlContenedorNotas.AutoScroll == false
                &&
                this.WindowState == FormWindowState.Normal)
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

            NotaSeleccionada.Actualizar(txtTituloNota.Text, txtTextoNota.Text);
            
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

            if (pnlContenedorNotas.AutoScroll == true
                &&
                CantidadNotas <= 8
                &&
                this.WindowState == FormWindowState.Normal)
            {
                pnlContenedorNotas.AutoScroll = false;                                
            }
        }       

        private void ReacomodarElementos(object sender, EventArgs e)
        {           
            this.btnNuevaNota.Left = (this.ClientSize.Width / 2) - (this.btnNuevaNota.Size.Width / 2);

            this.pnlContenedorNotas.Width = this.ClientSize.Width - 24;
            this.pnlContenedorNotas.Height = this.ClientSize.Height - 60;            

            this.txtTituloNota.Left = (this.ClientSize.Width / 2) - (this.txtTituloNota.Size.Width / 2);
            this.txtTextoNota.Left = (this.ClientSize.Width / 2) - (this.txtTituloNota.Size.Width / 2);

            this.lblTitulo.Left = this.txtTituloNota.Left;
            this.lblTexto.Left = this.txtTextoNota.Left;

            this.btnGuardar.Left = this.txtTextoNota.Left;
            this.btnModificarNota.Left = this.txtTextoNota.Left;
            this.btnCancelar.Left = this.txtTextoNota.Left + this.txtTextoNota.Width - this.btnCancelar.Width;
            this.btnEliminarNota.Left = this.btnGuardar.Left + this.btnGuardar.Width + 10;
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
                                  
            btnModificarNota.Enabled = true;
            btnModificarNota.Visible = true;

            btnCancelar.Left = btnModificarNota.Left + btnModificarNota.Width + 10;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;

            btnEliminarNota.Left = btnCancelar.Left + 75 + 10;
            btnEliminarNota.Visible = true;
            btnEliminarNota.Enabled = true;
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
