using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Domain.Entities
{
    [Table("Producto")]
    public class Productos
    {
        
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
