using System;
using System.Collections.Generic;
using System.Linq;
using UserManagerUI.Api.Models;
using UserManagerUI.Api.Services.Interfaces;

namespace UserManagerUI.Api.Services
{
    public class UserService : IUserService
    {
        private static List<User> _users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Jack",
                Surname = "Miller",
                Age = 30
            },
            new User()
            {
                Id = 2,
                Name = "Jane",
                Surname = "Miller",
                Age = 29
            },
            new User()
            {
                Id = 3,
                Name = "Kate",
                Surname = "Fisher",
                Age = 45
            },
            new User()
            {
                Id = 4,
                Name = "Mike",
                Surname = "Fisher",
                Age = 38
            },
        };

        public User Create()
        {
            var idForNewUser = _users.Max(x => x.Id) + 1;
            var newUser = new User
            {
                Id = idForNewUser,
                Age = default,
                Name = default,
                Surname = default
            };
            _users.Add(newUser);
            return newUser;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
