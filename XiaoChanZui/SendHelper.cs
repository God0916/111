using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace XiaoChanZui
{
    public class SendHelper
    {
        public static string Send(string method, string http, string sql = null)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50997/");
            HttpResponseMessage message = new HttpResponseMessage();
            switch (method)
            {
                case "get":
                    message = client.GetAsync(http).Result;
                    break;
                case "post":
                    HttpContent content = new StringContent(sql);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    message = client.PostAsync(http, content).Result;
                    break;
                case "delete":
                    message = client.DeleteAsync(http).Result;
                    break;
                case "put":
                    HttpContent content1 = new StringContent(sql);
                    content1.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    message = client.PutAsync(http, content1).Result;
                    break;
                default: break;
            }
            if (message.IsSuccessStatusCode)
            {
                return message.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "请求出错";
            }
        }
    }
}
