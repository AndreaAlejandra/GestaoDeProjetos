using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Sprint
    {
        public int Codigo { set; get; }
        public int Numero { set; get; }
        public DateTime Inicio { set; get; }
        public DateTime Final { set; get; }
        public string Objetivo { set; get; }
        public int Codigo_Projeto { get; set; }

    }
}
