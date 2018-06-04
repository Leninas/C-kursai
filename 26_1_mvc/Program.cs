using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_1_mvc
{
    public interface IModel
    {
        void SetAdapter(IModelAdapter a);
        object M(object input);
    }

    public interface IModelAdapter
    {
        void V();
    }

    public interface IView
    {
        void SetAdapter(IViewAdapter a);
        void V();
    }

    public interface IViewAdapter
    {
        object M(object input);
    }


    public delegate IModel ModelFactory();
    public delegate IView ViewFactory();


    public class Model : IModel
    {
        private IModelAdapter _a;

        public void SetAdapter(IModelAdapter a)
        {
            _a = a;
        }
        public object M(object input)
        {
            string name = (string)input;
            name = "$" + name + "$";
            return name;
        }
    }

    public class View : IView
    {
        private IViewAdapter _a;

        public void SetAdapter(IViewAdapter a)
        {
            _a = a;
        }
        public void V()
        {

            Console.Write("Koks jūsų vardas? ");
            string input = Console.ReadLine();
            if (input.Length < 1)
            {
                Console.WriteLine("Iveskite varda.");
                throw new Exception("ERROR - Nera vardo.");
            }

            input = (string)_a.M(input);

            Console.WriteLine(input);
        }
    }


    public class Controller : IModelAdapter, IViewAdapter
    {
        private IModel _model;
        private IView _view;
        public Controller(ModelFactory mf, ViewFactory vf)
        {
            _model = mf();
            _view = vf();
            _model.SetAdapter(this);
            _view.SetAdapter(this);
        }

        public void V()
        {
            _view.V();
        }

        public object M(object input)
        {
            return _model.M(input);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Controller c = null;

            c = new Controller(MyDollarSignModelFactory, MyViewFactory);
            DoWork(c);
            Console.ReadKey();
        }

        public static void DoWork(Controller c)
        {
            try
            {
                c.V();
            }
            catch (Exception ex)
            {
                DoWork(c);
            }
        }

        public static IModel MyDollarSignModelFactory()
        {
            return new Model();
        }
        public static IView MyViewFactory()
        {
            return new View();

        }
    }
}
