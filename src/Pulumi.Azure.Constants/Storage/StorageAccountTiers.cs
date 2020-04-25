// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Defines the Tier to use for this storage account.
    /// </summary>
    public static class StorageAccountTiers
    {
        public const string Standard = nameof(Standard);

        /// <summary>
        /// For `FileStorage` accounts only `Premium` is valid.
        /// </summary>
        public const string Premium = nameof(Premium);
    }
}