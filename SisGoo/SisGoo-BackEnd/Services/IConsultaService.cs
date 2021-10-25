using SisGoo_BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisGoo_BackEnd.Services
{
    public interface IConsultaService
    {
        List<Consulta> Buscar(string frase);
    }
}
