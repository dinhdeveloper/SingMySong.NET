using SingMySong.Models.mDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingMySong.Models.mDTO
{
    public class FeedBackDTO
    {
        public int idFeedBack { get; set; }
        public RateDTO idRate { get; set; }
        public User idUser { get; set; }
        public string nameFB { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string question { get; set; }
        public DateTime dateFeedback { get; set; }
    }
}