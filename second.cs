using System; 

using System.Linq; 

  

namespace laba5 

{ 

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            string word1 = "банан"; 

            string word2 = "кавун"; 

            string result = ""; 

  

            for (int i = 0; i < word1.Length; i++) 

            { 

                if (word2.Contains(word1[i])) 

                { 

                    result += word1[i] + " входить в друге слово\n"; 

                } 

                else 

                { 

                    result += word1[i] + " не входить в друге слово\n"; 

                } 

            } 

  

            Console.WriteLine(result); 

        } 

    } 

} 
