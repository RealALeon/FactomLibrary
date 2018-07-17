using FactomLibrary;
using FactomLibrary.functions;
using FactomLibrary.walletd;
using FactomLibrary.factomd;
using System;

namespace TestLibrary
{
    public class test
    {

        //******************************************************************************************* change values here:
        private const string factomd_address = "http://localhost:8088/v2";
        private const string walletd_address = "http://localhost:8089/v2";

        private const string entryCE_pkey = "EC1rZace182PbyP3k3Yx9LhLfjj7aRTf5gpZqUFovkVhbJxULcyd";
        private const string factoid_pkey = "FA2NLSg9cKrz6mngiij34gHqQFpyPSwW7QdH6w4TJG6AeNbRZpip";

        // It can be either a path for a file or a text\plain content
        private const string content = @"C:\Users\user_name\Desktop\file.pdf";
        //private const string content = "This is a test";

        private static string[] ext_ids = new string[]
        {
            "ENC0D3D",
            "13"
        };

        private static string chain_id = "a59a183ffbcb734634aa6a174fc964631a95k148fbh0920b79fadd57d0e73c90";
        //***************************************************************************************************************





        // create main connection parameters
        private static Configure.Connection connection = new Configure.Connection(factomd_address, walletd_address);

        // define main addresses
        private static Configure.FactomAddress factom_addresses = new Configure.FactomAddress(entryCE_pkey, factoid_pkey);

        // define data to create chain
        private static Configure.ChainData chainData = new Configure.ChainData
        {
            content = content,
            extIDs = ext_ids,
        };

        // define main entry data. You need to have an existing chain_id
        private static Configure.EntryData entryData = new Configure.EntryData
        {
            content = content,
            extIDs = ext_ids,
            chainID = chain_id
        };

        // print pretty json in console
        private static void _print(string data)
        {
            data = beautify.json(data);
            Console.WriteLine(data);
        }







        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string response;
            try
            {
                //***@ gets all addresses from server
                response = wallet_API.all_addresses(connection);
                _print(response);

                //***@ prints a specific address
                response = wallet_API.address(connection, factom_addresses);
                _print(response);


                //************************ CHAIN
                //***@ compose chain
                response = wallet_API.compose_chain(connection, chainData, factom_addresses);
                _print(response);
                compose composed_chain = gather.compose_object(response);

                //***@ commit chain
                response = factom_API.commit_chain(connection, composed_chain.commit.message);
                _print(response);

                //***@ reveal chain
                response = factom_API.reveal_chain(connection, composed_chain.reveal.entry);
                _print(response);
                //************************ CHAIN


                //************************ ENTRY
                //***@ compose entry
                response = wallet_API.compose_entry(connection, entryData, factom_addresses);
                _print(response);
                compose composed_entry = gather.compose_object(response);

                //***@ commit entry
                response = factom_API.commit_entry(connection, composed_entry.commit.message);
                _print(response);

                //***@ reveal entry
                response = factom_API.reveal_entry(connection, composed_entry.reveal.entry);
                _print(response);
                //************************ ENTRY


                //***@ get EC current balance
                response = factom_API.entry_credit_balance(connection, factom_addresses);
                _print(response);

                //***@ get entry by its hash
                response = factom_API.entry(connection, "entry_hash_here");
                _print(response);

                //***@ Return the keymr of the head of the chain for a chain ID.
                response = factom_API.chain_head(connection, chain_id);
                _print(response);

                //***@ Retrieve details of a factoid transaction using a transaction’s hash.
                response = factom_API.transaction(connection, "transaction_hash_here");
                _print(response);

                //***@ Retrieve administrative blocks for any given height.
                response = factom_API.ablock_by_height(connection, 14460);
                _print(response);

                //***@ Create a new Entry Credit Address and store it in the wallet.
                response = wallet_API.generate_ec_address(connection);
                _print(response);

                //***@ Return the wallet seed and all addresses in the wallet for backup and offline storage.
                response = wallet_API.wallet_backup(connection);
                _print(response);


                Console.ReadLine();
            }
            catch (Exception) { }
        }//main





    }//class test
}//namespace
