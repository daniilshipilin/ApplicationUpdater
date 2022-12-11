namespace ApplicationUpdater.Helpers;

using System.Runtime.Versioning;
using Microsoft.Win32;

[SupportedOSPlatform("windows")]
internal static class AppSettings
{
    private const string RegistryBaseKey = @"SOFTWARE\Illuminati Software Inc.";
    private const string RegistryApplicationUpdaterKey = RegistryBaseKey + "\\Application Updater";

    private static readonly RegistryKey RegKeyApplicationUpdater = Registry.CurrentUser.CreateSubKey(RegistryApplicationUpdaterKey);

    /// <summary>
    /// Gets app versions url.
    /// </summary>
    public static string? AppVersionsUrl
    {
        get => (string?)RegKeyApplicationUpdater.GetValue(nameof(AppVersionsUrl));

        private set => RegKeyApplicationUpdater.SetValue(nameof(AppVersionsUrl), value ?? string.Empty);
    }

    /// <summary>
    /// Checks settings and creates required keys.
    /// </summary>
    public static void CheckSettings() => AppVersionsUrl ??= string.Empty;
}
