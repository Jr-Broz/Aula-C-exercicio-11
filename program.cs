using System;

namespace ExercicioLista2 {
    internal class Program {
        static void Main(string[] args) {

            char car;
            int contVogal = 0;

            Console.WriteLine("Entre com um Caracter");
            car = char.Parse(Console.ReadLine());

            while (car != '.') {
                car = char.ToUpper(car);
                contVogal += car++;
                switch (car) {

                     case 'A':
                     case 'E':
                     case 'I':
                     case 'O':            
                      case 'U': 
                      break;  

                }

                Console.WriteLine("Entre com um Caracter");
                car = char.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Numero de vogais : " + contVogal);


        }
    }
}
