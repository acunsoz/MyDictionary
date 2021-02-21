using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> islem = new MyDictionary<string, int>();
            islem.Add("Ali",12);
            islem.Add("Mehmet",13);
            islem.Add("Kerem", 16);
            islem.Add("Aslı", 17);

        }
        
    }
}
