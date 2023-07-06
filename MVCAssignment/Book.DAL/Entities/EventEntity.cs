using Book.DAL.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Book.DAL.Entities
{
    public class EventEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public DateTime StartTime { get; set; }

        public EnumType Type { get; set; }

        public int? Duration { get; set; }

        public string Description { get; set; }

        public string OtherDetails { get; set; }
        
        public string Invites { get; set; }

        public string CreatedBy { get; set; }
    }
}
