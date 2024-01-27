using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        private string nombre;
        private string identidadSecreta;
        private string ciudad;
        private string puedeVolar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string IdentidadSecreta { get => identidadSecreta; set => identidadSecreta = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string PuedeVolar { get => puedeVolar; set => puedeVolar = value; }

        public void crearheroe(string _nombre,string _identidaSecreta,string _ciudad, string _puedeVolar) {
            nombre = _nombre;
            identidadSecreta = _identidaSecreta;
            ciudad = _ciudad;
            puedeVolar = _puedeVolar;


        
        }
}

}





