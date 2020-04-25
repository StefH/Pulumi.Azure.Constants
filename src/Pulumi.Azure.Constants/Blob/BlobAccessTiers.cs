// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// The access tier of the storage blob.
    /// </summary>
    public static class BlobAccessTiers
    {
        public const string Archive = nameof(Archive);

        public const string Cool = nameof(Cool);

        public const string Hot = nameof(Hot);
    }
}