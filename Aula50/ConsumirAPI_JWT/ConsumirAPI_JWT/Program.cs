using System.Net.Http.Headers;
using System.Net;
using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace ConsumirAPI_JWT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, JWT!");

            int op = 0;

            string url = "https://localhost:7194/JWT/primeiro";
            string token = "";

            do
            {
                Console.WriteLine("Digite 1 para solicitar TOKEN");
                Console.WriteLine("Digite 2 para consumir API");
                Console.WriteLine("Digite 0 para FECHAR");
                op = int.Parse(Console.ReadLine());

                Usuario user = new Usuario();

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("informe o usuario");
                        user.Username = Console.ReadLine();
                        Console.WriteLine("informe o senha");
                        user.Password = Console.ReadLine();

                        HttpClient clientToken = new HttpClient();
                        clientToken.DefaultRequestHeaders.Accept.Clear();
                        clientToken.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



                        HttpResponseMessage respToken = clientToken.PostAsJsonAsync(url + "autenticar", user).Result;



                        if (respToken.StatusCode == HttpStatusCode.OK)
                        {
                            token = respToken.Content.ReadAsStringAsync().Result;
                            token = token.Replace("\"", "");
                            Console.WriteLine(token);
                        }
                        else
                        {
                            Console.WriteLine(respToken.StatusCode);
                        }

                        break;


                    case 2:
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(url);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/text"));
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);



                        HttpResponseMessage resp = client.GetAsync("primeira").Result;

                        if (resp.StatusCode == HttpStatusCode.OK)
                        {
                            Console.WriteLine(resp.Content.ReadAsStringAsync().Result);
                        }
                        else
                        {
                            Console.WriteLine(resp.StatusCode);
                        }
                        break;
                    default:
                        break;
                }
            } while (op != 0);
        }
    }
}