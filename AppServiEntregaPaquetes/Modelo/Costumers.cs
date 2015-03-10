using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServiEntregaPaquetes
{
    public class Costumers
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string Email;

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }
        private string datosCliente;

        public string DatosCliente
        {
            get { return datosCliente; }
            set { datosCliente = value; }
        }

        public Costumers()
        {

            this.apellido = "apellido";
            this.datosCliente = "datosCliente";
            this.direccion = "direccion";
            this.Email = "Email";
            this.nombre = "nombre";




        }
    }
}
