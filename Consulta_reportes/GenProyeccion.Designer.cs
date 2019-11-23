namespace Consulta_reportes
{
    partial class GenProyeccion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjection = new System.Windows.Forms.TextBox();
            this.btnSendProjection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyección";
            // 
            // txtProjection
            // 
            this.txtProjection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjection.Location = new System.Drawing.Point(181, 328);
            this.txtProjection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtProjection.Name = "txtProjection";
            this.txtProjection.Size = new System.Drawing.Size(244, 38);
            this.txtProjection.TabIndex = 1;
            // 
            // btnSendProjection
            // 
            this.btnSendProjection.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSendProjection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendProjection.FlatAppearance.BorderSize = 0;
            this.btnSendProjection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(186)))), ((int)(((byte)(34)))));
            this.btnSendProjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendProjection.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btnSendProjection.ForeColor = System.Drawing.Color.White;
            this.btnSendProjection.Location = new System.Drawing.Point(46, 411);
            this.btnSendProjection.Name = "btnSendProjection";
            this.btnSendProjection.Size = new System.Drawing.Size(379, 64);
            this.btnSendProjection.TabIndex = 2;
            this.btnSendProjection.Text = "Generar";
            this.btnSendProjection.UseVisualStyleBackColor = false;
            this.btnSendProjection.Click += new System.EventHandler(this.btnSendProjection_Click);
            // 
            // GenProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSendProjection);
            this.Controls.Add(this.txtProjection);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GenProyeccion";
            this.Size = new System.Drawing.Size(469, 820);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjection;
        private System.Windows.Forms.Button btnSendProjection;
    }
}
