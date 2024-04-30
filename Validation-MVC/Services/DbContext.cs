using Validation_MVC.Models;

namespace Validation_MVC.Services;

public class DbContext
{
    public static List<User> Users = new List<User>()
    {
        new User(){Id = Guid.NewGuid() ,FullName = "Siya", Email = "siya@gmail.com", Password = "qwerty123", Username = "jsiya"},
        new User(){Id = Guid.NewGuid() ,FullName = "Hesen", Email = "hesen@gmail.com", Password = "qwerty123", Username = "hesen"},
        new User(){Id = Guid.NewGuid() ,FullName = "Kamal", Email = "kamal@gmail.com", Password = "qwerty123", Username = "kamal12"},
        new User(){Id = Guid.NewGuid() ,FullName = "Elgun", Email = "elgun@gmail.com", Password = "qwerty123", Username = "elgun"},
        new User(){Id = Guid.NewGuid() ,FullName = "Nihad", Email = "nihad@gmail.com", Password = "qwerty123", Username = "nihad"},
        new User(){Id = Guid.NewGuid() ,FullName = "Amin", Email = "amin@gmail.com", Password = "qwerty123", Username = "amin"},
        new User(){Id = Guid.NewGuid() ,FullName = "Rustem", Email = "rustem@gmail.com", Password = "qwerty123", Username = "rustem"},

    };
}