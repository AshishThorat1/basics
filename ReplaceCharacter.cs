using System;

namespace ReplaceCharacters
{
    class ReplaceCharacter
    {
        static void Main(string[] args)
        {
            string str;
            str = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("string before change - {0}", str);
            str = str.Replace('f', 'F');
            Console.WriteLine("string after replaceing 'f' with 'F' is - {0}", str);
            Console.ReadKey();
        }
    }
}
