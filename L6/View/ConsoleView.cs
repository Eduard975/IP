using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    public class ConsoleView : IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private List<Menus.MenuOption> _menuOptions;

        public ConsoleView(IModel model)
        {
            _model = model;
        }

        public void Display(string text, string color, bool withNewLine = true)
        {
            ConsoleColor c = ConsoleColor.DarkGray;

            switch (color)
            {
                case "default": c = ConsoleColor.White; break;
                case "red": c = ConsoleColor.Red; break;
                case "green": c = ConsoleColor.Green; break;
                case "blue": c = ConsoleColor.Blue; break;
                case "yellow": c = ConsoleColor.Yellow; break;
                case "magenta": c = ConsoleColor.Magenta; break;
            }

            Console.ForegroundColor = c;
            if(withNewLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
        }

        public void SetPresenter(IPresenter presenter) 
        {
            _presenter = presenter;
            _presenter.Init();
        }


        private Menus.UserChoice GetMenuOption(Menus.MenuState menuType)
        {
            string action = "";

            switch (menuType)
            {
                case Menus.MenuState.Main:
                    Menus.MainMenu(out _menuOptions, out action);
                    break;

                case Menus.MenuState.Administrator:
                    Menus.AdminMenu(out _menuOptions, out action);
                    break;

                case Menus.MenuState.User:
                    Menus.UserMenu(out _menuOptions, out action);
                    break;
            }

            Menus.UserChoice choice = Menus.UserChoice.Undefined;

            while (choice == Menus.UserChoice.Undefined)
            {
                Display(action + Environment.NewLine, "yellow");

                for (int i = 0; i < _menuOptions.Count; i++)
                    Display(_menuOptions[i].Number + ". " + _menuOptions[i].Text, "default");

                Console.Write(Environment.NewLine + "Optiunea dumneavoastra: ");
                string userChoiceNumber = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < _menuOptions.Count; i++)
                {
                    if (userChoiceNumber == _menuOptions[i].Number)
                    {
                        choice = _menuOptions[i].Choice;
                        break;
                    }
                }
            }

            return choice;
        }

        private void GetTwoCities(out string cityName1, out string cityName2) 
        {
            cityName1 = GetCity();
            cityName2 = GetCity();
        }

        private string GetCity()
        {
            Display("Introduceti orasul: ", "default", false);
            string cityName =  Console.ReadLine();

            while (!_presenter.CityExists(cityName))
            {
                Display("Introduceti orasul: ", "default", false);
                cityName = Console.ReadLine();
            }
            Console.Write(Environment.NewLine);
            return cityName;
        }

        private City InputCity()
        {
            string name;
            double lat, lon;
            Display("Nume: ", "default", false);
            name = Console.ReadLine();

            Display("Latitudine: ", "default", false);
            lat = Convert.ToDouble(Console.ReadLine());

            Display("Longitudine: ", "default", false);
            lon = Convert.ToDouble(Console.ReadLine());

            Console.Write(Environment.NewLine);
            return new City(name, lat, lon);

        }

        private void ListAll()
        {
            Display($"Orase: {_model.ListAll()}", "green");
            Console.Write(Environment.NewLine);
        }

        private void RemoveCity(string cityName1) 
        {
            _presenter.RemoveCity(cityName1);

        }

        public void Start()
        {
            Menus.UserChoice choice = Menus.UserChoice.Undefined;
            Menus.MenuState menuState = Menus.MenuState.Main;

            while (choice != Menus.UserChoice.Exit)
            {
                // preia comanda in functie de starea curenta a meniului

                choice = GetMenuOption(menuState);

                switch (choice)
                {
                    // comenzi

                    case Menus.UserChoice.Route:
                        string cn1, cn2;
                        GetTwoCities(out cn1, out cn2);
                        _presenter.ComputeRoute(cn1, cn2);
                        break;

                    case Menus.UserChoice.RemoveCity:
                        string cityName = GetCity();
                        RemoveCity(cityName);
                        break;

                    case Menus.UserChoice.AddCity:
                        City c = InputCity();
                        _presenter.AddCity(c);
                        break;

                    case Menus.UserChoice.List:
                        ListAll();
                        break;

                    case Menus.UserChoice.Exit:
                        _presenter.Exit();
                        break;

                    // navigare meniuri

                    case Menus.UserChoice.AdminMenu:
                        menuState = Menus.MenuState.Administrator;
                        break;

                    case Menus.UserChoice.UserMenu:
                        menuState = Menus.MenuState.User;
                        break;

                    case Menus.UserChoice.PreviousMenu:
                        menuState = Menus.MenuState.Main;
                        break;
                }
            }
        }

    }
}
