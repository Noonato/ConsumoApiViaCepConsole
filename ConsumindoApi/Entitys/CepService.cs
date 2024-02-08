using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApi.Entitys
{
    public class CepService
    {
        public async Task<CepModel> Integracao(int cep)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json");
            var jsonString = await response.Content.ReadAsStringAsync();

            var jsonObject = JsonConvert.DeserializeObject<CepModel>(jsonString);

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
               return new CepModel
                {
                    Verificacao = true
                };
            }



        }
    }
    }

