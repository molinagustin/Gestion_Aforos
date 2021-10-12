using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccesoDatos.Entidades;

namespace CAccesoDatos.Contratos
{
    public interface IRepositorioExpediente : IRepositorioGenerico<entExpediente>
    {
        entExpediente BuscarExpediente(string Anio, string Numero);
    }
}
