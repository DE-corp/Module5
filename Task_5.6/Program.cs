using System;

namespace Task_5._6
{
    class Program
    {
        static string[] GetPetName(int PetCount)
        {
            var Pets = new string[PetCount];

            for(var i = 0; i < PetCount; i++)
            {
                Console.Write($"Введите кличку {i + 1}го питомца: ");
                Pets[i] = Console.ReadLine();
            }
            return Pets;
        }

        static string[] GetFavColors(int FavColorsCount)
        {
            var FavColors = new string[FavColorsCount];

            for (var i = 0; i < FavColorsCount; i++)
            {
                Console.Write($"Введите любимый цвет №{i + 1}: ");
                FavColors[i] = Console.ReadLine();
            }
            return FavColors;
        }

        static int IntInput ()
        {
        
            while(true){
                var is_int = int.TryParse(Console.ReadLine(), out int count);
                if (is_int && count != 0)
                    return count;
                else
                    Console.Write("Надо ввести число больше 0: ");
            }
        }
        static (string, string, int, bool, string[], int, string[]) GetDataFromConsole()
        {
            Console.Write("Введите имя: ");
            var Name = Console.ReadLine();
            
            Console.Write("Введите фамилию: ");
            var Lastname = Console.ReadLine();
           
            Console.Write("Введите возраст: ");
            var Age = IntInput();
            
            Console.Write("У вас есть домашний питомец (y/n): ");
            var HasPet = false;
            var PetName = Array.Empty<string>();
            if (Console.ReadLine() == "y")
            {
                HasPet = true;
                Console.Write("Сколько у вас питомцев: ");
                PetName = GetPetName(IntInput());
                
            }

            Console.Write("Сколько у вас любимых цветов: ");
            var FavColorCount = IntInput();
            var FavColor = GetFavColors(FavColorCount);


            return (Name, Lastname, Age, HasPet, PetName, FavColorCount, FavColor);
        }

        static void Show((string Name, string Lastname, int Age, bool HasPet, string[] PetName, int FavColorCount, string[] FavColor) Person)
        {
            Console.Clear();
            Console.WriteLine($"[АНКЕТА]: {Person.Name} {Person.Lastname}, {Person.Age}\n");

            if (Person.HasPet)
            {
                Console.WriteLine("Ваши питомцы: ");
                foreach(var pet in Person.PetName)
                {
                    Console.WriteLine($"\t- {pet}");
                }
            }

            if (Person.FavColorCount != 0)
            {
                Console.WriteLine("Любимые цвета: ");
                foreach (var color in Person.FavColor)
                {
                    Console.WriteLine($"\t- {color}");
                }
            }
        }
        static void Loader()
        {
            for (var i = 0; i < 50; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            Show(GetDataFromConsole());
            Console.ReadLine();
        }

        
    }
}
