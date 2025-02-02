using System.Collections;

namespace Advanced_C__Sesssion_4
{
    #region Class of Dictionary
    //class StringDiscComparer : IComparer<string>
    //{
    //    public int Compare(object x, object y)
    //    {
    //      return y?.CompareTo(x) ?? (x is null ? 0 : -1);
    //    }
    //} 
    #endregion

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

            #region Generic Collection - Dictionary[HashTable]

            //Dictionary<string, int> Note = new Dictionary<string, int>()
            //{
            //    ["Ahmed"] = 555,
            //    ["Omar"] = 666,
            //    ["Reem"] = 777
            //};

            #region Add, get , Set

            #region Add
            //// Unsafe Code
            //Note.Add("Jana", 888); //Key Must be Unique


            //// Safe Code
            //if (!Note.ContainsKey("Jana"))
            //{
            //    Note.Add("Jana", 888);
            //} 
            #endregion

            #region Get

            //// unsafe code
            //Console.WriteLine($"{Note["MAnar"]}"); // May throw an exception if the key is not found

            //// Safe Code
            //Console.WriteLine($"{Note["Manar"]}"); // will return NA if the key is not found
            #endregion

            #region Set

            //Note["Yasmine"] = 222; // may throw an exception if the key is not found
            #endregion
            #endregion

            #region foreach
            //foreach(var Name in Note.Keys)
            //{
            //    Console.WriteLine($"Name = {Name}");
            //}

            //foreach (var Number in Note.Values)
            //{
            //    Console.WriteLine($"Number = {Number}");
            //} 
            #endregion


            //foreach (var Person in Note)
            //    Console.WriteLine($"Name = {Person.Key} :::: Number = {Person.Value}");





            #endregion

            #region Generic Collection - Sorted Dictionary [Binary Search tree]

            #region Example 01
            //SortedDictionary<string, int> Note = new SortedDictionary<string, int>()
            //{
            //    ["Ahmed"] = 555,
            //    ["Omar"] = 666,
            //    ["Reem"] = 777,
            //    ["Ali"] = 888,
            //    ["Mohamed"] = 999
            //};

            //foreach (var Person in Note)
            //    Console.WriteLine($"Name = {Person.Key} :::: Number = {Person.Value}"); 
            #endregion
            #endregion

            #region Generic Collection - Sorted List [Two Arrays]

            //SortedList<string, int> SortedNote = new SortedList<string, int>()
            //{
            //    ["Ahmed"] = 555,
            //    ["Omar"] = 666,
            //    ["Reem"] = 777,
            //    ["Ali"] = 888,
            //    ["Mohamed"] = 999
            //};
            //Console.WriteLine(SortedNote.GetKeyAtIndex(0));
            //Console.WriteLine(SortedNote.GetValueAtIndex(0));

            //foreach (var Person in SortedNote)
            //    Console.WriteLine($"Name = {Person.Key} :::: Number = {Person.Value}");
            #endregion

            #region Generic Collection - Hashset

            #region Numbers Example
            //HashSet<int> Numbers = new HashSet<int>();
            //{
            //    Numbers.Add(1);
            //    Numbers.Add(2);
            //    Numbers.Add(3);
            //    Numbers.Add(2);
            //    Numbers.Add(4);
            //    Numbers.Add(5);
            //    Numbers.Add(5);

            //    foreach (var Number in Numbers)
            //        Console.WriteLine(Number);
            //}; 
            #endregion

            #region Movie Example
            //HashSet<Movie> movie = new HashSet<Movie>();

            //    movie.Add(new Movie { Code = 10, Title = "Titanic", Price = 100 });
            //    movie.Add(new Movie { Code = 20, Title = "Black Adam", Price = 200 });
            //    movie.Add(new Movie { Code = 20, Title = "Avatar", Price = 100 });
            //    movie.Add(new Movie { Code = 20, Title = "Avatar", Price = 100 });
            //    movie.Add(new Movie { Code = 20, Title = "Avatar", Price = 100 });
            //    movie.Add(new Movie { Code = 20, Title = "Avatar", Price = 100 });

            //    foreach (var Movie in movie)
            //    Console.WriteLine(Movie); 
            #endregion

            #region Example 04

            //HashSet<int> Set01 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            //HashSet<int> Set02 = new HashSet<int>() { 1,2,3,4,5,6,7,8,9,10 };

            //Set02.ExceptWith(Set01);
            //Set02.IntersectWith(Set01);
            //Set02.UnionWith(Set01);
            //Set02.SymmetricExceptWith(Set01);

            // Set01.IsSubsetOf(Set02); 

            //foreach (var Number in Set02)
            //    Console.WriteLine(Number);
            #endregion

        }


        #endregion

            #region Generic Collection - SortedSet [Balanced Binary Search Tree]

        //SortedSet<int> Numbers = new SortedSet<int>() { 9, 6, 4, 5, 15, 3 };

        //int min = Numbers.Min;
        //int max = Numbers.Max;

        //var subset = Numbers.GetViewBetween(4, 9);

        //foreach(var Number in Numbers)
        //    Console.WriteLine(Number);


        #endregion



    }
}

