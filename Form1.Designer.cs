namespace AprendendoForms
{
    partial class F_Principal
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
            btn_adicionar = new Button();
            tb_veiculo = new TextBox();
            label1 = new Label();
            tb_listaVeiculos = new TextBox();
            btn_limpar = new Button();
            btn_mostrar = new Button();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(211, 30);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(125, 29);
            btn_adicionar.TabIndex = 1;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += Btn_adicionar_Click;
            // 
            // tb_veiculo
            // 
            tb_veiculo.Location = new Point(12, 32);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Size = new Size(193, 27);
            tb_veiculo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Digite um Veículo";
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.Font = new Font("Segoe UI", 12F);
            tb_listaVeiculos.Location = new Point(12, 66);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.ReadOnly = true;
            tb_listaVeiculos.Size = new Size(324, 315);
            tb_listaVeiculos.TabIndex = 4;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(12, 387);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(324, 29);
            btn_limpar.TabIndex = 5;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += Btn_limpar_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(12, 422);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(324, 29);
            btn_mostrar.TabIndex = 6;
            btn_mostrar.Text = "Mostrar Veículos";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += Btn_mostrar_Click;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 487);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_limpar);
            Controls.Add(tb_listaVeiculos);
            Controls.Add(label1);
            Controls.Add(tb_veiculo);
            Controls.Add(btn_adicionar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Componentes - CFB Cursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_adicionar;
        private TextBox tb_veiculo;
        private Label label1;
        private TextBox tb_listaVeiculos;
        private Button btn_limpar;
        private Button btn_mostrar;
    }
}
