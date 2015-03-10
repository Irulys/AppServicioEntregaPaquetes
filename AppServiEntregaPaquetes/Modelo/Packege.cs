using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServiEntregaPaquetes
{
    public class Packege : TwoDayPackage
    {
        private string Código;

        public string Código1
        {
            get { return Código; }
            set { Código = value; }
        }
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string dirección;

        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }
        private string ciudad;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        private string Estado;

        public string Estado1
        {
            get { return Estado; }
            set { Estado = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private string CódigoPostal;

        public string CódigoPostal1
        {
            get { return CódigoPostal; }
            set { CódigoPostal = value; }
        }

       
        public Packege()
        {
            this.ciudad = "ciudad";
            this.Código = "Código";

            this.CódigoPostal = "CódigoPostal";
            this.costo = 0;
            this.departamento = "departamento";
            this.departamento = "departamento";
            this.dirección = "direccion";
            this.Estado = "Estado";
        }


        public void CalculateCost()
        {
            throw new System.NotImplementedException();




        }

        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public BillsRepositories BillsRepositories
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
