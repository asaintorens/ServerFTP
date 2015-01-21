using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ServerFTP.ClasseMetier
{
    [Serializable]
    public class User
    {
        [XmlAttribute("username")]
        public string Username { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }

        [XmlAttribute("homedir")]
        public string HomeDir { get; set; }


        [XmlAttribute("rename")]
        public bool rename { get; set; }


        [XmlAttribute("delete")]
        public bool delete { get; set; }

        [XmlAttribute("upload")]
        public bool upload { get; set; }

        [XmlAttribute("download")]
        public bool download { get; set; }


        [XmlAttribute("directory")]
        public bool directory { get; set; }

    }

}
