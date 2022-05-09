using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class History
    {
        public string HistoryId { get; set; }
        public User User { get; set; }
        public Video Video { get; set; }
        public DateTime ModifiedAt { get; set; }

        public History(){
            ModifiedAt = DateTime.Now;            
        }
    }
}
