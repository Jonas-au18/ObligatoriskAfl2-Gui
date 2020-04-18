using System.ComponentModel.DataAnnotations;

namespace Hotel_California.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public bool Adult
        {
            get
            {
                if (Age < 13)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public Room roomNr { get; set; }
    }
}