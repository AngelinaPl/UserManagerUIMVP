using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UserManagerUI.Managers;

namespace UserManagerUI.ViewModels;

public class MainViewModel : BaseViewModel
{
    private UserViewModel _selectedUser;

    public ICommand SetSomeValueCommand { get; }

    public ObservableCollection<UserViewModel> Users { get; }

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
        SetSomeValueCommand = new RelayCommand(ExecuteSetSomeValue);
        var users = UserManager.GetAll();
        Users = new ObservableCollection<UserViewModel>(users.Select(_ => new UserViewModel
        {
            Age = _.Age,
            Id = _.Id,
            Surname = _.Surname,
            Name = _.Name,
        }));
    }

    #region SetSomeValueCommand

    private void ExecuteSetSomeValue()
    {
        //SomeValue = Guid.NewGuid().ToString();
    }

    #endregion
}
