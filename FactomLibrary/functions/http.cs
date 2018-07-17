using System.IO;
using System.Net;

namespace FactomLibrary.functions
{
    public class http
    {

        /// <summary>
        /// Creates a post web request to specific url
        /// </summary>
        /// <param name="url">server url</param>
        /// <param name="parameters">json to send</param>
        /// <returns></returns>
        public static WebRequest createRequest(string url, string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "text/plain";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(parameters);
            }

            return request;
        }//create request





        ///<summary>
        ///Tries to Retrieve a Response for the HTTP Request.
        ///</summary>
        ///<param name="request"></param>
        /// <returns></returns>
        public static string getResponse(WebRequest request)
        {
            request = (HttpWebRequest)request;
            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
            catch (WebException exception)
            {
                return utils.factom_exception(exception, request);
            }
        }//function


    }//class
}//namespace
