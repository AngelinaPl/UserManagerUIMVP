using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UserManagerUI.Models;

namespace UserManagerUI.Managers;

public static class UserManager
{



    public static void Update(User user)
    {
      //  var foundItem = _users.FirstOrDefault(_ => _.Id == user.Id);
        //foundItem.Name = user.Name;
        //foundItem.Surname = user.Surname;
        //foundItem.Age = user.Age;
    }

    public async static Task<User> Create()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "http://localhost:5000/User/Create";

            //var user = new
            //{
            //    Name = "John",
            //    Surname = "Doe",
            //    Age = 30,
            //    Id = 7
            //};
            //string jsonData = JsonConvert.SerializeObject(user);

            //StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                //HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    // Читаем тело ответа
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var user = JsonConvert.DeserializeObject<User>(responseBody);
                    return user;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    public static void Delete(int id)
    {
        //var userToRemove = _users.FirstOrDefault(_ => _.Id == id);
        //_users.Remove(userToRemove);
    }

    public async static Task<User[]> GetAll()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "http://localhost:5000/User/Get-All";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Читаем тело ответа
                    string responseBody = await response.Content.ReadAsStringAsync();

                    var user = JsonConvert.DeserializeObject<User[]>(responseBody);
                    return user;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}
