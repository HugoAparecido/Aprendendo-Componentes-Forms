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
            tb_listaVeiculos.Location = new Point(12, 66);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(324, 315);
            tb_listaVeiculos.TabIndex = 4;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 399);
            Controls.Add(tb_listaVeiculos);
            Controls.Add(label1);
            Controls.Add(tb_veiculo);
            Controls.Add(btn_adicionar);
            Name = "F_Principal";
            Text = "Componentes - CFB Cursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_adicionar;
        private TextBox tb_veiculo;
        private Label label1;
        private TextBox tb_listaVeiculos;
    }
}
