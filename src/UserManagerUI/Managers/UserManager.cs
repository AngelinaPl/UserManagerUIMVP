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
        throw new NotImplementedException();
    }

    public static void Add(User user)
    {
        throw new NotImplementedException();
    }

    public static void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public static List<User> GetAll()
    {
        return _users;
    }
}
