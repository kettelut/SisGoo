using SisGoo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SisGoo.Services.Implementations
{
    public class ConsultaServiceImplementation : IConsultaService
    {
        public async Task<List<Consulta>> BuscarAsync(string frase)
        {
            List<Consulta> consultas = new List<Consulta>();

            // Instancia uma conexão com a URL do Google para coletar os títulos e links
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://www.google.com/search?q=" + frase + "&rlz=1C1GCEB_enBR959BR959&oq=" + frase + "&aqs=chrome..69i57j69i59j0i433i512j0i512l2j0i433i512l5.4811j0j15&sourceid=chrome&ie=UTF-8");
            
            HttpContent responseContent = response.Content;
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                var retorno = await reader.ReadToEndAsync();
                String[] elementos = retorno.Split("<a ");
                int contador = 0;

                // Percorre os link's
                foreach (string item in elementos)
                {
                    // Validá se são os links principais da consulta
                    if(item.Contains("url?q=") && item.Contains("<h3 class="))
                    {
                        contador++;

                        // Trata o HTML do link
                        String[] getLink = item.Split("\"><");
                        getLink[0] = getLink[0].Replace("href=\"", "");  
                        getLink[0] = getLink[0].Replace("/url?q=", "");
                        String[] getLink2 = getLink[0].Split("&amp");
                        var linkAdd = getLink2[0];

                        // Trata o HTML do título
                        String[] getTitulo = item.Split("<div class=\"BNeawe vvjwJb AP7Wnd\">");
                        String[] getTitulo2 = getTitulo[1].Split("</div></h3>");
                        var tituloAdd = getTitulo2[0];

                        Consulta consultaAdd = new Consulta
                        {
                            Id = contador,
                            Titulo = tituloAdd,
                            Link = linkAdd
                        };

                        consultas.Add(consultaAdd);
                    }
                }

            }

            return consultas;
        }
    }
}
