using api_execicio.utiu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_execicio.modelo
{
   public class aborepositorio
    {
        public static List<ano>litaano(string codigo,string tipo,string codcar)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{tipo}/marcas/{codigo}/modelos/{codcar}/anos";

            var resp = httpclientutl.costhttpclient(url);
             List<ano> ano = JsonSerializer.Deserialize<List<ano>>(resp.Result);
           // List<ano> ano = Newtonsoft.Json.JsonSerializer .Deserializet<ano>(resp);
            return ano;


        }
    }
}
