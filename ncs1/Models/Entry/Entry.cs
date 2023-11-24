using System.ComponentModel.DataAnnotations;

namespace ncs1.Models.Entry
{
    public class Entry
    {
        [Key]
        public Guid EntryId { get; set; }

        public string? EntrySerial { get; set; } = "SD/CMD/ST/DDMMYY/045";

        public Guid? EntryUser { get; set; } 

        public long? EntryTime { get; set; } = DateTimeOffset.Now.ToUnixTimeSeconds();

        public string? EntryDetails { get; set; }

        public Guid? EntryCategory { get; set; }


        public Guid? EntryReference { get; set; }




    }
}
