using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AsyncFirst
{
    public class MainWindowViewModel
    {
        private ICommand hiButtonCommand;
        private bool canExecute = true;


        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => canExecute);
        }
        public string ButtonContent => "Click me.";
        public string HiButtonContent => "Hoi.";

        public bool CanExecute
        {
            get => canExecute;

            set
            {
                if (canExecute == value)
                {
                    return;
                }

                canExecute = value;
            }
        }

        public ICommand HiButtonCommand
        {
            get => hiButtonCommand;
            set => hiButtonCommand = value;
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }


    }
}
