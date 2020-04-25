// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`.
    /// Changing this forces a new resource to be created. Defaults to `StorageV2`.
    /// </summary>
    public static class StorageAccountKinds
    {
        public const string BlobStorage = nameof(BlobStorage);

        public const string BlockBlobStorage = nameof(BlockBlobStorage);

        public const string FileStorage = nameof(FileStorage);

        public const string Storage = nameof(Storage);

        public const string StorageV2 = nameof(StorageV2);

        public const string Default = StorageV2;
    }
}
