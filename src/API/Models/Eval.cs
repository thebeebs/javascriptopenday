using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Eval
    {
        public int Id { get; set; }

        public string SessionTitle { get; set; }

        public string SpeakerName { get; set; }

        public int Stars { get; set; }

        public string Comments { get; set; }
    }
}
