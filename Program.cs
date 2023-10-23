using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Player player = new Player();

            Things thing = null;

            bool isProgrammWork = true;

            while (isProgrammWork)
            {
                string inputUser = "";

                Console.Clear();

                player.ShowInventory();

                ShowThing(thing);

                Console.WriteLine("Для создания вещи введите 1\n" +
            "Для добавления вещи в инвентарь введите 2\n" +
            "Для удаления вещи из инвенторя введите 3");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        thing = CreateThing();
                        break;
                    case "2":
                        player.AddItemToInventory(thing);
                        thing = null;
                        break;
                        case "3":
                        player.RemoveItemFromInventory();
                        break;
                }


            }



            player.ShowInventory();

            Console.ReadKey();
        }
        static void ShowThing(Things thing)
        {
            if (thing != null)
            {
                Console.WriteLine($"Созданная вещь : {thing.Name} Цвет -  {thing.Color}  Материал - {thing.Material} Вес - {thing.Weight}");
            }
            else
            {
                Console.WriteLine($"Вещь пока не создана");
            }
        }
        static void ShowMenu()
        {

        }
        static Things CreateThing()
        {
            string nameThing = "";

            string colorThing = "";

            string materialThing = "";

            int weightThing = 0;

            Console.WriteLine("Введите название вечи");

            EntryParameterThing(ref nameThing);

            Console.WriteLine("Введите цвет вещи");

            EntryParameterThing(ref colorThing);

            Console.WriteLine("Введите материал вещи");

            EntryParameterThing(ref materialThing);

            Console.WriteLine("Введите вес вещи");

            EntryParameterThing(ref weightThing);

            return new Things(nameThing, colorThing, materialThing, weightThing);
        }

        static string EntryParameterThing(ref string parameter)
        {
            return parameter = Console.ReadLine();
        }

        static int EntryParameterThing(ref int parameter)
        {
            return parameter = Convert.ToInt32(Console.ReadLine());
        }
    }
}
