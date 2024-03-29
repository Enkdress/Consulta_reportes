﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Consulta_reportes
{

    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void openModule(object sender, EventArgs e)
        {
            Button btnModule = (Button)sender;
            pnlContainer.SuspendLayout();
            switch (btnModule.Name)//EN TEORIA ESTE SWITCH MUESTRA EL CONTENIDO DE CADA BOTOS/FORMULARIO
            {
                case "btnImport":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    ImportarPlano importar = new ImportarPlano();
                    pnlContainer.Controls.Add(importar);
                    importar.Width = pnlContainer.Width;
                    importar.Height = pnlContainer.Height;
                    break;

                case "btnProjetion":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    GenProyeccion projection = new GenProyeccion();
                    pnlContainer.Controls.Add(projection);
                    projection.Width = pnlContainer.Width;
                    projection.Height = pnlContainer.Height;
                    break;

                case "btnExport":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    ExportarPlano exportar = new ExportarPlano();
                    pnlContainer.Controls.Add(exportar);
                    exportar.Width = pnlContainer.Width;
                    exportar.Height = pnlContainer.Height;
                    break;

                case "btnReports":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    Report report = new Report();
                    pnlContainer.Controls.Add(report);
                    report.Width = pnlContainer.Width;
                    report.Height = pnlContainer.Height;
                    break;

                case "btnTickets":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    PrintTickets tickets = new PrintTickets();
                    pnlContainer.Controls.Add(tickets);
                    tickets.Width = pnlContainer.Width;
                    tickets.Height = pnlContainer.Height;
                    break;

                case "btnParams":

                    setActiveButtonFormColor(btnModule);

                    pnlContainer.Controls.Clear();
                    UserConfig config = new UserConfig();
                    pnlContainer.Controls.Add(config);
                    config.Width = pnlContainer.Width;
                    config.Height = pnlContainer.Height;
                    break;
            }

            pnlContainer.ResumeLayout(true);
        }



        #region Cosasdelaventana

        private int mouseLocationX;
        private int mouseLocationY;


        private void setActiveButtonFormColor(Button button)
        {

            try
            {
                //GENERICS
                pnlBarMenu.GetControls<Button>().ForEach(btn => {
                    if (btn.Text != button.Text)
                    {
                        btn.BackColor = Color.FromArgb(48, 67, 96);//NORMAL COLOR
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(26, 145, 34);//COLOR ON ACTIVE
                    }
                });//LAMBDAS
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

     
        private void appClose_Click(object sender, EventArgs e)
        {
            DialogResult confirmClose = MessageBox.Show("Seguro que desea salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (confirmClose)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }

        private void appMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region MovimientoDeLaVentana
        private void mouseDown(object sender, MouseEventArgs args)//CUANDO MANTENGA EL CLICK PRESIONADO SE EJECUTA EL MOVIMIENTO
        {
            pnlTopBar.MouseMove += new MouseEventHandler(windowMovement);
            mouseLocationX = args.X;//POSICION INICIAL DEL MOUSE EN X
            mouseLocationY = args.Y;//POSICION INICIAL DEL MOUSE EN Y
        }

        private void windowMovement(object sender, MouseEventArgs args)
        {
            var oldLocation = this.Location;
            //args.X - mouseLocationX = ESTO ES LA CANTIDAD DE UNIDADES QUE SE MOVIO
            this.Location = new Point((oldLocation.X + (args.X - mouseLocationX)), (oldLocation.Y + (args.Y - mouseLocationY)));
        }

        private void mouseUp(object sender, MouseEventArgs args)
        {
            pnlTopBar.MouseMove -= new MouseEventHandler(windowMovement);
        }
        #endregion MovimientoDeLaVentana

        #endregion Cosasdelaventana
    }



    //CLASE PARA RECORRER TODOS LOS BOTONES DE PANEL LATERAL
    public static class Generic
    {
        public static List<T> GetControls<T>(this Control container) where T : Control
        {
            List<T> controls = new List<T>();
            foreach (Control c in container.Controls)
            {
                if (c is T)
                    controls.Add((T)c);

                controls.AddRange(GetControls<T>(c));
            }
            return controls;
        }

    }
}
