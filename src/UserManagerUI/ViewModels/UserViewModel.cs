using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using UserManagerUI.Managers;

namespace UserManagerUI.ViewModels;

public class UserViewModel : BaseViewModel
{
    private string _name;
    private string _surname;
    private int _id;
    private int _age;

    public string Name
    {
        get { return _name; }
        set 
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public string Surname
    {
        get { return _surname; }
        set
        {
            _surname = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public int Id
    {
        get { return _id; }
        set
        {
            _id = value;
            OnPropertyChanged(nameof(Id));
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
            OnPropertyChanged(nameof(Age));
        }
    }
    public ICommand UpdateCommand
    {
        get;
    }

    public ICommand DeleteUserCommand
    {
        get;
    }

    private void ExecuteUpdateCommand()
    {
        UserManager.Update(
            new Models.User
            {
                Name = Name,
                Surname = Surname,
                Id = Id,
                Age = Age
            });
    }
    public UserViewModel()
    {
        UpdateCommand = new RelayCommand(ExecuteUpdateCommand);
        DeleteUserCommand = new RelayCommand(ExecuteDeleteUser);
    }

    private void ExecuteDeleteUser()
    {
        UserManager.Delete(Id);
    }
}
