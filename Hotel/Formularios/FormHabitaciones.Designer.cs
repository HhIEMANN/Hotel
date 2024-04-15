namespace Hotel.Formularios
{
    partial class FormHabitaciones
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
            labelhabs = new Label();
            SuspendLayout();
            // 
            // labelhabs
            // 
            labelhabs.AutoSize = true;
            labelhabs.Location = new Point(214, 153);
            labelhabs.Name = "labelhabs";
            labelhabs.Size = new Size(149, 15);
            labelhabs.TabIndex = 0;
            labelhabs.Text = "formulario de habitaciones";
            // 
            // FormHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelhabs);
            Name = "FormHabitaciones";
            Text = "FormHabitaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelhabs;
    }
}