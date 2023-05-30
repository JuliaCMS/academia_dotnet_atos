using Aula36;
using Microsoft.Win32;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            FileStream fs = new FileStream(@"C:\Workspace\academia_dotnet_atos\Aula36\Cadastro\cadastro.txt", FileMode.Create);

            Simetrica s = new Simetrica();
            string senhaCripto = s.EncryptData(senha, "cadastro");
            string armazenar = $"{usuario};{senhaCripto}";

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(armazenar);
            }

            MessageBox.Show("Dados armazenados!");
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            Form2 formVerificacao = new Form2();
            formVerificacao.ShowDialog();
        }
    }
}