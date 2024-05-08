using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Entidades
{
    internal class E_SaleItem
    {
        public int l_id { get; set; }
        public string l_desc { get; set; }
        public float l_cantidad { get; set; }
        public float l_precio { get; set; }

        public E_SaleItem(int id, string desc, float cant, float precio) {
            this.l_id = id;
            this.l_desc = desc;
            this.l_cantidad = cant;
            this.l_precio = precio;
        }
    }
}
