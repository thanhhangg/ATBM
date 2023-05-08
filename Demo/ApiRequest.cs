using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Demo
{
    public static class ApiRequest
    {
        private static readonly string baseUrl = "http://localhost:5000";

        public static List<T> GetAll<T>(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var content = streamReader.ReadToEnd();

            List<T> lst = null;

            try
            {
                lst = JsonSerializer.Deserialize<List<T>>(content);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return lst;
        }
       
        public static T Get<T>(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var content = streamReader.ReadToEnd();
            var obj = JsonSerializer.Deserialize<T>(content);
            return obj;
        }

        public static PostResult<T> Post<T>(string url, string content)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var data = Encoding.UTF8.GetBytes(content);
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }


            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        var json = streamReader.ReadToEnd();

                        PostResult<T> result = JsonSerializer.Deserialize<PostResult<T>>(json);
                        return result;
                    }
                    else
                    {
                        // fail
                        return null;
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("An error occurred while making the request: " + ex.Message);
                return null;
            }
        }
        public static JsonNode Post(string url, string content)
        {
            var request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var data = Encoding.UTF8.GetBytes(content);
            request.ContentLength = data.Length;
            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.Created)
                    {
                        var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        var json = streamReader.ReadToEnd();

                        return JsonSerializer.Deserialize<JsonNode>(json);
                    }
                    else
                    {
                        // fail
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
