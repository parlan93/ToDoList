﻿using System;
using System.Windows.Input;

namespace ToDoList.ViewModels
{
    public class RelayCommand : ICommand
    {
        private Action Action;
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action)
        {
            Action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Action();
        }
    }
}
