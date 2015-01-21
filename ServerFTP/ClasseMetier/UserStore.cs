using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace ServerFTP.ClasseMetier
{
    // TODO: Implement a real user store.
    [Obsolete]
    public static class UserStore
    {
        public static List<User> _users;
        public static string PATH_XML = "./ressources/XMLFileClient.xml";

        static UserStore()
        {
            _users = new List<User>();

            XmlSerializer serializer = new XmlSerializer(_users.GetType(),new  XmlRootAttribute("User"));

            if (File.Exists(PATH_XML))
            {
                using (StreamReader stream = new StreamReader(PATH_XML))
                    _users = serializer.Deserialize(stream) as List<User>;
            }
            else
            {
                throw new Exception("Fichier XML clients introuvable");
            }
        }

        public static User Validate(string username, string password)
        {
            User user = (from u in _users where u.Username == username && u.Password == password select u).SingleOrDefault();

            return user;
        }



        public static User GetUser(string username)
        {
            User user = (from x in _users where x.Username == username select x).Single();
            return user;
        }

        public static void Update(List<User> users)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using (var stream = File.OpenWrite(PATH_XML))
            {
                serializer.Serialize(stream, users);
            }
        }
    }

    public enum UserStoreColumn
    {
        username,
        password,
        download,
        upload,
        delete,
        rename,
        directory
    }
}
