// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts.
    /// </summary>
    public static class AccessTiers
    {
        public const string Hot = nameof(Hot);

        public const string Cool = nameof(Cool);

        public const string Default = Hot;
    }
}
