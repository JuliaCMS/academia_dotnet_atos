namespace Aula36
{
    public partial class Form1 : Form
    {
        private Assimetrica a = new Assimetrica();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCripto_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = textBoxMensagem.Text;
            string msgCripto = s.EncryptData(msg, "atos");
            labelCripto.Text = msgCripto;
        }

        private void buttonDescript_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            labelDescript.Text = s.DecryptData(labelCripto.Text, "atos");
        }

        private void buttonTxtCripto_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            FileStream fs = new FileStream(@"C:\Workspace\academia_dotnet_atos\Aula36\Aula36\dadoscripto.txt", FileMode.Open);
            string msg = fs.ToString();
            string msgCripto = s.EncryptData(msg, "atos20232");
            labelTxtCripto.Text = msgCripto;
        }

        private void buttonDescriptTxt_Click(object sender, EventArgs e)
        {
            //Simetrica s = new Simetrica();
            //string filePath = File.ReadAllText("C:\\Workspace\\academia_dotnet_atos\\Aula36\\Aula36\\dadoscripto.txt");
            //string decryptedText = s.DecryptData(filePath, "atos20232");
            //labelDescriptTxt.Text = decryptedText;

            using var file = new StreamReader("C:\\Workspace\\academia_dotnet_atos\\Aula36\\Aula36\\dadoscripto.txt");
            string? line;

            Simetrica s = new Simetrica();

            while ((line = file.ReadLine()) != null)
            {
                labelDescriptTxt.Text = s.DecryptData(line, "atos20232");
            }
            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCriptAssi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(a.getPublicKey());
            string msg, msgCripto;
            msg = textBoxMsgAssi.Text;
            msgCripto = a.encrypt(msg);
            labelCriptoAssi.Text = msgCripto;
        }

        private void buttonDescriptAssi_Click(object sender, EventArgs e)
        {
            string msg = labelCriptoAssi.Text;
            string msgCripto = a.decrypt(msg);
            labelDescriptAssi.Text = msgCripto;
        }
    }
}