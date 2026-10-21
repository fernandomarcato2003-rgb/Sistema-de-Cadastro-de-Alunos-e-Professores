namespace Projeto_P2
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "SEÇÃO DE PROFESSORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 1;
            label2.Text = "1- Cadastrar Professores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 2;
            label3.Text = "2- Exibir Lista de Professores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(235, 20);
            label4.TabIndex = 3;
            label4.Text = "3- Alterar Cadastro de Professores";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 144);
            label5.Name = "label5";
            label5.Size = new Size(249, 20);
            label5.TabIndex = 4;
            label5.Text = "4- Remover Cadastro de Professores";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 179);
            label6.Name = "label6";
            label6.Size = new Size(194, 20);
            label6.TabIndex = 5;
            label6.Text = "5- Ir Para a Seção de Alunos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 209);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 6;
            label7.Text = "6- Sair do Programa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 238);
            label8.Name = "label8";
            label8.Size = new Size(143, 20);
            label8.TabIndex = 7;
            label8.Text = "Escolha uma Opção:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 27);
            textBox1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
    }
}