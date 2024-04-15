using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            GenerarFormulario(new FormReservas());

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GenerarFormulario(new FormEditar());

        }
        public void GenerarFormulario(Form formulario)
        {
            // Asegúrate de que el formulario no esté ya abierto , si el panel contenedor ya tiene el formulario contenido entonces no se volvera a abrir
            if (!PanelMenu.Controls.Contains(formulario))
            {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelMenu.Controls.Add(formulario);
                PanelMenu.Tag = formulario;
                formulario.Show();//se nuestra el formulario
            }
            formulario.BringToFront();//el formulario estara delante de todo
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            GenerarFormulario(new FormVentas());
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            GenerarFormulario(new FormHabitaciones());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            GenerarFormulario(new FormInformes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


