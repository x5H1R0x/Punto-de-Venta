using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Entidades
{
    internal class E_Productos
    {
        public int codigo_pr { get; set; }
        public string nombre_pr { get; set; }
        public string descripcion_pr { get; set; }
        public string codigo_manu { get; set; }
        public decimal pu_costo { get; set; }
        public decimal pu_venta { get; set; }
        
        public int codigo_prov {  get; set; }
            public int codigo_us { get; set; }
        public int codigo_fa { get; set; }
    }
}
