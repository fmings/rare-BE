using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Label {  get; set; }
        public Posts Posts { get; set; }
    }
}
