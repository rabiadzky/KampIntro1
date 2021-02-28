using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> myDictionary = new MyDict<int, string>();
            myDictionary.Add(1, "Ayşe");
            myDictionary.Add(2, "Rabia");
            myDictionary.Add(3, "Selin");
            myDictionary.DictionaryList();
        }
    }
}
