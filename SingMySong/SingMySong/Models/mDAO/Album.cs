//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SingMySong.Models.mDAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public int idAlbum { get; set; }
        public Nullable<int> idCategory { get; set; }
        public Nullable<int> idSubCategory { get; set; }
        public string albumName { get; set; }
        public string albumIMG { get; set; }
    }
}
