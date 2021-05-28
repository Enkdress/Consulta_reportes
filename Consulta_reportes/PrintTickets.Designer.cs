namespace Consulta_reportes
{
    partial class PrintTickets
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInitConsec = new System.Windows.Forms.TextBox();
            this.txtFinConcec = new System.Windows.Forms.TextBox();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impresión De factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Consecutivo inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Consecutivo final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hora";
            // 
            // txtInitConsec
            // 
            this.txtInitConsec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitConsec.Location = new System.Drawing.Point(285, 208);
            this.txtInitConsec.Name = "txtInitConsec";
            this.txtInitConsec.Size = new System.Drawing.Size(114, 30);
            this.txtInitConsec.TabIndex = 2;
            // 
            // txtFinConcec
            // 
            this.txtFinConcec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinConcec.Location = new System.Drawing.Point(285, 272);
            this.txtFinConcec.Name = "txtFinConcec";
            this.txtFinConcec.Size = new System.Drawing.Size(114, 30);
            this.txtFinConcec.TabIndex = 3;
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.Location = new System.Drawing.Point(331, 352);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(68, 30);
            this.txtDoc.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(132, 349);
            this.txtTime.Mask = "00/00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(79, 30);
            this.txtTime.TabIndex = 4;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFinConcec);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtInitConsec);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 820);
            this.panel1.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(64, 436);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(335, 53);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.printTicket);
            // 
            // PrintTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrintTickets";
            this.Size = new System.Drawing.Size(469, 820);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInitConsec;
        private System.Windows.Forms.TextBox txtFinConcec;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.MaskedTextBox txtTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
    }
}
