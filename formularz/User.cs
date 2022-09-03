using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formularz
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public bool SprawdzLogowanie(User logData)
        {
            bool isOk = true;
            if (this.Name != logData.Name)
                return false;
            if (this.LastName != logData.LastName)
                return false;
            if (this.Password != logData.Password)
                return false;

            return isOk;

        }
        public User FillUser(string dane)
        {
            User u = new User();
            var dane2 = dane.Split(';');
            u.Name = dane2[0];
            u.LastName = dane2[1].Trim(' ');
                u.Password = dane2[2].Trim(' ');
            return u;
        }
        public void Dodaj(string Path)
        {
            File.AppendAllText(Path, $"{Name}; {LastName}; {Password};\r\n");
        }
    }
}
