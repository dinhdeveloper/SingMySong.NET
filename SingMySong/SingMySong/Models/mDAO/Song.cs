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
    
    public partial class Song
    {
        public int idSong { get; set; }
        public Nullable<int> idCate { get; set; }
        public Nullable<int> idSubCate { get; set; }
        public Nullable<int> idType { get; set; }
        public string songName { get; set; }
        public string singerName { get; set; }
        public string fileSong { get; set; }
    }
}
