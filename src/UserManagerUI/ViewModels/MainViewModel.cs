﻿using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UserManagerUI.Managers;

namespace UserManagerUI.ViewModels;

public class MainViewModel : BaseViewModel
{
    private UserViewModel _selectedUser;

    public ICommand RefreshCommand { get; }

    public ICommand AddCommand { get; }

    public ObservableCollection<UserViewModel> Users { get; private set; }

    public UserViewModel SelectedUser
    {
        get
        {
            return _selectedUser;
        }
        set
        {
            _selectedUser = value;
            OnPropertyChanged(nameof(SelectedUser));
        }
    }

    public MainViewModel()
    {
        RefreshCommand = new RelayCommand(Refresh);
      //  var users = UserManager.GetAll();
        Users = new ObservableCollection<UserViewModel>();
        AddCommand = new RelayCommand(ExecuteAdd);

    }

    #region Refresh

    private async void Refresh()
    {
        Users.Clear();
        var users = await UserManager.GetAll();
        foreach (var user in users)
        {
            Users.Add(new UserViewModel
            {
                Age = user.Age,
                Id = user.Id,
                Surname = user.Surname,
                Name = user.Name,
            }
                );
        }

        #endregion
    }

    private void ExecuteAdd()
    {
        UserManager.Create();
    }
}
