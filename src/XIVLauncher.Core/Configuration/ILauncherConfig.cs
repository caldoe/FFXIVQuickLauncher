using XIVLauncher.Common;

namespace XIVLauncher.Core.Configuration;

public interface ILauncherConfig
{
    public string AcceptLanguage { get; set; }

    public DirectoryInfo GamePath { get; set; }

    public string AdditionalArgs { get; set; }

    public ClientLanguage ClientLanguage { get; set; }
}