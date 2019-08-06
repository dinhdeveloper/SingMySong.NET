using SingMySong.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class CommentDTO
    {
        public int idComment { get; set; }
        public User idUser { get; set; }
        public Song idSong { get; set; }
        public string comments { get; set; }
        public DateTime dateComment { get; set; }
    }
}