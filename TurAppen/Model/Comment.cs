using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurAppen.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public int WriterId { get; set; }
        public string Text { get; set; }
        public string Base64Image { get; set; }
    }
}
