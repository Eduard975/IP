using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public class Menus
    {
        public enum UserChoice { AdminMenu, UserMenu, PreviousMenu, Route, AddCity, RemoveCity, Exit, List, Undefined };

        public enum MenuState { Main, Administrator, User };

        public struct MenuOption
        {
            // structura pentru construirea dinamica a unui meniu
            // reprezinta o optiune intr-un meniu

            public readonly string Number;
            public readonly string Text;
            public readonly UserChoice Choice;

            public MenuOption(string number, string text, UserChoice choice)
            {
                Number = number;
                Text = text;
                Choice = choice;
            }
        }

        public static void MainMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati rolul";
            options = new List<MenuOption>
            {
                new MenuOption("1", "Utilizator", UserChoice.UserMenu),
                new MenuOption("2", "Administrator", UserChoice.AdminMenu),
                new MenuOption("3", "Iesire", UserChoice.Exit)
            };
        }


        public static void AdminMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita: ";
            options = new List<MenuOption>
            {
                new MenuOption("1", "Afisarea tuturor oraselor", UserChoice.List),
                new MenuOption("2", "Introducere oras nou", UserChoice.AddCity),
                new MenuOption("3", "Stergere oras", UserChoice.RemoveCity),
                new MenuOption("4", "Intoarcere meniu principal", UserChoice.PreviousMenu),
                new MenuOption("5", "Iesire", UserChoice.Exit)
            };
        }


        public static void UserMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita: ";
            options = new List<MenuOption>
            {
                new MenuOption("1", "informatii despre o ruta", UserChoice.Route),
                new MenuOption("2", "Afisarea tuturor oraselor", UserChoice.List),
                new MenuOption("3", "Intoarcere meniu principal", UserChoice.PreviousMenu),
                new MenuOption("4", "Iesire", UserChoice.Exit)
            };
        }
    }
}
