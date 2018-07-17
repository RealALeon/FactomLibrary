using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace FactomLibrary.functions
{
    /// <summary>
    /// Only for beauty purposes
    /// </summary>
    public class beautify
    {
        ///<summary>
        ///Beautifies JSON Object
        ///</summary>
        public static string json(string ugly)
        {
            try
            {
                string pretty = JToken.Parse(ugly).ToString(Formatting.Indented);
                return pretty;
            }
            catch (Exception)
            {
                return ugly;
            }
        }//function




    }//class
}//namespace
