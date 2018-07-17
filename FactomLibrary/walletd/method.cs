namespace FactomLibrary.walletd
{
    /// <summary>
    /// Contains all the methods for wallet API
    /// </summary>
    public class method
    {
        ///<summary>
        ///Retrieve all of the Factoid and Entry Credit addresses stored in the wallet.
        ///</summary>
        internal const string all_addresses = "all-addresses";


        ///<summary>
        ///Retrieve the public and private parts of a Factoid or Entry Credit address stored in the wallet.
        ///</summary>
        internal const string address = "address";


        ///<summary>
        ///Create a new Entry Credit Address and store it in the wallet.
        ///</summary>
        internal const string generate_ec_address = "generate-ec-address";


        ///<summary>
        ///Create a new Entry Credit Address and store it in the wallet.
        ///</summary>
        internal const string generate_factoid_address = "generate-factoid-address";


        ///<summary>
        ///Retrieve current properties of factom-walletd, including the wallet and wallet API versions.
        ///</summary>
        internal const string properties = "properties";


        ///<summary>
        ///This method, compose-chain, will return the appropriate API calls to create a chain in factom.
        ///</summary>
        internal const string compose_chain = "compose-chain";


        ///<summary>
        ///This method, compose-entry, will return the appropriate API calls to create an entry in factom.
        ///</summary>
        internal const string compose_entry = "compose-entry";



        ///<summary>
        ///Retrieves all transactions that involve a particular address.
        ///</summary>
        internal const string transactions = "transactions";



        ///<summary>
        ///Signs the transaction.
        ///</summary>
        internal const string sign_transaction = "sign-transaction";


        ///<summary>
        ///Return the wallet seed and all addresses in the wallet for backup and offline storage.
        ///</summary>
        internal const string wallet_backup = "wallet-backup";


    }
}
