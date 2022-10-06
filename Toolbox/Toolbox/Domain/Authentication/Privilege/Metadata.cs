using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Domain
{
    public class Metadata
    {
        public int Id { get; set; }
        public string TableName { get; set; }        
        public ICollection<Privilege> Privileges { get; set; }
    }
}
