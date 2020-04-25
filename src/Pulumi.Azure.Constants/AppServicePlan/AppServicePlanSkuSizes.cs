// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Specifies the plan's instance size.
    /// </summary>
    public static class AppServicePlanSkuSizes
    {
        public const string F1 = nameof(F1);

        public const string FREE = nameof(FREE);

        public const string D1 = nameof(D1);

        public const string SHARED = nameof(SHARED);

        public const string BasicSmall = "B1";
        public const string BasicMedium = "B2";
        public const string BasicLarge = "B3";

        public const string StandardSmall = "S1";
        public const string StandardMedium = "S2";
        public const string StandardLarge = "S3";

        public const string IsolatedSmall = "I1";
        public const string IsolatedMedium = "I2";
        public const string IsolatedLarge = "I3";

        public const string PremiumV2Small = "P1V2";
        public const string PremiumV2Medium = "P2V2";
        public const string PremiumV2Large = "P3V2";

        public const string PremiumContainerSmall = "PC2";
        public const string PremiumContainerMedium = "PC3";
        public const string PremiumContainerLarge = "PC4";
    }
}