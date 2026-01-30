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
            BtCalcular.Location = new Point(500, 51);
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
            BtReset.Location = new Point(500, 102);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(94, 29);
            BtReset.TabIndex = 7;
            BtReset.Text = "RESET";
            BtReset.UseVisualStyleBackColor = true;
            BtReset.Click += BtReset_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 507);
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
    }
}
