using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Aula35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serializar = textBox1.Text;
            FileStream fs = new FileStream(@"C:\Teste\Julia.data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            fs.Close();
            MessageBox.Show("Serializado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Teste\Julia.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDesserializada;
            msgDesserializada = (string)bf.Deserialize(fs);
            MessageBox.Show("Mensagem desserializada!");
            label1.Text = msgDesserializada;
        }

        private void buttonSerializaXML_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.idade = int.Parse(textBoxIdade.Text);
            p.salario = double.Parse(textBoxSalario.Text);

            FileStream fs = new FileStream(@"C:\Teste\pessoal.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            xml.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("Serializado em XML");

        }

        private void buttonDesserializaXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            FileStream fs = new FileStream(@"C:\Teste\pessoal.xml", FileMode.Open);
            Pessoa p = (Pessoa)xml.Deserialize(fs);

            MessageBox.Show("Mensagem desserializada!");
            labelNomeDs.Text = p.nome;
            labelIdadeDs.Text = p.idade.ToString();
            labelSalarioDs.Text = p.salario.ToString();
            fs.Close();

            // --- Resolução do professor ---
            //XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            //StreamReader reader = new StreamReader(@"C:\Teste\pessoal.xml");
            //Pessoa pDes;
            //pDes = (Pessoa)xml.Deserialize(reader);
            //labelNomeDs.Text = pDes.nome;
            //labelIdadeDs.Text = pDes.idade.ToString();
            //labelSalarioDs.Text = pDes.salario.ToString();
            //reader.Close();
        }

        private void buttonSerializaJSON_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.idade = int.Parse(textBoxIdade.Text);
            p.salario = double.Parse(textBoxSalario.Text);

            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Teste\pessoas.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, p);
            MessageBox.Show("Mensagem Serializada!");
            sw.Close();
            writer.Close();
        }

        private void buttonDesserializaJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Teste\pessoas.json");

            Pessoa pDes = JsonConvert.DeserializeObject<Pessoa>(json);
            labelNomeDs.Text = pDes.nome;
            labelIdadeDs.Text = pDes.idade.ToString();
            labelSalarioDs.Text = pDes.salario.ToString();
            MessageBox.Show("Mensagem desserializada!");
        }

        private void buttonSerializaSOAP_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.idade = int.Parse(textBoxIdade.Text);
            p.salario = double.Parse(textBoxSalario.Text);

            FileStream stream = new FileStream(@"C:\Teste\pessoas.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, p);
            stream.Close();
        }

        private void buttonDesSOAP_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Teste\pessoas.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pDes = new Pessoa();
            pDes = (Pessoa)soap.Deserialize(stream);
            labelNomeDs.Text = pDes.nome;
            labelIdadeDs.Text = pDes.idade.ToString();
            labelSalarioDs.Text = pDes.salario.ToString();
        }

        private void buttonSerSOAPVei_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();
            v.marca = textBoxMarca.Text;
            v.modelo = textBoxModelo.Text;
            v.ano = int.Parse(textBoxAno.Text);

            FileStream stream = new FileStream(@"C:\Teste\veiculo.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, v);
            stream.Close();
        }

        private void buttonDesSOAPVei_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Teste\veiculo.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Veiculo vDes = new Veiculo();
            vDes = (Veiculo)soap.Deserialize(stream);
            labelMarca.Text = vDes.marca;
            labelModelo.Text = vDes.modelo;
            labelAno.Text = vDes.ano.ToString();
        }
    }
}