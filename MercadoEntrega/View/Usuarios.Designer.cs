namespace MercadoEntrega.View
{
    partial class Usuarios
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
            txt_id = new TextBox();
            txt_carga = new TextBox();
            btn_gravar = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 140);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 198);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(0, 114);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(315, 27);
            txt_id.TabIndex = 3;
            // 
            // txt_carga
            // 
            txt_carga.Location = new Point(60, 106);
            txt_carga.Name = "txt_carga";
            txt_carga.Size = new Size(228, 23);
            txt_carga.TabIndex = 4;
            // 
            // btn_gravar
            // 
            btn_gravar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_gravar.Location = new Point(240, 243);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 5;
            btn_gravar.Text = "Cadastrar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 96);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa" });
            comboBox1.Location = new Point(0, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 28);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(60, 86);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 9;
            label5.Text = "Matrícula";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 43);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(btn_gravar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(60, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 283);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Acesso";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(315, 106);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(txt_carga);
            Controls.Add(label1);
            Name = "Usuarios";
            Text = "Usuarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private TextBox txt_carga;
        private Button btn_gravar;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private GroupBox groupBox1;
        private Button button1;
    }
}