using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book.DAL.Entities
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public DateTime DateofCmnt { get; set; }
        public string Comment { get; set; }
        public int EventId { get; set; }
    }
}
