namespace ApplicationUpdater.Models;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class AppVersionsJson
{
    [JsonPropertyName("entries")]
    public IList<Entry>? AppEntries { get; set; }

    public class Entry
    {
        [JsonPropertyName("guid")]
        public Guid GUID { get; set; }

        [JsonPropertyName("info")]
        public string? AppInfo { get; set; }

        [JsonPropertyName("semver")]
        public string? SemVer { get; set; }

        [JsonPropertyName("downloadurl")]
        public string? DownloadUrl { get; set; }

        [JsonPropertyName("packagesha256")]
        public string? PackageSha256 { get; set; }

        public override string ToString() =>
            $"GUID: {this.GUID}{Environment.NewLine}" +
            $"Info: {this.AppInfo}{Environment.NewLine}" +
            $"Version: {this.SemVer}{Environment.NewLine}" +
            $"DownloadUrl: {this.DownloadUrl}{Environment.NewLine}" +
            $"Sha256: {this.PackageSha256}{Environment.NewLine}";
    }
}
