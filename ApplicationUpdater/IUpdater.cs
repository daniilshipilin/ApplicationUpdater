namespace ApplicationUpdater
{
    using System;
    using System.Threading.Tasks;

    public interface IUpdater
    {
        Guid AppGUID { get; }

        bool CheckUpdateRequested { get; }

        Version ClientVersion { get; }

        Version ServerVersion { get; }

        bool ServerVersionIsGreater { get; }

        Task<bool> CheckUpdateIsAvailable();

        Task ForceUpdate();

        Task Update();

        string GetUpdatePrompt();
    }
}
