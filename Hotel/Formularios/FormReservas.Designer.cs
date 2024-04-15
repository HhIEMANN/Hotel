namespace Hotel.Formularios
{
    partial class FormReservas
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
            label1 = new Label();
            txtNombreCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 84);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(200, 85);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(174, 23);
            txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 2;
            label2.Text = "Datos Cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 147);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefono Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 213);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 5;
            label4.Text = "Telefono Cliente";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Name = "FormReservas";
            Text = "Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCliente;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
    }
}