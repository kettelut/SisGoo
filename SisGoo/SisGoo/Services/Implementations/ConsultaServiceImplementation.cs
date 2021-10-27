using SisGoo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SisGoo.Services.Implementations
{
    public class ConsultaServiceImplementation : IConsultaService
    {
        public List<Consulta> Buscar(string frase)
        {
            List<Consulta> consultas = new List<Consulta>();

            var client = new HttpClient();

            // Get the response.
            //HttpResponseMessage response = await client.GetAsync("https://www.google.com/search?q=teste&rlz=1C1GCEB_enBR959BR959&oq=teste&aqs=chrome..69i57j69i59j0i433i512j0i512l2j0i433i512l5.4811j0j15&sourceid=chrome&ie=UTF-8");

            // Get the response content.
            //HttpContent responseContent = response.Content;

            // Get the stream of the content.
            //using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            //{
                // Write the output.
                //var retorno = await reader.ReadToEndAsync();
            //}

            Consulta consultaTeste = new Consulta
            {
                Id = 1,
                Titulo = "Teste Título",
                Link = "https://www.google.com.br"

            };

            for (int i = 0; i < 8; i++)
            {
                consultas.Add(consultaTeste);
            }

            return consultas;
        }
    }
}
