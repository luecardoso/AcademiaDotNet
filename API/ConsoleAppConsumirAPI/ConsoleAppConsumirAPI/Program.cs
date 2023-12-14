using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsoleAppConsumirAPI
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string baseURL = "https://localhost:7228/";//local onde AulaAPI está rodando

            Console.WriteLine("Digite 1 para consultar\n" +
                "2 para cadastrar: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    List<Pessoa>? pessoas = new List<Pessoa>();
                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri(baseURL);
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Accept
                      .Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage resp = await httpClient.GetAsync("api/entity/pessoas");//vai concatenar com a baseURL
                    if (resp.IsSuccessStatusCode)
                    {
                        var response = resp.Content.ReadAsStringAsync().Result;
                        pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(response);

                        foreach (Pessoa item in pessoas)
                        {
                            Console.WriteLine(item.Id + " - "+item.Nome);
                        }
                    }

                    break;
                case 2:
                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = "Post na API";

                    HttpClient clientPost = new HttpClient();
                    HttpResponseMessage resPost = await clientPost.PostAsJsonAsync(
                        baseURL + "api/entity/pessoas", pessoa);

                    if (resPost.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Cadastrado com sucesso.");
                    }


                    break;
                default:
                    break;
            }
        }
    }
}
