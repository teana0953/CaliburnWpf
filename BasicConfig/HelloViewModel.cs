using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicConfig
{
    public class HelloViewModel:PropertyChangedBase,IShell
    {
        //private string name;
        //public string Name {
        //    get { return name; }
        //    set {
        //        name = value;
        //        NotifyOfPropertyChange(()=>Name);
        //        NotifyOfPropertyChange(()=>CanSayHello);
        //    }
        //}
        //public bool CanSayHello { get { return !string.IsNullOrWhiteSpace(name); } }

        public bool CanSayHello(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public void SayHello(string name)
        {
            MessageBox.Show($"Hello {name}!");
        }

        public void Talk(string msg,string name)
        {
            MessageBox.Show($"{msg} {name}!");
        }
    }
}
