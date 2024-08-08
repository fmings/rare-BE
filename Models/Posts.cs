using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public string? ImageUrl { get; set; }
        public string? Content { get; set; }
        public bool Approved { get; set; }
        public Categories Category { get; set; }
        public Users User { get; set; }
    }
}
