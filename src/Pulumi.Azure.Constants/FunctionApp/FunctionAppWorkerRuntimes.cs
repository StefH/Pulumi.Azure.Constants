// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// he language worker runtime to load in the function app. This will correspond to the language being used in your application (for example, "dotnet").
    /// For functions in multiple languages you will need to publish them to multiple apps, each with a corresponding worker runtime value. 
    /// </summary>
    public static class FunctionAppWorkerRuntimes
    {
        /// <summary>
        /// C#/F#
        /// </summary>
        public const string DotNet = "dotnet";

        /// <summary>
        /// JavaScript/TypeScript
        /// </summary>
        public const string Node = "node";

        /// <summary>
        /// Java
        /// </summary>
        public const string Java = "java";

        /// <summary>
        /// PowerShell
        /// </summary>
        public const string PowerShell = "powershell";

        /// <summary>
        /// Python
        /// </summary>
        public const string Python = "python";
    }
}