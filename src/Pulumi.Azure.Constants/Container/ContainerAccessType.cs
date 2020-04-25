// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// The Access Level configured for this Container.
    /// </summary>
    public static class ContainerAccessTypes
    {
        public const string Blob = "blob";

        public const string Container = "container";

        public const string Private = "private";

        public const string Default = Private;
    }
}