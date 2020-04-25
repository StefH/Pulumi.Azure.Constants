// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Specifies the type of Application Insights to create.
    /// Valid values are `ios` for _iOS_, `java` for _Java web_, `MobileCenter` for _App Center_, `Node.JS` for _Node.js_,
    /// `other` for _General_, `phone` for _Windows Phone_, `store` for _Windows Store_ and `web` for _ASP.NET_.
    /// Please note these values are case sensitive; unmatched values are treated as _ASP.NET_ by Azure. Changing this forces a new resource to be created.
    /// </summary>
    public static class InsightsApplicationTypes
    {
        public const string IOS = "ios";

        public const string Java = "java";

        public const string MobileCenter = nameof(MobileCenter);

        public const string AppCenter = nameof(MobileCenter);

        public const string NodeJS = "Node.JS";

        public const string Other = "other";

        public const string General = Other;

        public const string WindowsPhone = "phone";

        public const string WindowsStore = "store";

        public const string Web = "web";

        public const string AspDotNet = Web;

        public const string Default = Web;
    }
}