using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hello {
        public delegate void AskForTheWayHandler(object lostMan, AskForTheWayEventArgs e);
        public event AskForTheWayHandler AskForTheWay;
        object _theWay;
        public object theWay {
            set
            {
                _theWay = value;
                OnAskForTheWay();
            }
        }
        protected void OnAskForTheWay()
        { 

            AskForTheWay(this, new AskForTheWayEventArgs(_theWay));
        }

    }
    public class AskForTheWayEventArgs : EventArgs
    {
        private object _theWay;
        public AskForTheWayEventArgs(object theWay)
        {
            _theWay = theWay;

        }
        public object TheWay
        {
            get{
                return _theWay;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adv");
            Hello s = new Hello();
            s.AskForTheWay += new Hello.AskForTheWayHandler(s_AskForTheWay);
            s.theWay = "dat way";
            s.theWay = "the other way";
            while (1==1)
            {

            }

        }
        static void s_AskForTheWay(object sender,AskForTheWayEventArgs e) {
            Console.WriteLine("the way is {0}",e.TheWay);
        }
    }
}
