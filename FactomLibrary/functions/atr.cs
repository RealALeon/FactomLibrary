namespace FactomLibrary.functions
{
    //******************************************************* compose Entry/Chain
    //*******************************************************
    //*******************************************************
    public class compose
    {
        public com commit { get; set; }
        public rev reveal { get; set; }

        public class com
        {
            public string jsonrpc { get; set; }
            public string id { get; set; }
            public string message { get; set; }
            public string method { get; set; }
        }
        public class rev
        {
            public string jsonrpc { get; set; }
            public string id { get; set; }
            public string entry { get; set; }
            public string method { get; set; }
        }
    }//class compose




}//namespace
