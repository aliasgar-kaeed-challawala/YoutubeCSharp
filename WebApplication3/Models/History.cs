using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string HistoryId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string VideoId { get; set; }
        public Video Video { get; set; }
        public DateTime ModifiedAt { get; set; }

        public History(){
            ModifiedAt = DateTime.Now;            
        }
    }
}
