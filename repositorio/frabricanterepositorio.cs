using api_execicio.modelo;
using api_execicio.utiu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace api_execicio.repositorio
{
   public class frabricanterepositorio
    {
        public static List<frabricantes>listafabricantes(string tipo)
        {
            var url = $@"https://parallelum.com.br/fipe/api/v1/{tipo}/marcas";

            var resposta = utiu.httpclientutl.costhttpclient(url);

            List<frabricantes> frabricantess = JsonSerializer.Deserialize<List<frabricantes>>(resposta.Result);


            
            return frabricantess;
        }
    }
}
