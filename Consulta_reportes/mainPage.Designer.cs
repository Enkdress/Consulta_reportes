namespace Consulta_reportes
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pnlBarMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnProjetion = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlBarMenu.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarMenu
            // 
            this.pnlBarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.pnlBarMenu.Controls.Add(this.label1);
            this.pnlBarMenu.Controls.Add(this.btnParams);
            this.pnlBarMenu.Controls.Add(this.btnReports);
            this.pnlBarMenu.Controls.Add(this.btnExport);
            this.pnlBarMenu.Controls.Add(this.btnProjetion);
            this.pnlBarMenu.Controls.Add(this.btnImport);
            this.pnlBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlBarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBarMenu.Name = "pnlBarMenu";
            this.pnlBarMenu.Size = new System.Drawing.Size(188, 820);
            this.pnlBarMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 799);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "v0.1";
            // 
            // btnParams
            // 
            this.btnParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnParams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParams.FlatAppearance.BorderSize = 0;
            this.btnParams.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParams.ForeColor = System.Drawing.Color.White;
            this.btnParams.Location = new System.Drawing.Point(0, 332);
            this.btnParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(188, 83);
            this.btnParams.TabIndex = 5;
            this.btnParams.Text = "Opciones";
            this.btnParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParams.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 249);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(188, 83);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Informes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(0, 166);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(188, 83);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Exportar plano";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.openModule);
            // 
            // btnProjetion
            // 
            this.btnProjetion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnProjetion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjetion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjetion.FlatAppearance.BorderSize = 0;
            this.btnProjetion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProjetion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjetion.ForeColor = System.Drawing.Color.White;
            this.btnProjetion.Location = new System.Drawing.Point(0, 83);
            this.btnProjetion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjetion.Name = "btnProjetion";
            this.btnProjetion.Size = new System.Drawing.Size(188, 83);
            this.btnProjetion.TabIndex = 3;
            this.btnProjetion.Text = "Generar proyección";
            this.btnProjetion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjetion.UseVisualStyleBackColor = false;
            this.btnProjetion.Click += new System.EventHandler(this.openModule);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(0, 0);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(188, 83);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Importar plano";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.openModule);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(188, 38);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(469, 820);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(657, 38);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(583, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.appMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(617, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(657, 858);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlBarMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.pnlBarMenu.ResumeLayout(false);
            this.pnlBarMenu.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarMenu;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProjetion;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

