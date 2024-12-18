namespace AprendendoForms
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veículo");
                tb_veiculo.Focus();
                return;
            }
        }
    }
}
