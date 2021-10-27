using SisGoo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisGoo.Services.Implementations
{
    public class ConsultaServiceImplementation : IConsultaService
    {
        public List<Consulta> Buscar(string frase)
        {
            List<Consulta> consultas = new List<Consulta>();

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
