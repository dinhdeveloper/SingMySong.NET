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
    
    public partial class FeedBack
    {
        public int idFeedBack { get; set; }
        public Nullable<int> idRate { get; set; }
        public Nullable<int> idUser { get; set; }
        public string nameFB { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string question { get; set; }
        public Nullable<System.DateTime> dateFeedback { get; set; }
    }
}
