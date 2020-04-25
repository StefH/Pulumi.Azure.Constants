// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// The kind of the App Service Plan to create.
    /// </summary>
    public static class PlanSkuKinds
    {
        public const string Windows = nameof(Windows);

        public const string App = nameof(App);

        public const string Linux = nameof(Linux);

        /// <summary>
        /// For Premium Consumption
        /// </summary>
        public const string Elastic = nameof(Elastic);

        /// <summary>
        /// For Consumption Plan
        /// </summary>
        public const string FunctionApp = nameof(FunctionApp);

        public const string Default = Windows;
    }
}