using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServiEntregaPaquetes
{
    public class BillsRepositories
    {
        private int id;
        private double items;

        public double Items
        {
            get { return items; }
            set { items = value; }
        }

        public BillsRepositories()
        {
            this.id = 0;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
