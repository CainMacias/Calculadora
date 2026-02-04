namespace Calculadora.Formularios
{
    partial class Registro
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
            Registros = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Registros.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // Registros
            // 
            Registros.Controls.Add(tabPage1);
            Registros.Controls.Add(tabPage2);
            Registros.Location = new Point(0, 3);
            Registros.Name = "Registros";
            Registros.SelectedIndex = 0;
            Registros.Size = new Size(800, 465);
            Registros.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 432);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 432);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 27);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 110);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(44, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(224, 27);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 228);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 4;
            label3.Text = "fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 265);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(Registros);
            Name = "Registro";
            Text = "Registro";
            Registros.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Registros;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private DateTimePicker dateTimePicker1;
    }
}