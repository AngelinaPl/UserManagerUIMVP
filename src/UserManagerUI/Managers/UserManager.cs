using UserManagerUI.Models;

namespace UserManagerUI.Managers;

public static class UserManager
{
    private static List<User> _users = new List<User>()
    {
        new()
            {
                Id = 1,
                Name = "Jack",
                Surname = "Miller",
                Age = 30
            },
            new ()
            {
                Id = 2,
                Name = "Jane",
                Surname = "Miller",
                Age = 29
            },
            new ()
            {
                Id = 3,
                Name = "Kate",
                Surname = "Fisher",
                Age = 45
            },
            new ()
            {
                Id = 4,
                Name = "Mike",
                Surname = "Fisher",
                Age = 38
            },
    };


    public static void Update(User user)
    {
        var foundItem = _users.FirstOrDefault(_ => _.Id == user.Id);
        foundItem.Name = user.Name;
        foundItem.Surname = user.Surname;
        foundItem.Age = user.Age;
    }

    public static void Add(User user)
    {
        throw new NotImplementedException();
    }

    public static void Delete(int id)
    {
        var userToRemove = _users.FirstOrDefault(_ => _.Id == id);
        _users.Remove(userToRemove);
    }

    public static List<User> GetAll()
    {
        return _users;
    }

}
