using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactomLibrary.factomd
{
    public class method
    {
        ///<summary>
        ///Retrieve administrative blocks for any given height.
        ///</summary>
        internal const string ablock_by_height = "ablock-by-height";


        ///<summary>
        ///Used to find the status of a transaction, whether it be a factoid, reveal entry, or commit entry.
        ///</summary>
        internal const string ack = "ack";


        ///<summary>
        ///Retrieve a specified admin block given its merkle root key.
        ///</summary>
        internal const string admin_block = "admin-block";


        ///<summary>
        ///Return its current balance for a specific entry credit address.
        ///</summary>
        internal const string entry_credit_balance = "entry-credit-balance";


        ///<summary>
        ///Retrieve details of a factoid transaction using a transaction’s hash (or corresponding transaction id). 
        ///</summary>
        internal const string transaction = "transaction";


        ///<summary>
        ///Return the keymr of the head of the chain for a chain ID (the unique hash created when the chain was created).
        ///</summary>
        internal const string chain_head = "chain-head";


        ///<summary>
        ///This call returns the number of Factoshis (Factoids *10^-8) that are currently available at the address specified.
        ///</summary>
        internal const string factoid_balance = "factoid-balance";


        ///<summary>
        ///Send a Chain Commit Message to factomd to create a new Chain. The commit chain has to be hex encoded string
        ///</summary>
        internal const string commit_chain = "commit-chain";



        ///<summary>
        ///Send an Entry Commit Message to factom to create a new Entry. The entry commit is hex encoded string
        ///</summary>
        internal const string commit_entry = "commit-entry";


        ///<summary>
        ///Reveal the First Entry in a Chain to factomd after the Commit to complete the Chain creation. The reveal-chain has to be hex encoded string
        ///</summary>
        internal const string reveal_chain = "reveal-chain";


        ///<summary>
        ///Reveal an Entry to factomd after the Commit to complete the Entry creation. The reveal-entry has to be hex encoded string
        ///</summary>
        internal const string reveal_entry = "reveal-entry";


        ///<summary>
        ///Retrieve a receipt providing cryptographically verifiable proof that information was recorded in the factom blockchain and that this was subsequently anchored in the bitcoin blockchain.
        ///</summary>
        internal const string receipt = "receipt";


        ///<summary>
        ///Get an Entry from factomd specified by the Entry Hash.
        ///</summary>
        internal const string entry = "entry";






    }
}//namespace
