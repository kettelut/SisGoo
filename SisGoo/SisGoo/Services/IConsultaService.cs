using SisGoo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisGoo.Services
{
    public interface IConsultaService
    {
        List<Consulta> Buscar(string frase);
    }
}
