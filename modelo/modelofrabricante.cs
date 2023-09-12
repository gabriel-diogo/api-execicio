using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_execicio.modelo
{
    public class modelofrabricante
    {
        public List<modelos> modelos { get; set; }


    }

    public class modelos
    {
        public string nome { get; set; }
        public string codigo{ get; set;}
    
    }
}
