using Raddish.Webs.Models;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;

namespace Raddish.Webs.Services.IServices
{
    public class BaseService : IBaseService
    {
        public ResponseDto responseModel { get;set;}
        public IHttpClientFactory httpClient { get; set; }
        public BaseService(IHttpClientFactory httpClient)
        {
           this.responseModel = new ResponseDto();
           this.httpClient = httpClient;
        }

       
        public async Task<T> SendAsync<T>(ApiRequests apiRequests)
        {
            try
            {
                var client = httpClient.CreateClient("RaddishRestaurantAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequests.Url);
                client.DefaultRequestHeaders.Clear();
                if (apiRequests.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequests.Data),
                    Encoding.UTF8,"application/json");
                }
                HttpResponseMessage apiResponse = null;
                 switch (apiRequests.ApiType)
                 {           
                        case SD.ApiType.POST:
                            message.Method = HttpMethod.Post;   
                            break;
                        case SD.ApiType.PUT:
                            message.Method = HttpMethod.Put;    
                            break;
                        case SD.ApiType.DELETE:
                            message.Method = HttpMethod.Delete;
                            break;
                        default:
                            message.Method = HttpMethod.Get;
                            break;
                 }
                    apiResponse = await client.SendAsync(message);
                    var apiContent = await apiResponse.Content.ReadAsStringAsync();
                    var apiResposeDto = JsonConvert.DeserializeObject<T>(apiContent);
                    return apiResposeDto;   
                
            }
            catch (Exception e)
            { 

                var dto = new ResponseDto
                {
                    DisplayMessage = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };

                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
      

        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

    }
}
