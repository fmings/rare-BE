using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models
{
    public class PostTags
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
        
    }
}
