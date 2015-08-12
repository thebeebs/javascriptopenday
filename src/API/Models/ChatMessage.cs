using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public int ParentThreadId { get; set; }
    }
}
