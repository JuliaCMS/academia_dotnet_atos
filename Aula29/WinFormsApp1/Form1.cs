namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonGerarEmail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Botão gerar email foi clicado");
            //textBoxEmail.Text = textBoxSobrenome.Text.ToLower() + "_" + textBoxNome.Text.ToLower() + "@ufn.com.br";

            string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
            string[] vetorNome = textBoxNome.Text.Split(' ');

            textBoxEmail.Text = vetorSobrenome[vetorSobrenome.Length - 1].ToLower() + "_" +
                vetorNome[0].ToLower() + "@ufn.com.br";

            textBoxListaEmails.AppendText(textBoxEmail.Text + Environment.NewLine);
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }

    }
}