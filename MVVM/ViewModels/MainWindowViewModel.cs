using Simple_To_Do_List.Commands;
using Simple_To_Do_List.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Simple_To_Do_List.MVVM.ViewModels;
public class MainWindowViewModel
{
    public ObservableCollection<List> Lists;
    public ICommand AddNewCommand { get; set; }

    public MainWindowViewModel()
    {
        AddNewCommand = new RelayCommand(AddNew, CanAddNew);
    }

    private bool CanAddNew(object obj)
    {
        return true;
    }

    private void AddNew(object obj)
    {
        AddNew addNew = new AddNew();
        addNew.Show();
    }
}
