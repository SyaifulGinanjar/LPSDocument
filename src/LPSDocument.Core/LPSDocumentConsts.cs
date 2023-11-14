using LPSDocument.Debugging;

namespace LPSDocument
{
    public class LPSDocumentConsts
    {
        public const string LocalizationSourceName = "LPSDocument";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3318bc75d0f1429aab6942e031cde329";
    }
}
