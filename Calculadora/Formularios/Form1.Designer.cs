namespace Calculadora
{
    partial class Calculadora
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
            textVarA = new TextBox();
            variableA = new Label();
            label1 = new Label();
            textVarB = new TextBox();
            BtCalcular = new Button();
            label2 = new Label();
            textResultado = new TextBox();
            BtReset = new Button();
            Operaciones = new GroupBox();
            Division = new RadioButton();
            Multiplicacion = new RadioButton();
            Resta = new RadioButton();
            Suma = new RadioButton();
            Operaciones.SuspendLayout();
            SuspendLayout();
            // 
            // textVarA
            // 
            textVarA.Location = new Point(78, 51);
            textVarA.Name = "textVarA";
            textVarA.Size = new Size(278, 27);
            textVarA.TabIndex = 0;
            textVarA.TextChanged += textBox1_TextChanged;
            // 
            // variableA
            // 
            variableA.AutoSize = true;
            variableA.Location = new Point(78, 28);
            variableA.Name = "variableA";
            variableA.Size = new Size(76, 20);
            variableA.TabIndex = 1;
            variableA.Text = "variable A";
            variableA.Click += variableA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 102);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "variable B";
            // 
            // textVarB
            // 
            textVarB.Location = new Point(78, 125);
            textVarB.Name = "textVarB";
            textVarB.Size = new Size(278, 27);
            textVarB.TabIndex = 2;
            // 
            // BtCalcular
            // 
            BtCalcular.Location = new Point(700, 49);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(94, 29);
            BtCalcular.TabIndex = 4;
            BtCalcular.Text = "CALCULAR";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += TnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 210);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Resultado";
            // 
            // textResultado
            // 
            textResultado.Location = new Point(78, 233);
            textResultado.Name = "textResultado";
            textResultado.ReadOnly = true;
            textResultado.Size = new Size(278, 27);
            textResultado.TabIndex = 5;
            // 
            // BtReset
            // 
            BtReset.Location = new Point(700, 84);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(94, 29);
            BtReset.TabIndex = 7;
            BtReset.Text = "RESET";
            BtReset.UseVisualStyleBackColor = true;
            BtReset.Click += BtReset_Click;
            // 
            // Operaciones
            // 
            Operaciones.Controls.Add(Division);
            Operaciones.Controls.Add(Multiplicacion);
            Operaciones.Controls.Add(Resta);
            Operaciones.Controls.Add(Suma);
            Operaciones.Location = new Point(390, 49);
            Operaciones.Name = "Operaciones";
            Operaciones.Size = new Size(250, 211);
            Operaciones.TabIndex = 8;
            Operaciones.TabStop = false;
            Operaciones.Text = "Operaciones";
            // 
            // Division
            // 
            Division.AutoSize = true;
            Division.Location = new Point(10, 123);
            Division.Name = "Division";
            Division.Size = new Size(83, 24);
            Division.TabIndex = 3;
            Division.TabStop = true;
            Division.Text = "Division";
            Division.UseVisualStyleBackColor = true;
            // 
            // Multiplicacion
            // 
            Multiplicacion.AutoSize = true;
            Multiplicacion.Location = new Point(10, 93);
            Multiplicacion.Name = "Multiplicacion";
            Multiplicacion.Size = new Size(124, 24);
            Multiplicacion.TabIndex = 2;
            Multiplicacion.TabStop = true;
            Multiplicacion.Text = "Multiplicacion";
            Multiplicacion.UseVisualStyleBackColor = true;
            // 
            // Resta
            // 
            Resta.AutoSize = true;
            Resta.Location = new Point(10, 63);
            Resta.Name = "Resta";
            Resta.Size = new Size(66, 24);
            Resta.TabIndex = 1;
            Resta.TabStop = true;
            Resta.Text = "Resta";
            Resta.UseVisualStyleBackColor = true;
            // 
            // Suma
            // 
            Suma.AutoSize = true;
            Suma.Location = new Point(10, 33);
            Suma.Name = "Suma";
            Suma.Size = new Size(67, 24);
            Suma.TabIndex = 0;
            Suma.TabStop = true;
            Suma.Text = "Suma";
            Suma.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 507);
            Controls.Add(Operaciones);
            Controls.Add(BtReset);
            Controls.Add(label2);
            Controls.Add(textResultado);
            Controls.Add(BtCalcular);
            Controls.Add(label1);
            Controls.Add(textVarB);
            Controls.Add(variableA);
            Controls.Add(textVarA);
            Name = "Calculadora";
            Text = "Calculadora";
            Operaciones.ResumeLayout(false);
            Operaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textVarA;
        private Label variableA;
        private Label label1;
        private TextBox textVarB;
        private Button BtCalcular;
        private Label label2;
        private TextBox textResultado;
        private Button BtReset;
        private GroupBox Operaciones;
        private RadioButton Division;
        private RadioButton Multiplicacion;
        private RadioButton Resta;
        private RadioButton Suma;
    }
}
