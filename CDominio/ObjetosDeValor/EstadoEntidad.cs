using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDominio.ObjetosDeValor
{
    //Esta enumeracion sirve para saber que tipo de consulta se va a realizar, y como van a ser varios modelos los que van a utilizar este tipo de dato, conviene tenerlo en un objeto accesible por todas estas clases.
    public enum EstadoEntidad
    {
        Agregar,
        Modificar,
        Eliminar
    }
}
