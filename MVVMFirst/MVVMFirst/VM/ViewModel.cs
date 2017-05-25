using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMFirst.M;
using System.Windows;

namespace MVVMFirst.VM
{
    public class ViewModel : ObservableObject
    {
        //public Command przycisk;

        public ViewModel()
        {
            //przycisk = new Command(ObslugaPrzycisku);
            Copy kopia = new Copy();
        }
        
        private string _text1;
        public string Text1
        {
            get { return _text1; }
            set
            {
                if (_text1 != value)
                {
                    _text1 = value;
                    RaisePropertyChanged("tekst1");
                }
            }
        }

        private string _text2;
        public string Text2
        {
            get { return _text2; }
            set
            {
                if (_text2 != value)
                {
                    _text2 = value;
                    RaisePropertyChanged("tekst2");
                }
            }
        }

        public Command przycisk
        {
            get
            {
                return new Command(_ => ObslugaPrzycisku());
            }
        }

        public void ObslugaPrzycisku()
        {
            MessageBox.Show("dsdssd");
        }
    }
}
