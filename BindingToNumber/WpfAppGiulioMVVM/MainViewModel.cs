using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GiulioMVVM;

namespace WpfAppGiulioMVVM
{
    public class MainViewModel : ViewModelBase
    {
        void RunDouble(object par)
        {
            MyPropertyB = MyPropertyA * 2;
        }

        bool CanRunDouble(object par)
        {
            return MyPropertyA >= 0;
        }


        DelegateCommand doubleCmd;
        public ICommand DoubleCmd
        {
            get
            {
                if (doubleCmd is null)
                {
                    doubleCmd = new DelegateCommand(
                        par => RunDouble(par),
                        par => CanRunDouble(par)
                    );
                }
                return doubleCmd;
            }
        }

        private double myVarB;

        public double MyPropertyB
        {
            get { return myVarB; }
            set
            {
                myVarB = value;
                OnPropertyChanged();
            }
        }


        private double myVarA;
        public double MyPropertyA
        {
            get { return myVarA; }
            set
            {
                myVarA = value;
                OnPropertyChanged();
                doubleCmd.RaiseCanExecuteChanged();
            }
        }
    }
}
