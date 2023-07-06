using System;
using System.ComponentModel.DataAnnotations;

namespace Book.BL
{
    public class ReadingEvent
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        public EnumType Type { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string Invites { get; set; }
        public string CreatedBy { get; set; }

    }
}
