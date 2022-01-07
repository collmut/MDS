/*
    The main library file 

*/


namespace Mds
{
    public class Ucont
    {
        // Ucont attributes 
        private string Data = "";                        
        private int Size = 0;                           // number of elements - 1.
        UcontMode Mode = UcontMode.list;


        //

        // Ucont constants / enumerations
        enum UcontMode
        {
            list,                                   // the default mode of the datastructure.
            singletype,
            graph
        }


        //

        // Ucont methods 
        public void AddElement(string element)
        {
            Data = $"{Data}{element},";
        }

        public void GetElement(int index)
        {

        }

        public void ReplaceElement(int index)
        {

        }

        public bool Contains()
        {
            return false;
        }

        public string GetRawData()
        {
            // gets the data stored inform of string in the 
            return Data;
        }
    }
}