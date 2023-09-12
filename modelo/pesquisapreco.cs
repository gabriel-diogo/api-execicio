using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_execicio.modelo
{
    public class pesquisapreco
    {
        public string Valor { get; set; }
//        Marca: "VW - VolksWagen"
//Modelo: "AMAROK High.CD 2.0 16V TDI 4x4 Dies. Aut"
//AnoModelo: 2014
//Combustivel: "Diesel"
//CodigoFipe: "005340-6"
//MesReferencia: "setembro de 2023"
//SiglaCombustivel: "D"
    public string Marca { get; set; }
        public string Anomodelo { get; set;}
        public string Combustivel {  get; set; }
        public string CodigoFipe { get; set; }
        public string MesReferencia {  get; set; }
        public string SiglaCombustivel { get; set; }
    }
}
