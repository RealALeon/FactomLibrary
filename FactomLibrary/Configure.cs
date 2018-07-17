namespace FactomLibrary
{
    /// <summary>
    /// Haves all configuration options
    /// </summary>
    public class Configure {


        /// <summary>
        /// Configure connection
        /// </summary>
        public class Connection
        {
            public string factomd_address { get; set; }
            public string walletd_address { get; set; }

            /// <summary>
            /// Creates addresses
            /// </summary>
            /// <param name="factomd">factomd server address</param>
            /// <param name="domain">walletd server address</param>
            public Connection(string factomd, string walletd)
            {
                factomd_address = factomd;
                walletd_address = walletd;
            }
        }//connection



        /// <summary>
        /// Configure factom address
        /// </summary>
        public class FactomAddress
        {
            public string factoid_address { get; set; }
            public string entryCE_address { get; set; }

            /// <summary>
            /// Defines the initial addresses
            /// </summary>
            /// <param name="EC_address">Entry Credits public key</param>
            /// <param name="factoID_address">factoids public key</param>
            public FactomAddress(string EC_pkey, string factoid_pkey) {
                entryCE_address = EC_pkey;
                factoid_address = factoid_pkey;
            }
        }//factom address




        /// <summary>
        /// Configures the data to create a new chain
        /// </summary>
        public class ChainData
        {
            public string content { get; set; }
            public string[] extIDs { get; set; }

        }//entryData



        /// <summary>
        /// Configures the data to be entered
        /// </summary>
        public class EntryData{
            public string content { get; set; }
            public string[] extIDs { get; set; }
            public string chainID { get; set; }
            
        }//entryData



    }//configure class
}//namespace
