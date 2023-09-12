using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_execicio.modelo
{
    public class veiculorepositorios
    {
        public static List<veiculos> listaveiculos()
        {

            List<veiculos> lvveiculos = new List<veiculos>() {
            new veiculos{Id=1,Tipo="carros" },
            new veiculos{Id=2,Tipo="motos"},
            new veiculos{Id=3,Tipo="caminhoes"},


                                                                };
                return lvveiculos;
         }
    
    }
    
}
