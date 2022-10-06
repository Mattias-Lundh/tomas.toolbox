using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Domain
{
    public interface IPrivileged
    {
        bool HasAccess(User user, AccessType accessType);
    }
}
