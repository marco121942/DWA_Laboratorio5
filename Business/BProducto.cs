using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
   public  class BProducto
    {
        private DProducto dProducto = null;

        public List<Producto> Get(int idproducto)
        {

            List<Producto> productoList = null;

            try
            {
                dProducto = new DProducto();
                productoList = dProducto.Get();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productoList;
        }
    }
}
