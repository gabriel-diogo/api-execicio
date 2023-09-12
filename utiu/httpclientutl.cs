using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_execicio.utiu
{
    public class httpclientutl
    {
        public static async Task<string> costhttpclient(string endereco){
            var client = new HttpClient();
            try{
            
                HttpResponseMessage respose = await client.GetAsync(endereco).ConfigureAwait(false);

                respose.EnsureSuccessStatusCode();
                string resposebody=await respose.Content.ReadAsStringAsync();
            return resposebody;
            
            }catch(Exception ex) { return ex.ToString();  }

                        }


    }
}
