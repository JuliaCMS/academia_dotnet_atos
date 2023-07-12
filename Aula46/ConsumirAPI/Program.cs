using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Consumindo a API desenvolvida");
            int opcao;
            string BaseUrl = "http://localhost:5010";

            do
            {
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Consultar pessoas");
                Console.WriteLine("2 - Cadastrar pessoas");
                Console.WriteLine("3 - Alterar pessoas");
                Console.WriteLine("4 - Excluir pessoas");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 0:
                        break;
                    case 1:
                        List<Pessoa> pessoas = new List<Pessoa>(); // receber o que eu tenho armazenado no sistema
                        HttpClient client = new HttpClient(); // instanciando um objeto para fazer o acesso via http na API
                        client.BaseAddress = new Uri(BaseUrl); // definindo o endereço da API
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage resposta = await client.GetAsync("/Pessoa/pessoas"); // acessando o endpoint da API

                        if(resposta.IsSuccessStatusCode) // obtive sucesso na resposta, entro no if
                        {
                            var retorno = resposta.Content.ReadAsStringAsync().Result; // obtenho o retorno de uma consulta a API
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(retorno); // to pegando o retorno e desserializando e armazenando na lista
                        }
                        else
                        {
                            Console.WriteLine($"Erro: {resposta.StatusCode.ToString()}");
                        }
                        foreach(Pessoa p in pessoas)
                        {
                            Console.WriteLine($"ID: {p.id} \nNome: {p.nome}");
                        }
                        break;
                    //case 2:
                }

            } while(opcao != 0);
        }
    }
}