using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

using System.Data;


namespace Data
{
   public class DProducto
    {
        public List<Producto> Get()
        {
            string comandText = string.Empty;
            List<Producto> productoList = null;

            try
            {
                comandText = "USP_GetProducto";
                productoList = new List<Producto>();
                using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, comandText, CommandType.StoredProcedure))
                {
                    while (reader.Read())
                    {
                        productoList.Add(new Producto
                        {
                            idproducto = reader["idproducto"] != null ? Convert.ToInt32(reader["idproducto"]) : 0,
                            nombreProducto = reader["nombreProducto"] != null ? Convert.ToString(reader["nombreProducto"]) : string.Empty,
                            idProveedor = reader["idProveedor"] != null ? Convert.ToInt32(reader["idProveedor"]) :0,
                            idCategoria = reader["idCategoria"] != null ? Convert.ToInt32(reader["idCategoria"]) : 0,
                            cantidadPorUnidad = reader["cantidadPorUnidad"] != null ? Convert.ToString(reader["cantidadPorUnidad"]) : string.Empty,
                            precioUnidad = reader["precioUnidad"] != null ? Convert.ToInt32(reader["precioUnidad"]) : 0,
                            unidadesEnExistencia = reader["unidadesEnExistencia"] != null ? Convert.ToInt32(reader["unidadesEnExistencia"]) : 0,

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productoList;
        }
    }
}