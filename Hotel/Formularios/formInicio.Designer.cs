namespace Hotel
{
    partial class formInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            inicioSesion = new Panel();
            button2 = new Button();
            ErrorInicioSesion = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BotonIniciarLogin = new Button();
            textPasswordLogin = new TextBox();
            textUsuarioLogin = new TextBox();
            inicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // inicioSesion
            // 
            inicioSesion.BackColor = Color.White;
            inicioSesion.BackgroundImageLayout = ImageLayout.None;
            inicioSesion.BorderStyle = BorderStyle.FixedSingle;
            inicioSesion.Controls.Add(button2);
            inicioSesion.Controls.Add(ErrorInicioSesion);
            inicioSesion.Controls.Add(pictureBox1);
            inicioSesion.Controls.Add(label1);
            inicioSesion.Controls.Add(BotonIniciarLogin);
            inicioSesion.Controls.Add(textPasswordLogin);
            inicioSesion.Controls.Add(textUsuarioLogin);
            inicioSesion.Location = new Point(617, 349);
            inicioSesion.Name = "inicioSesion";
            inicioSesion.Size = new Size(646, 315);
            inicioSesion.TabIndex = 0;
            inicioSesion.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.descarga1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(607, 3);
            button2.Name = "button2";
            button2.Size = new Size(34, 35);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ErrorInicioSesion
            // 
            ErrorInicioSesion.AutoSize = true;
            ErrorInicioSesion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorInicioSesion.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorInicioSesion.Location = new Point(339, 261);
            ErrorInicioSesion.Name = "ErrorInicioSesion";
            ErrorInicioSesion.Size = new Size(232, 20);
            ErrorInicioSesion.TabIndex = 6;
            ErrorInicioSesion.Text = "Usuario O Contraseña Incorrecto\r\n";
            ErrorInicioSesion.Visible = false;
            ErrorInicioSesion.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 44);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 5;
            label1.Text = "Inicio Sesion";
            label1.Click += label1_Click_1;
            // 
            // BotonIniciarLogin
            // 
            BotonIniciarLogin.BackColor = Color.FromArgb(128, 255, 128);
            BotonIniciarLogin.Cursor = Cursors.Hand;
            BotonIniciarLogin.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            BotonIniciarLogin.FlatStyle = FlatStyle.Flat;
            BotonIniciarLogin.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonIniciarLogin.Location = new Point(394, 208);
            BotonIniciarLogin.Name = "BotonIniciarLogin";
            BotonIniciarLogin.Size = new Size(135, 31);
            BotonIniciarLogin.TabIndex = 4;
            BotonIniciarLogin.Text = "Iniciar";
            BotonIniciarLogin.UseVisualStyleBackColor = false;
            BotonIniciarLogin.Click += button1_Click;
            // 
            // textPasswordLogin
            // 
            textPasswordLogin.BackColor = SystemColors.Control;
            textPasswordLogin.Cursor = Cursors.IBeam;
            textPasswordLogin.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPasswordLogin.ForeColor = SystemColors.ControlDarkDark;
            textPasswordLogin.Location = new Point(394, 150);
            textPasswordLogin.Name = "textPasswordLogin";
            textPasswordLogin.PasswordChar = '*';
            textPasswordLogin.PlaceholderText = "Contraseña";
            textPasswordLogin.Size = new Size(134, 26);
            textPasswordLogin.TabIndex = 3;
            textPasswordLogin.TextChanged += textBox2_TextChanged;
            // 
            // textUsuarioLogin
            // 
            textUsuarioLogin.BackColor = SystemColors.Control;
            textUsuarioLogin.Cursor = Cursors.IBeam;
            textUsuarioLogin.Font = new Font("Century Schoolbook", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsuarioLogin.ForeColor = SystemColors.ControlDarkDark;
            textUsuarioLogin.Location = new Point(394, 105);
            textUsuarioLogin.Name = "textUsuarioLogin";
            textUsuarioLogin.PlaceholderText = "Usuario";
            textUsuarioLogin.Size = new Size(134, 26);
            textUsuarioLogin.TabIndex = 2;
            textUsuarioLogin.TextChanged += textBox1_TextChanged;
            // 
            // formInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1494, 729);
            Controls.Add(inicioSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            inicioSesion.ResumeLayout(false);
            inicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel inicioSesion;
        private PictureBox pictureBox1;
        private Button BotonIniciarLogin;
        private Label label1;
        private TextBox textUsuarioLogin;
        private TextBox textPasswordLogin;
        private Label ErrorInicioSesion;
        private Button button2;
    }
}
