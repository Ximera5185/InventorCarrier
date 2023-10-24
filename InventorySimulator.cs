using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorCarrier
{
    static class InventorySimulator
    {
        static public void StartProgram() 
        {
            const string CreateThingMenu = "1";
            const string AddThingToInventoryMenu = "2";
            const string RemoveThingFromInventoryMenu = "3";
            const string ProgrammExitMenu = "4";

            Player player = new Player();

            Things thing = null;

            bool isProgrammWork = true;

            while (isProgrammWork)
            {
                string inputUser = "";

                Console.Clear();

                player.ShowInventory();

                ShowThing(thing);

                Console.WriteLine($"Для создания вещи введите {CreateThingMenu}\n" +
            $"Для добавления вещи в инвентарь введите {AddThingToInventoryMenu}\n" +
            $"Для удаления вещи из инвенторя введите {RemoveThingFromInventoryMenu}\n" +
            $"Для выхода из программы введите {ProgrammExitMenu}");

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CreateThingMenu:
                        thing = CreateThing();
                        break;
                    case AddThingToInventoryMenu:
                        player.AddItemToInventory(thing);
                        thing = null;
                        break;
                    case RemoveThingFromInventoryMenu:
                        player.RemoveItemFromInventory();
                        break;
                    case ProgrammExitMenu:
                        isProgrammWork = false;
                        break;
                }
            }
        }

        static private void ShowThing(Things thing)
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

        static private Things CreateThing()
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

        static private string EntryParameterThing(ref string parameter)
        {
            return parameter = Console.ReadLine();
        }

        static private int EntryParameterThing(ref int parameter)
        {
            return parameter = Convert.ToInt32(Console.ReadLine());
        }
    }
}
