using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcMySQL
{
    [Table("region")]
    public class Region
    {
        [Key]
        public int cod_region { get; set; }
        public string nombre { get; set; }
    }
}