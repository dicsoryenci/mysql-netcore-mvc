using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcMySQL
{
    public class Cliente
    {
        public Cliente(string nit, string nombre){
            this.nit = nit;
            this.nombre = nombre;
        }
        public string nit { get; set; }
        public string nombre { get; set; }
    }
}