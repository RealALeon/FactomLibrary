using System;
using FactomLibrary.functions;
using System.IO;

namespace FactomLibrary.walletd
{
    /// <summary>
    /// Contains all the wallet API
    /// </summary>
    public class wallet_API
    {

        ///<summary>
        ///Retrieve all of the Factoid and Entry Credit addresses stored in the wallet.
        ///</summary>
        ///<param name="con">The connection object</param>
        ///<returns></returns>
        public static string all_addresses(Configure.Connection con)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.all_addresses + @"""
                }";

            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);

            return response;
        }//function


        ///<summary>
        ///Retrieve the public and private parts of a Factoid or Entry Credit address stored in the wallet.
        ///</summary>
        ///<param name="con">The connection object</param>
        ///<param name="address">The factom address object</param>
        ///<returns></returns>
        public static string address(Configure.Connection con, Configure.FactomAddress address)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.address + @""",
                    ""params"": {
                        ""address"": """ + address.entryCE_address + @"""
                    }
                }";

            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Composes a chain in factom.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="chainData">Chain data</param>
        /// <param name="address">Factom addresses</param>
        /// <returns></returns>
        public static string compose_chain(Configure.Connection con, Configure.ChainData chainData, Configure.FactomAddress address)
        {
            // convert extIDs to hex
            string ext_ids = utils.convertExternal_IDs(chainData.extIDs);

            //check if content is a path or actual content
            if (File.Exists(chainData.content))
            {
                //choose the type of algorithm to hash the file:
                chainData.content = utils.hashFile_SHA256(chainData.content);
                //chainData.content = utils.hashFile_SHA512(chainData.content);
            }
            else {
                //you can choose whether hash your content or convert it into hex_string
                //chainData.content = utils.hashString_SHA256(chainData.content);
                //chainData.content = utils.hashString_SHA512(chainData.content);
                chainData.content = utils.stringToHex(chainData.content);
            }

            string json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.compose_chain + @""",
                    ""params"": {
                            ""chain"": {
                                    ""firstentry"": {
                                            ""extids"": " + ext_ids + @",
                                            ""content"": """ + chainData.content + @"""
                                        }
                                },
                            ""ecpub"": """ + address.entryCE_address + @"""
                        }
                  }";

            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// This method, compose-entry, will return the appropriate API calls to create an entry in factom.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="entryData">Entry data</param>
        /// <param name="address">Factom addresses</param>
        /// <returns></returns>
        public static string compose_entry(Configure.Connection con, Configure.EntryData entryData, Configure.FactomAddress address)
        {
            // convert extIDs to hex
            string ext_ids = utils.convertExternal_IDs(entryData.extIDs);

            //check if content is a path or actual content
            if (File.Exists(entryData.content))
            {
                //choose the type of algorithm to hash the file:
                entryData.content = utils.hashFile_SHA256(entryData.content);
                //entryData.content = utils.hashFile_SHA512(chainData.content);
            }
            else
            {
                //you can choose whether hash your content or convert it into hex_string
                //entryData.content = utils.hashString_SHA256(entryData.content);
                //entryData.content = utils.hashString_SHA512(entryData.content);
                entryData.content = utils.stringToHex(entryData.content);
            }

            string json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.compose_entry + @""",
                    ""params"": {
                            ""entry"": {
                                    ""chainid"": """ + entryData.chainID + @""",
                                    ""extids"": " + ext_ids + @",
                                    ""content"": """ + entryData.content + @"""
                                },
                            ""ecpub"": """ + address.entryCE_address + @"""
                        }
                  }";
            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);
            return response;
            //return json;
        }//function


        /// <summary>
        /// Create a new Entry Credit Address and store it in the wallet.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <returns></returns>
        public static string generate_ec_address(Configure.Connection con)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.generate_ec_address + @"""
                }";
            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Return the wallet seed and all addresses in the wallet for backup and offline storage.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <returns></returns>
        public static string wallet_backup(Configure.Connection con)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.wallet_backup + @"""
                }";
            var request = http.createRequest(con.walletd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function





    }//class
}//namespace
