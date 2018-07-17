using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace FactomLibrary.functions
{
    public class utils
    {
        /// <summary>
        /// Converts String array into single row string
        /// </summary>
        /// <param name="external_IDs"></param>
        /// <returns></returns>
        public static string convertExternal_IDs(string[] external_IDs)
        {
            string extIDs = "[";
            foreach (var id in external_IDs)
            {
                extIDs += @"""" + stringToHex(id) + @""", ";
            }
            extIDs = extIDs.Remove(extIDs.Length - 2);
            extIDs += "]";
            return extIDs;
        }


        /// <summary>
        /// Converts normal string to hex string
        /// </summary>
        /// <param name="data">String data to be converted into hex string</param>
        /// <returns></returns>
        public static string stringToHex(string data)
        {
            byte[] array = Encoding.ASCII.GetBytes(data);
            var hex = BitConverter.ToString(array);
            hex = hex.Replace("-", "").ToLower();
            return hex;
        }


        /// <summary>
        /// Hashes a file in SHA256
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <returns></returns>
        public static string hashFile_SHA256(string path)
        {
            byte[] file = File.ReadAllBytes(path);
            var byteHash = SHA256.Create().ComputeHash(file);
            string hash = byteArrayToHexString(byteHash);
            return hash;
        }


        /// <summary>
        /// Hashes a file in SHA512
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <returns></returns>
        public static string hashFile_SHA512(string path)
        {
            byte[] file = File.ReadAllBytes(path);
            var byteHash = SHA512.Create().ComputeHash(file);
            string hash = byteArrayToHexString(byteHash);
            return hash;
        }


        /// <summary>
        /// Hashes a string in SHA256
        /// </summary>
        /// <param name="data">String to be hashed</param>
        /// <returns></returns>
        public static string hashString_SHA256(string data)
        {
            var byteHash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
            string hash = byteArrayToHexString(byteHash);
            return hash;
        }


        /// <summary>
        /// Hashes a string in SHA512
        /// </summary>
        /// <param name="data">String to be hashed</param>
        /// <returns></returns>
        public static string hashString_SHA512(string data)
        {
            var byteHash = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
            string hash = byteArrayToHexString(byteHash);
            return hash;
        }


        /// <summary>
        /// Converts byte[] to hex string
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string byteArrayToHexString(byte[] array)
        {
            var hex = BitConverter.ToString(array);
            return hex.Replace("-", "").ToLower();
        }


        ///<summary>
        ///Gets Factom Exception
        ///</summary>
        public static string factom_exception(WebException exception, WebRequest request)
        {
            if (exception.Response != null)
            {
                StreamReader responseReader = new StreamReader(exception.Response.GetResponseStream());
                string string_error = responseReader.ReadToEnd();
                string_error = beautify.json(string_error);
                return string_error;
            }
            return null;
        }//function

    }//class
}//namespace
