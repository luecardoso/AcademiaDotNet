using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int op = 0;
            string baseURL = "https://localhost:7228/";
            string token = "";

            do
            {
                Console.WriteLine("Digite 1 para solicitar " +
                    "solicitar o token e 2 para consumir o endpoint 1");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Usuario usuario = new Usuario();
                        Console.Write("Digite o login: ");
                        usuario.login = Console.ReadLine();
                        Console.Write("Digite a senha: ");
                        usuario.senha = Console.ReadLine();

                        HttpClient clientToken = new HttpClient();
                        clientToken.DefaultRequestHeaders.Accept.Clear();
                        clientToken.DefaultRequestHeaders.Accept
                            .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage respToken = clientToken
                            .PostAsJsonAsync(baseURL+"api/token/autenticar",usuario).Result;


                        if (respToken.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            token = respToken.Content.ReadAsStringAsync().Result;
                            Console.WriteLine("Token: "+token);
                        }
                        else
                        {
                            Console.WriteLine(respToken.StatusCode);
                        }

                        break;
                    case 2:

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(baseURL);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", ""+token.Replace("\"",""));

                        HttpResponseMessage responde = await client.GetAsync("api/token/endpoint1");

                        if (responde.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string retorno = responde.Content.ReadAsStringAsync().Result;
                            Console.WriteLine("Retorno: " + retorno);
                        }
                        else
                        {
                            Console.WriteLine(responde.StatusCode);
                        }

                        break;

                }
            }while (op != 0);
        }
    }
}
