using SingMySong.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class SubCategoryDTO
    {
        public int idSubCategory { get; set; }
        public Category idCate { get; set; }
        public string subCateName { get; set; }
        public string subCateIMG { get; set; }
    }
}