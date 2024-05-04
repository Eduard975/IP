using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TransportInfo
{
    public class Presenter : IPresenter
    {
        private IModel _model;
        private IView _view;
        public Presenter(IView view, IModel model) 
        {
            _model = model;
            _view = view;
        }

        public void AddCity(City c1) 
        {
            _model.Add(c1);
        }

        public void RemoveCity(string name) 
        {
             _model.Delete(name);
        }

        public bool CityExists(string name) 
        {
            return _model.Exists(name);
        }

        public void ComputeRoute(string city1, string city2) 
        {
            double distance = Math.Round(Calculator.Distance(_model.Search(city1), _model.Search(city2)));
            double cost = Math.Round(Calculator.Cost(distance));
            string text = $"\nDistanta de la {city1} pana la {city2} este {distance} km.\nDrumul va costa {cost} lei.\n";
            _view.Display(text, "green");
        }

        public City GetCity(string name) 
        {
            return _model.Search(name);
        }

        public void Init()
        {
            _view.Display("Arhitectura Model-View-Presenter", "default");
            _view.Display("Ingineria programarii, Laboratorul 6", "default");
            _view.Display("============================================\r\n", "default");

            if (!_model.DataExists())
            {
                _view.Display("Fisierul cu orase nu exista.\r\n", "red");
            }
            else
            {
                _model.InitializeData();
                _view.Display($"Fisier incarcat: {_model.CityCount} orase.\r\n", "magenta");
            }
        }


        public void Exit()
        {
            if (_model.SaveData())
                _view.Display("Fisierul a fost salvat.\r\n", "magenta");
            _view.Display("La revedere.", "default");
            ///Application.DoEvents();
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

    }
}
