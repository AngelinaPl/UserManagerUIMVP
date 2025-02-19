using System.Collections.Generic;
using UserManagerUI.Api.Models;

namespace UserManagerUI.Api.Services.Interfaces
{
    public interface IUserService
    {
        public User Create();

        public void Update(User user);

        public void Delete(int id);

        public List<User> GetAll();  
    }
}
