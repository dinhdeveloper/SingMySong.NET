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
    
    public partial class User
    {
        public int idUser { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public Nullable<bool> gender { get; set; }
    }
}