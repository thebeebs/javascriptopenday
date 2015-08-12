using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Thumb
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        //-1 for thumbs down, 0 for neutral 1 for thumbs up??
        public int Score { get; set; }

        public string Comments { get; set; }
    }
}
