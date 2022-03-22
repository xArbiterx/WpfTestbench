using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfTestBench.Views;

namespace WpfTestBench.ViewModels
{
    public class MWViewModel
    {

        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (_clickCommand == null)
                {
                    _clickCommand = new Clicker();
                }
                return _clickCommand;
            }
            set { _clickCommand = value; }
        }

        private class Clicker : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                //var result = MessageBox.Show("msg", "cap", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning, MessageBoxResult.Yes);
                Window1 w1 = new Window1
                {
                    DataContext = new W1ViewModel()
                    {
                        Address = parameter.ToString()
                    }
                };
                w1.Show();
            }

            #endregion
        }
    }
}
