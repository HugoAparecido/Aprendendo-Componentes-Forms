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
            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";
            //tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_veiculo.Text;
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new(tb_listaVeiculos.Text);
            f_Veiculos.ShowDialog();
        }
    }
}
