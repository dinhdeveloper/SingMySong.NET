using SingMySong.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class AlbumDTO
    {
        public int idAlbum { get; set; }
        public Category idCategory { get; set; }
        public SubCategory idSubCategory { get; set; }
        public string albumName { get; set; }
        public string albumIMG { get; set; }
    }
}