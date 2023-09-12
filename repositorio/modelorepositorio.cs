using api_execicio.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_execicio.repositorio
{
   public class modelorepositorio
    {
        public static List<modelos>listamodelo(string codigo,string tipo)
        {
            var url=$@"https://parallelum.com.br/fipe/api/v1/{tipo}/marcas/{codigo}/modelos";
            var resposta = utiu.httpclientutl.costhttpclient(url).Result;

            //am manutecao
             //List<modelos> mode = JsonSerializer.Deserialize<List<modelos>>(resposta);

            var mode=Newtonsoft.Json.JsonConvert.DeserializeObject<modelofrabricante> (resposta);
            return mode.modelos;
        }
    }
}
