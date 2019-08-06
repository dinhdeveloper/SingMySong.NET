using SingMySong.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class SongDTO
    {
        public int idSong { get; set; }
        public Category idCate { get; set; }
        public SubCategory idSubCate { get; set; }
        public mDAO.Type IdType { get; set; }
        public string songName { get; set; }
        public string singerName { get; set; }
        public string fileSong { get; set; }
    }
}