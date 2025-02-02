using System.Collections;

namespace Advanced_C__Sesssion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collections - HashTable

            //Hashtable Note = new Hashtable(10,.72f)
            //{
            //    ["Ahmed"] = 555,
            //    ["Mohamed"] = 666,
            //    ["Ali"] = 777
            //};

            //Note.Add("ahmed", 888);

            #region Add , Get , Set
            #region Add
            //// Add

            ////Unsafe Code
            //Note.Add("Ahmed", 888); // will throw an exception if the key is already exist

            ////Safe Code

            //if (!Note.ContainsKey("Ahmed"))
            //{
            //    Note.Add("Ahmed", 888);
            //} 
            #endregion

            #region Get
            ////Get
            //Console.WriteLine(Note["Ahmed"]);
            //Console.WriteLine(Note["Manar"] ?? "NA"); // will return NA if the key is not found 
            #endregion

            #region Set

            /*  Note["Yasmine"] = 222;*/ // may throw an exception if the key is not found

            // Safe Code

            //if (Note.ContainsKey("Yasmine"))
            //    Note["Yasmine"] = 222;

            #endregion 
            #endregion

            #region Loopin In HashTable
            //foreach(DictionaryEntry Person in Note)
            //{
            //    Console.WriteLine($"Name = {Person.Key} :::: Number = {Person.Value}");
            //} 
            #endregion




            #endregion


        }
    }
}
