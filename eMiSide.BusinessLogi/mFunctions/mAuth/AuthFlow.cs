using eDomain.mModels.mUser;
using eMiSide.BusinessLogic.Core.Auth;
using eMiSide.BusinessLogic.mInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiSide.BusinessLogic.Functions.Auth
{
    public class AuthFlow : IAuthActions
    {
        private readonly AuthActions _actions = new();

        public string LoginActionFlow(UserAuthAction data) =>
            _actions.Login(data);

        public string RegisterActionFlow(UserAuthAction data) =>
            _actions.Register(data);
    }
}