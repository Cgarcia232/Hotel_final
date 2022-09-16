
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Hotel
{
    internal class Insumo
    {

        private int idproveedor;
        private string nombre;
        private int cantidad;
        private string vencido;

        public Insumo(int idproveedor, string nombre, int cantidad, string vencido)
        {

            this.idproveedor = idproveedor;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.vencido = vencido;
        }



        public void SetIdProveedor(int idproveedor)
        {
            this.idproveedor = idproveedor;

        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;

        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void SetVencido(string vencido)
        {

            this.vencido = vencido;

        }


        public int GetIdProveedor()
        {
            return idproveedor;

        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetCantidad()
        {
            return cantidad;

        }

        public string GetVencido()
        {
            return vencido;
        }
    }
}



