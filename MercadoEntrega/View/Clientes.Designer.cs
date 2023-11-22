namespace MercadoEntrega.View
{
    partial class Clientes
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
            mt_num = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            txt_nome = new TextBox();
            btn_Cadastrar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // mt_num
            // 
            mt_num.Location = new Point(40, 279);
            mt_num.Mask = "(99) 0000-0000";
            mt_num.Name = "mt_num";
            mt_num.Size = new Size(142, 23);
            mt_num.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 255);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 1;
            label1.Text = "Fone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 181);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(40, 214);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(302, 23);
            txt_email.TabIndex = 4;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(40, 133);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(302, 23);
            txt_nome.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Location = new Point(145, 330);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(101, 33);
            btn_Cadastrar.TabIndex = 6;
            btn_Cadastrar.Text = "Gravar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(95, 38);
            label4.Name = "label4";
            label4.Size = new Size(212, 30);
            label4.TabIndex = 7;
            label4.Text = "Cadastro de Clientes";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 407);
            Controls.Add(label4);
            Controls.Add(btn_Cadastrar);
            Controls.Add(txt_nome);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mt_num);
            Name = "Clientes";
            Text = "Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mt_num;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_email;
        private TextBox txt_nome;
        private Button btn_Cadastrar;
        private Label label4;
    }
}