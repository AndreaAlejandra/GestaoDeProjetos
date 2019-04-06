using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Projeto
    {              
      
            public int Codigo { set; get; }
            public string Nome { set; get; }
            public DateTime Inicio { set; get; }
            public DateTime Final { get; set; }
            public string Descricao { get; set; }


        
    }
}
