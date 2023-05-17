using System; 

 

namespace PZ1 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            //Введення значення X 

            double X = 0; 

            Console.Write("Введiть значення X: "); 

            var chars = Console.ReadLine(); 

            bool isNumber = double.TryParse(chars, out X); 

            //Перевірка правильності введених данних  

            while (!isNumber) 

            { 

                Console.WriteLine("Ви помилились, введiть число!"); 

                chars = Console.ReadLine(); 

                isNumber = double.TryParse(chars, out X); 

            } 

 

            //Обрання способу обрахування Y залежно від введених користувачем даних 

            double Y; 

            if (X <= 0) 

            { 

                Y = ((Math.Pow(X+8, 2)) / 4) ; 

            } 

            else if (X < 15) 

            { 

                double sum = 0; 

                for (int i = 1; i <= X; i++) 

                { 

                    sum += ((i + 1) / 2); 

                } 

                Y =  sum; 

 

            } 

            else 

            { 

                double prod = 1; 

                for (int i = 15; i <= X; i++) 

                { 

                    prod *= Math.Pow(i + 4, 3 / 2); 

                } 

                Y = 10 + prod; 

 

            } 

             

            //Виведення Y 

            Console.WriteLine("Y = " + Y); 

        } 

    } 

} 
