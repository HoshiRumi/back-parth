using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eDomain.mModels.mUser;

namespace eMiSide.BusinessLogic.mInterfaces
{
    public interface IAuthActions
    {
        string LoginActionFlow(UserAuthAction data);
        string RegisterActionFlow(UserAuthAction data);
    }
}
