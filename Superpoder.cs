using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class Superpoder
    {
        string nombre;
        string descripcion;
        string nivel;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nivel { get => nivel; set => nivel = value; }

        public void crearpoder(string _nombre, string _descripcion,string _nivel)
        { 
            nombre = _nombre;
            descripcion= _descripcion; ;
            nivel = _nivel;
        
        }

    }
}
