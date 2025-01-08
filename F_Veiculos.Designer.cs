namespace AprendendoForms
{
    partial class F_Veiculos
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
            tb_listaVeiculos = new TextBox();
            SuspendLayout();
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.Location = new Point(12, 12);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(510, 426);
            tb_listaVeiculos.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(tb_listaVeiculos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Veiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Veículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_listaVeiculos;
    }
}