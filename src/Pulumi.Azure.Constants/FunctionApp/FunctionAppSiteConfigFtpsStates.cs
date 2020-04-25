// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// State of FTP / FTPS service for this function app.
    /// </summary>
    public static class FunctionAppSiteConfigFtpsStates
    {
        public const string AllAllowed = nameof(AllAllowed);

        public const string FtpsOnly = nameof(FtpsOnly);

        public const string Disabled = nameof(Disabled);
    }
}