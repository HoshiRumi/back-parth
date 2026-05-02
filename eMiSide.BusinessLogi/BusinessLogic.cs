using eMiSide.BusinessLogic.Functions.Auth;
using eMiSide.BusinessLogic.Functions.Products;
using eMiSide.BusinessLogic.Interfaces;
using eMiSide.BusinessLogic.mInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMiSide.BusinessLogic
{
    public class BusinessLogic
    {
        public IAuthActions GetAuthActions() => new AuthFlow();
        public IProduct GetProductActions() => new ProductFlow();
    }
}