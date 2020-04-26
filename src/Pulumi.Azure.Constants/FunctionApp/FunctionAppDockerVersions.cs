// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// All Function App Docker versions (Linux and Windows) which are supported.
    /// </summary>
    public static class FunctionAppDockerVersions
    {
        #region Linux
        public const string DotNetV2 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0";

        public const string DotNetV3 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:3.0";

        public const string NodeV2 = "DOCKER|mcr.microsoft.com/azure-functions/node:2.0";

        public const string PowerShellV2 = "DOCKER|mcr.microsoft.com/azure-functions/powershell:2.0";

        public const string PythonV2 = "DOCKER|mcr.microsoft.com/azure-functions/python:2.0";
        #endregion

        #region Windows
        public const string DotNetV2NanoServer1709 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1709";

        public const string DotNetV2NanoServer1803 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1803";

        public const string DotNetV2NanoServer1809 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1809";
        #endregion
    }
}