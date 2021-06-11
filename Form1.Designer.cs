
namespace programaBeca
{
    partial class frmNotas
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
            this.gpbIngresoNota = new System.Windows.Forms.GroupBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtIngresoNota = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.txtBeca = new System.Windows.Forms.TextBox();
            this.lblBeca = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gpbIngresoNota.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIngresoNota
            // 
            this.gpbIngresoNota.Controls.Add(this.btnLimpiar);
            this.gpbIngresoNota.Controls.Add(this.btnIngresar);
            this.gpbIngresoNota.Controls.Add(this.txtIngresoNota);
            this.gpbIngresoNota.Controls.Add(this.lblNota);
            this.gpbIngresoNota.Location = new System.Drawing.Point(12, 12);
            this.gpbIngresoNota.Name = "gpbIngresoNota";
            this.gpbIngresoNota.Size = new System.Drawing.Size(247, 100);
            this.gpbIngresoNota.TabIndex = 0;
            this.gpbIngresoNota.TabStop = false;
            this.gpbIngresoNota.Text = "Ingrese la nota a revisar";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(7, 42);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(36, 13);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Nota: ";
            // 
            // txtIngresoNota
            // 
            this.txtIngresoNota.Location = new System.Drawing.Point(49, 39);
            this.txtIngresoNota.Name = "txtIngresoNota";
            this.txtIngresoNota.Size = new System.Drawing.Size(56, 20);
            this.txtIngresoNota.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(143, 32);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(143, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.txtBeca);
            this.gpbResultado.Controls.Add(this.lblBeca);
            this.gpbResultado.Controls.Add(this.txtCondicion);
            this.gpbResultado.Controls.Add(this.lblEstado);
            this.gpbResultado.Location = new System.Drawing.Point(14, 118);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(247, 114);
            this.gpbResultado.TabIndex = 4;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // txtBeca
            // 
            this.txtBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeca.Location = new System.Drawing.Point(111, 78);
            this.txtBeca.Name = "txtBeca";
            this.txtBeca.ReadOnly = true;
            this.txtBeca.Size = new System.Drawing.Size(107, 20);
            this.txtBeca.TabIndex = 3;
            this.txtBeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBeca
            // 
            this.lblBeca.AutoSize = true;
            this.lblBeca.Location = new System.Drawing.Point(6, 81);
            this.lblBeca.Name = "lblBeca";
            this.lblBeca.Size = new System.Drawing.Size(103, 13);
            this.lblBeca.TabIndex = 2;
            this.lblBeca.Text = "Porcentaje de beca:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicion.Location = new System.Drawing.Point(111, 39);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.ReadOnly = true;
            this.txtCondicion.Size = new System.Drawing.Size(107, 20);
            this.txtCondicion.TabIndex = 1;
            this.txtCondicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Condicion: ";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 248);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbIngresoNota);
            this.Name = "frmNotas";
            this.Text = "Revision de beca";
            this.gpbIngresoNota.ResumeLayout(false);
            this.gpbIngresoNota.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIngresoNota;
        private System.Windows.Forms.TextBox txtIngresoNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.TextBox txtBeca;
        private System.Windows.Forms.Label lblBeca;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label lblEstado;
    }
}

