using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Empresa
    {
        public int EmpCodemp { get; set; }
        public string EmpRazsoc { get; set; }
        public string EmpActiv1 { get; set; }
        public string EmpActiv2 { get; set; }
        public string EmpDirecc { get; set; }
        public string EmpCiudad { get; set; }
        public string EmpProvin { get; set; }
        public string EmpTelefo { get; set; }
        public string EmpFax { get; set; }
        public string EmpMail { get; set; }
        public string EmpWeb { get; set; }
        public string EmpIva { get; set; }
        public string EmpCuit { get; set; }
        public string EmpIngbru { get; set; }
        public DateTime? EmpIniact { get; set; }
    }
}
