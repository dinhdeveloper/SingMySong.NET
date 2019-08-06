using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class UserDTO
    {
        public int idUser { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public bool gender { get; set; }
    }
}