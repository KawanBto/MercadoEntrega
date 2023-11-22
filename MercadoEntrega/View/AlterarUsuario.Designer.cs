namespace MercadoEntrega.View
{
    partial class AlterarUsuario
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 260);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(356, 231);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa" });
            comboBox1.Location = new Point(89, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 76);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 23);
            textBox3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 129);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 11;
            label1.Text = "Senha";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(362, 112);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 12;
            label2.Text = "Digite a Matrícula do Usuário:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(170, 20);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 14;
            label6.Text = "Alterar Usuário";
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 437);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(groupBox1);
            Name = "AlterarUsuario";
            Text = "Sistema de Gerenciamento de Vendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Label label2;
        private Label label6;
    }
}