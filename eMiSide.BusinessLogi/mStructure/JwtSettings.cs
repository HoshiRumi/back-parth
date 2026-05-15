namespace eMiSide.BusinessLogic.Structure
{
    public static class JwtSettings
    {
        public const string Issuer = "eMiSideApi";
        public const string Audience = "eMiSideClients";
        public const string SecretKey = "eMiSide_curs2026_super_secret_min_32_caractere!";
        public const int ExpireMinutes = 60;
    }
}