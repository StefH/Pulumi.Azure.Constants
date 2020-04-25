// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// The minimum supported TLS version for the function app.
    /// </summary>
    public static class FunctionAppSiteConfigMinTlsVersions
    {
        public const string V1 = "1.0";

        public const string V1dot1 = "1.1";

        public const string V1dot2 = "1.2";

        public const string Default = V1dot2;
    }
}