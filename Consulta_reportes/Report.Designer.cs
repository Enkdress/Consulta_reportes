namespace Consulta_reportes
{
    partial class Report
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbCloseTime = new System.Windows.Forms.MaskedTextBox();
            this.txtIdTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initialDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.printTicket);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cmbCloseTime);
            this.pnlMain.Controls.Add(this.txtIdTicket);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.initialDatePicker);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(469, 820);
            this.pnlMain.TabIndex = 1;
            // 
            // cmbCloseTime
            // 
            this.cmbCloseTime.Location = new System.Drawing.Point(272, 315);
            this.cmbCloseTime.Mask = "00:00:00";
            this.cmbCloseTime.Name = "cmbCloseTime";
            this.cmbCloseTime.Size = new System.Drawing.Size(137, 38);
            this.cmbCloseTime.TabIndex = 2;
            this.cmbCloseTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbCloseTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdTicket
            // 
            this.txtIdTicket.Location = new System.Drawing.Point(272, 426);
            this.txtIdTicket.Name = "txtIdTicket";
            this.txtIdTicket.Size = new System.Drawing.Size(137, 38);
            this.txtIdTicket.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 64);
            this.label2.TabIndex = 20000;
            this.label2.Text = "Consecutivo del \r\ncomprobante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 64);
            this.label3.TabIndex = 2000;
            this.label3.Text = "Hora cierre \r\ndel comprobante\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 64);
            this.label1.TabIndex = 200;
            this.label1.Text = "Fecha del \r\ncomprobante";
            // 
            // initialDatePicker
            // 
            this.initialDatePicker.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.initialDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.initialDatePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.initialDatePicker.CustomFormat = "Dic 3 2019";
            this.initialDatePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initialDatePicker.Location = new System.Drawing.Point(272, 220);
            this.initialDatePicker.Name = "initialDatePicker";
            this.initialDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.initialDatePicker.Size = new System.Drawing.Size(137, 30);
            this.initialDatePicker.TabIndex = 1;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Report";
            this.Size = new System.Drawing.Size(469, 820);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker initialDatePicker;
        private System.Windows.Forms.TextBox txtIdTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cmbCloseTime;
    }
}
