namespace Notas
{
    partial class Notas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevaNota = new System.Windows.Forms.Button();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.txtNuevoTitulo = new System.Windows.Forms.TextBox();
            this.txtNuevoTexto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ContenedorNotas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevaNota
            // 
            this.btnNuevaNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaNota.Location = new System.Drawing.Point(310, 19);
            this.btnNuevaNota.Name = "btnNuevaNota";
            this.btnNuevaNota.Size = new System.Drawing.Size(150, 23);
            this.btnNuevaNota.TabIndex = 0;
            this.btnNuevaNota.Text = "Nueva Nota";
            this.btnNuevaNota.UseVisualStyleBackColor = true;
            this.btnNuevaNota.Click += new System.EventHandler(this.btnNuevaNota_Click);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.BackColor = System.Drawing.Color.Red;
            this.btnEliminarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarNota.Enabled = false;
            this.btnEliminarNota.Location = new System.Drawing.Point(428, 314);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarNota.TabIndex = 1;
            this.btnEliminarNota.Text = "Eliminar";
            this.btnEliminarNota.UseVisualStyleBackColor = false;
            this.btnEliminarNota.Visible = false;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // txtNuevoTitulo
            // 
            this.txtNuevoTitulo.Enabled = false;
            this.txtNuevoTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNuevoTitulo.Location = new System.Drawing.Point(283, 86);
            this.txtNuevoTitulo.Name = "txtNuevoTitulo";
            this.txtNuevoTitulo.Size = new System.Drawing.Size(208, 20);
            this.txtNuevoTitulo.TabIndex = 3;
            this.txtNuevoTitulo.Visible = false;
            // 
            // txtNuevoTexto
            // 
            this.txtNuevoTexto.Enabled = false;
            this.txtNuevoTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNuevoTexto.Location = new System.Drawing.Point(283, 125);
            this.txtNuevoTexto.Multiline = true;
            this.txtNuevoTexto.Name = "txtNuevoTexto";
            this.txtNuevoTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNuevoTexto.Size = new System.Drawing.Size(208, 183);
            this.txtNuevoTexto.TabIndex = 4;
            this.txtNuevoTexto.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(282, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(347, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ContenedorNotas
            // 
            this.ContenedorNotas.Location = new System.Drawing.Point(12, 48);
            this.ContenedorNotas.Name = "ContenedorNotas";
            this.ContenedorNotas.Size = new System.Drawing.Size(776, 390);
            this.ContenedorNotas.TabIndex = 0;
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarNota.Enabled = false;
            this.btnModificarNota.Location = new System.Drawing.Point(266, 314);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(75, 23);
            this.btnModificarNota.TabIndex = 10;
            this.btnModificarNota.Text = "Guardar";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Visible = false;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Location = new System.Drawing.Point(279, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.Visible = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Enabled = false;
            this.lblTexto.Location = new System.Drawing.Point(280, 109);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 12;
            this.lblTexto.Text = "Texto";
            this.lblTexto.Visible = false;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.Teal;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(37, 19);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(172, 23);
            this.lblTituloPrincipal.TabIndex = 13;
            this.lblTituloPrincipal.Text = "Guarda tus Notas";
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.ContenedorNotas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNuevoTexto);
            this.Controls.Add(this.btnEliminarNota);
            this.Controls.Add(this.btnNuevaNota);
            this.Controls.Add(this.txtNuevoTitulo);
            this.Name = "Notas";
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaNota;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.TextBox txtNuevoTitulo;
        private System.Windows.Forms.TextBox txtNuevoTexto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel ContenedorNotas;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTituloPrincipal;
    }
}

