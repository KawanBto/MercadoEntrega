namespace MercadoEntrega.View
{
    partial class Produtos
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
            txt_nome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_marca = new TextBox();
            mt_valor = new MaskedTextBox();
            btn_gravar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 28);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 108);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(80, 126);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(270, 23);
            txt_nome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 176);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 242);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Valor";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(80, 194);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(270, 23);
            txt_marca.TabIndex = 5;
            // 
            // mt_valor
            // 
            mt_valor.Location = new Point(80, 260);
            mt_valor.Name = "mt_valor";
            mt_valor.Size = new Size(100, 23);
            mt_valor.TabIndex = 6;
            // 
            // btn_gravar
            // 
            btn_gravar.Location = new Point(188, 331);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 7;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 384);
            Controls.Add(btn_gravar);
            Controls.Add(mt_valor);
            Controls.Add(txt_marca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Produtos";
            Text = "Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_nome;
        private Label label3;
        private Label label4;
        private TextBox txt_marca;
        private MaskedTextBox mt_valor;
        private Button btn_gravar;
    }
}