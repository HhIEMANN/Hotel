
namespace Hotel.Formularios
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            PanelMenu = new Panel();
            PanelBotones = new Panel();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnInformes = new Button();
            pictureBox1 = new PictureBox();
            btnHabitaciones = new Button();
            btnVentas = new Button();
            btnEditar = new Button();
            btnReservar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.Location = new Point(0, 195);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(939, 392);
            PanelMenu.TabIndex = 0;
            PanelMenu.Paint += PanelMenu_Paint;
            // 
            // PanelBotones
            // 
            PanelBotones.BackColor = SystemColors.ActiveCaption;
            PanelBotones.BackgroundImage = (Image)resources.GetObject("PanelBotones.BackgroundImage");
            PanelBotones.Controls.Add(button1);
            PanelBotones.Controls.Add(label7);
            PanelBotones.Controls.Add(label6);
            PanelBotones.Controls.Add(label5);
            PanelBotones.Controls.Add(btnInformes);
            PanelBotones.Controls.Add(pictureBox1);
            PanelBotones.Controls.Add(btnHabitaciones);
            PanelBotones.Controls.Add(btnVentas);
            PanelBotones.Controls.Add(btnEditar);
            PanelBotones.Controls.Add(btnReservar);
            PanelBotones.Controls.Add(label4);
            PanelBotones.Controls.Add(label3);
            PanelBotones.Controls.Add(label2);
            PanelBotones.Controls.Add(label1);
            PanelBotones.Location = new Point(0, 0);
            PanelBotones.Name = "PanelBotones";
            PanelBotones.Size = new Size(939, 197);
            PanelBotones.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(840, 12);
            button1.Name = "button1";
            button1.Size = new Size(78, 30);
            button1.TabIndex = 25;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.Location = new Point(591, 22);
            label7.Name = "label7";
            label7.Size = new Size(61, 16);
            label7.TabIndex = 24;
            label7.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(456, 21);
            label6.Name = "label6";
            label6.Size = new Size(114, 16);
            label6.TabIndex = 23;
            label6.Text = "Sesion Iniciada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(787, 154);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 22;
            label5.Text = "Informes";
            // 
            // btnInformes
            // 
            btnInformes.BackColor = SystemColors.ButtonHighlight;
            btnInformes.Cursor = Cursors.Hand;
            btnInformes.Image = (Image)resources.GetObject("btnInformes.Image");
            btnInformes.Location = new Point(772, 71);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(97, 80);
            btnInformes.TabIndex = 21;
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += btnInformes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.BackColor = SystemColors.ButtonHighlight;
            btnHabitaciones.Cursor = Cursors.Hand;
            btnHabitaciones.Image = (Image)resources.GetObject("btnHabitaciones.Image");
            btnHabitaciones.Location = new Point(641, 71);
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(97, 80);
            btnHabitaciones.TabIndex = 20;
            btnHabitaciones.UseVisualStyleBackColor = false;
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.ButtonHighlight;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(505, 71);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(97, 80);
            btnVentas.TabIndex = 19;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ButtonHighlight;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(378, 71);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 80);
            btnEditar.TabIndex = 18;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = SystemColors.ButtonHighlight;
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.Image = (Image)resources.GetObject("btnReservar.Image");
            btnReservar.Location = new Point(249, 71);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(93, 80);
            btnReservar.TabIndex = 17;
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(641, 154);
            label4.Name = "label4";
            label4.Size = new Size(119, 24);
            label4.TabIndex = 16;
            label4.Text = "Habitaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(522, 154);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 13;
            label3.Text = "Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(392, 152);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 12;
            label2.Text = "Editar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(254, 152);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 0;
            label1.Text = "Reservas";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 586);
            Controls.Add(PanelBotones);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMenu";
            Text = "FormMenu";
            PanelBotones.ResumeLayout(false);
            PanelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelBotones;
        private Label label1;
        private Button btnReservar;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnHabitaciones;
        private Button btnVentas;
        private Button btnEditar;
        private Label label5;
        private Button btnInformes;
        private Label label7;
        private Label label6;
        private Button button1;
    }
}