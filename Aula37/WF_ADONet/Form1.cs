using System.Data;

namespace WF_ADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "select * from pessoas";
            DataTable dt = new DataTable();
            dt = bd.executarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            string sql = "select * from pessoas where nome = '" + txtNome.Text + "'";
            DataTable dt = new DataTable();
            dt = bd.executarConsultaGenerica(sql);
            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.profissao = textBoxProfissao.Text;

            if (p.gravarPessoa())
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            if (pessoa.excluir(int.Parse(textBoxID.Text)))
            {
                MessageBox.Show("Pessoa excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir pessoa!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = int.Parse(textBoxID.Text);
            p.nome = textBoxNome.Text;
            p.profissao = textBoxProfissao.Text;

            if (p.atualizar(p.nome, p.profissao, p.id))
            {
                MessageBox.Show("Editado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Editar usuário");
            }
        }
    }
}