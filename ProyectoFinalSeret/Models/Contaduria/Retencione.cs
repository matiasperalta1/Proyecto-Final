using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Retencione
    {
        public Retencione()
        {
            RetClients = new HashSet<RetClient>();
            RetProvees = new HashSet<RetProvee>();
        }

        public int RetCodret { get; set; }
        public string RetDescri { get; set; }
        public string RetCtacon { get; set; }
        public decimal? RetPorcen { get; set; }
        public string RetObserv { get; set; }

        public virtual ICollection<RetClient> RetClients { get; set; }
        public virtual ICollection<RetProvee> RetProvees { get; set; }
    }
}
