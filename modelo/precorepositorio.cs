using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_execicio.modelo
{
    public class precorepositorio
    {
        public static pesquisapreco retornadados (string codigo,string tipo,string codigcar ,string ano) {

            var url = $@"https://parallelum.com.br/fipe/api/v1/{tipo}/marcas/{codigo}/modelos/{codigcar}/anos/{ano}";

            var resp = utiu. httpclientutl.costhttpclient(url);

             pesquisapreco preco = JsonSerializer.Deserialize<pesquisapreco>(resp.Result);
            //var preco= Newtonsoft.Json.JsonConvert.DeserializeObject <pesquisapreco>(resp.Result);
            return preco;

        }
    }
}
