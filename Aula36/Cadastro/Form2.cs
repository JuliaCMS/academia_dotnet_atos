using Aula36;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            string verUsuario = textBoxUsuarioVerificar.Text;
            string verSenha = textBoxSenhaVerificar.Text;

            FileStream fs = new FileStream(@"C:\Workspace\academia_dotnet_atos\Aula36\Cadastro\cadastro.txt", FileMode.Open);

            using (StreamReader reader = new StreamReader(fs))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');
                    string usuario = campos[0];
                    string senhaCriptografada = campos[1];
                    Simetrica s = new Simetrica();
                    string senhaDescriptografada = s.DecryptData(senhaCriptografada, "cadastro");

                    if (verUsuario == usuario && verSenha == senhaDescriptografada)
                    {
                        MessageBox.Show("Verificação realizada com sucesso!");
                    }
                    else if (verUsuario != usuario)
                    {
                        MessageBox.Show("Usuário incorreto!");
                    }
                    else if (verSenha != senhaDescriptografada)
                    {
                        MessageBox.Show("Senha incorreta!");
                    }
                }
                reader.Close();
            }
        }
    }
}

