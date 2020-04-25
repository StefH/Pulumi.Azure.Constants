// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Defines the type of replication to use for this storage account.
    /// </summary>
    public static class AccountReplicationTypes
    {
        public const string LRS = nameof(LRS);
        public const string LocallyRedundantStorage = LRS;

        public const string GRS =nameof(GRS);
        public const string GeoRedundantStorage = GRS;

        public const string RAGRS = nameof(RAGRS);
        public const string ReadAccessGeoRedundant = RAGRS;

        public const string ZRS = nameof(ZRS);
        public const string ZoneRedundantStorage = ZRS;
    }
}