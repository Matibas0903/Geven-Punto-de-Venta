namespace ProyectoMerceria
{
    partial class FormBorrarProductos
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
            this.cBoxBackUp = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.tBoxDireccionBackUp = new System.Windows.Forms.TextBox();
            this.lblDireccionBackUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBoxBackUp
            // 
            this.cBoxBackUp.AutoSize = true;
            this.cBoxBackUp.Checked = true;
            this.cBoxBackUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxBackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxBackUp.Location = new System.Drawing.Point(30, 193);
            this.cBoxBackUp.Name = "cBoxBackUp";
            this.cBoxBackUp.Size = new System.Drawing.Size(290, 21);
            this.cBoxBackUp.TabIndex = 0;
            this.cBoxBackUp.Text = "Guardar copia de seguridad (recomendado)";
            this.cBoxBackUp.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 24);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(12, 69);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(415, 23);
            this.lblAdvertencia.TabIndex = 3;
            this.lblAdvertencia.Text = "Esta accion borrara todos los productos existentes!";
            this.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(302, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Continuar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(269, 152);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(72, 25);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // tBoxDireccionBackUp
            // 
            this.tBoxDireccionBackUp.Location = new System.Drawing.Point(30, 152);
            this.tBoxDireccionBackUp.Name = "tBoxDireccionBackUp";
            this.tBoxDireccionBackUp.ReadOnly = true;
            this.tBoxDireccionBackUp.Size = new System.Drawing.Size(233, 25);
            this.tBoxDireccionBackUp.TabIndex = 6;
            // 
            // lblDireccionBackUp
            // 
            this.lblDireccionBackUp.AutoSize = true;
            this.lblDireccionBackUp.Location = new System.Drawing.Point(27, 132);
            this.lblDireccionBackUp.Name = "lblDireccionBackUp";
            this.lblDireccionBackUp.Size = new System.Drawing.Size(183, 17);
            this.lblDireccionBackUp.TabIndex = 7;
            this.lblDireccionBackUp.Text = "Ubicacion destino del backup:";
            // 
            // FormBorrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(435, 369);
            this.ControlBox = false;
            this.Controls.Add(this.lblDireccionBackUp);
            this.Controls.Add(this.tBoxDireccionBackUp);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cBoxBackUp);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 387);
            this.Name = "FormBorrarProductos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxBackUp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox tBoxDireccionBackUp;
        private System.Windows.Forms.Label lblDireccionBackUp;
    }
}