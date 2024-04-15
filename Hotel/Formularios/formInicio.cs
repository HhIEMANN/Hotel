using Hotel.Formularios;

namespace Hotel
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuarioLogin.Text == "Hola" && textPasswordLogin.Text == "123")
            {
                ErrorInicioSesion.Visible = false;
                this.Hide();

                // Luego, abrimos el formulario principal (MainMenuForm)
                FormMenu mainMenu = new FormMenu();
                mainMenu.ShowDialog();
            }
            else
            {
                ErrorInicioSesion.Visible = true;
                textPasswordLogin.Clear();

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
