using eDomain.mEntities.mRefs;
using eDomain.mEnums;
using eUShop.Domains.mEnums;

namespace eDomain.mEntities.mUser
{
    public class UserData : SharedFields
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Customer;
        public GenderTypes Gender { get; set; } = GenderTypes.Other;
    }
}