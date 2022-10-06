using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Domain
{
    public class Privilege
    {
        public int Id { get; set; }
        public User User { get; set; }
        public AccessType AccessType { get; set; }
    }
}
