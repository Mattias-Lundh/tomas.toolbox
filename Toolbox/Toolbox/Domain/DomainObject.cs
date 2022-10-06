using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Toolbox.Domain;

namespace Toolbox.Domain
{
    public class DomainObject : IPrivileged
    {        
        public bool HasAccess(User user, AccessType accessType)
        {
            return Metadata.Privileges.FirstOrDefault(p => p.User == user && p.AccessType == accessType) != null;
        }
    }
}
