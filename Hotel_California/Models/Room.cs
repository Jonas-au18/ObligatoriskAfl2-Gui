using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_California.Models
{
    public class Room
    {
        [Key]
        public int RoomNr { get; set; }
        public List<Guest> Guest { get; set; }
        public bool Occupied { get; set; }
    }
}