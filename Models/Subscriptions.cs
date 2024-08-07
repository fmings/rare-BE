using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models;

public class Subscriptions
{
    public int Id { get; set; }
    public int FollowerId { get; set; }
    public int AuthorId { get; set; }
    public DateTime CreatedOn { get; set; }
}
