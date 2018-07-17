using FactomLibrary.functions;
using System;

namespace FactomLibrary.factomd
{
    public class factom_API
    {

        ///<summary>
        ///Send a Chain Commit Message to factomd to create a new Chain. The commit chain has to be hex encoded string.
        ///</summary>
        /// <param name="con">Connection object</param>
        /// <param name="message">Message to commit the chain</param>
        public static string commit_chain(Configure.Connection con, string message)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.commit_chain + @""",
                    ""params"": {
                        ""message"": """ + message + @"""
                    }
                }";

            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        ///<summary>
        ///Reveal the First Entry in a Chain to factomd after the Commit to complete the Chain creation. The reveal-chain has to be hex encoded string
        ///</summary>
        /// <param name="con">Connection object</param>
        /// <param name="entry"></param>
        public static string reveal_chain(Configure.Connection con, string entry)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.reveal_chain + @""",
                    ""params"": {
                        ""entry"": """ + entry + @"""
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        ///<summary>
        /// Sends an Entry Commit Message to factom to create a new Entry. The entry commit is hex encoded string
        ///</summary>
        /// <param name="con">Connection object</param>
        /// <param name="message">Message to commit the entry</param>
        public static string commit_entry(Configure.Connection con, string message)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.commit_entry + @""",
                    ""params"": {
                        ""message"": """ + message + @"""
                    }
                }";

            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        ///<summary>
        /// Reveal an Entry to factomd after the Commit to complete the Entry creation. The reveal-entry has to be hex encoded string
        ///</summary>
        /// <param name="con">Connection object</param>
        /// <param name="entry"></param>
        public static string reveal_entry(Configure.Connection con, string entry)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.reveal_entry + @""",
                    ""params"": {
                        ""entry"": """ + entry + @"""
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        ///<summary>
        /// Return its current balance for a specific entry credit address.
        ///</summary>
        /// <param name="con">Connection object</param>
        /// <param name="address">Address object</param>
        /// <returns></returns>
        public static string entry_credit_balance(Configure.Connection con, Configure.FactomAddress address)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.entry_credit_balance + @""",
                    ""params"": {
                        ""address"": """ + address.entryCE_address + @"""
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Get an Entry from factomd specified by the Entry Hash.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="entry_hash">Entry hash</param>
        public static string entry(Configure.Connection con, string entry_hash)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.entry + @""",
                    ""params"": {
                        ""hash"": """ + entry_hash + @"""
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Return the keymr of the head of the chain for a chain ID (the unique hash created when the chain was created).
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="chainid">Chain ID</param>
        public static string chain_head(Configure.Connection con, string chainid)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.chain_head + @""",
                    ""params"": {
                        ""chainid"": """ + chainid + @"""
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Retrieve details of a factoid transaction using a transaction’s hash (or corresponding transaction id).
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="hash">Transaction Hash</param>
        public static string transaction(Configure.Connection con, string hash)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.transaction + @""",
                    ""params"": {
                        ""hash"": """ + hash + @"""
                    }
                }";

            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function


        /// <summary>
        /// Retrieve administrative blocks for any given height.
        /// </summary>
        /// <param name="con">Connection object</param>
        /// <param name="height">Administrator block height</param>
        public static string ablock_by_height(Configure.Connection con, int height)
        {
            String json =
                @"{
                    ""jsonrpc"": ""2.0"",
                    ""id"": 0,
                    ""method"": """ + method.ablock_by_height + @""",
                    ""params"": {
                        ""height"": " + height + @"
                    }
                }";
            var request = http.createRequest(con.factomd_address, json);
            var response = http.getResponse(request);
            return response;
        }//function

    }//class
}//namespace
