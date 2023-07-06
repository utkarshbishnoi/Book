using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book.BL
{
    public class CommentModel
    {
        public int Id { get; set; }
        public DateTime DateofCmnt { get; set; }
        [Display(Name ="Add Comment")]
        public string Comment { get; set; }
        public int EventId { get; set; }
    }
}
