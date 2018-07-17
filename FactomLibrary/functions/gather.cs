using Newtonsoft.Json.Linq;
using System;

namespace FactomLibrary.functions
{
    public class gather
    {

        /// <summary>
        /// Gets the compose object
        /// </summary>
        /// <param name="string_json"></param>
        /// <returns></returns>
        public static compose compose_object(string string_json)
        {
            try
            {
                // pass string to json object
                JObject json = JObject.Parse(string_json);

                // create vars to save json in object
                compose obj = new compose();
                compose.com commit = new compose.com();
                compose.rev reveal = new compose.rev();

                // commit objects
                commit.jsonrpc = json["result"]["commit"]["jsonrpc"].ToString();
                commit.id = json["result"]["commit"]["id"].ToString();
                commit.message = json["result"]["commit"]["params"]["message"].ToString();
                commit.method = json["result"]["commit"]["method"].ToString();

                // reveal objects
                reveal.jsonrpc = json["result"]["reveal"]["jsonrpc"].ToString();
                reveal.id = json["result"]["reveal"]["id"].ToString();
                reveal.entry = json["result"]["reveal"]["params"]["entry"].ToString();
                reveal.method = json["result"]["reveal"]["method"].ToString();

                // add atr to main object
                obj.commit = commit;
                obj.reveal = reveal;

                return obj;
            }
            catch (Exception) { return null; }
        }



    }//class
}//namespace
