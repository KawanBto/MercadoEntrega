namespace MercadoEntrega.View
{
    partial class Funcionarios
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
            txt_nome = new TextBox();
            txt_cpf = new TextBox();
            txt_cep = new TextBox();
            txt_email = new TextBox();
            btn_gravarFunc = new Button();
            mt_num = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 109);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 165);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 342);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 28);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 3;
            label4.Text = "Cadastrar Funcionario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 224);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "CEP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 286);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 5;
            label6.Text = "Fone";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(54, 127);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(224, 23);
            txt_nome.TabIndex = 6;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(54, 183);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(224, 23);
            txt_cpf.TabIndex = 7;
            // 
            // txt_cep
            // 
            txt_cep.Location = new Point(54, 249);
            txt_cep.Name = "txt_cep";
            txt_cep.Size = new Size(224, 23);
            txt_cep.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(54, 360);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(224, 23);
            txt_email.TabIndex = 10;
            // 
            // btn_gravarFunc
            // 
            btn_gravarFunc.Location = new Point(129, 446);
            btn_gravarFunc.Name = "btn_gravarFunc";
            btn_gravarFunc.Size = new Size(75, 23);
            btn_gravarFunc.TabIndex = 11;
            btn_gravarFunc.Text = "Gravar";
            btn_gravarFunc.UseVisualStyleBackColor = true;
            btn_gravarFunc.Click += btn_gravarFunc_Click;
            // 
            // mt_num
            // 
            mt_num.Location = new Point(54, 304);
            mt_num.Mask = "(99) 0000-0000";
            mt_num.Name = "mt_num";
            mt_num.Size = new Size(224, 23);
            mt_num.TabIndex = 12;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 525);
            Controls.Add(mt_num);
            Controls.Add(btn_gravarFunc);
            Controls.Add(txt_email);
            Controls.Add(txt_cep);
            Controls.Add(txt_cpf);
            Controls.Add(txt_nome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Funcionarios";
            Text = "Funcionarios";
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
        private TextBox txt_nome;
        private TextBox txt_cpf;
        private TextBox txt_cep;
        private TextBox txt_email;
        private Button btn_gravarFunc;
        private MaskedTextBox mt_num;
    }
}