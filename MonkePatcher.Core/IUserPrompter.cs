﻿using System.Threading.Tasks;

namespace MonkePatcher.Core
{
    public interface IUserPrompter
    {
        Task<bool> PromptAppNotInstalled();

        Task<bool> PromptAdbDisconnect(DisconnectionType type);

        Task<bool> PromptUnstrippedUnityUnavailable();

        Task<bool> Prompt32Bit();

        Task<bool> PromptPauseBeforeCompile();

        Task PromptUpgradeFromOld();
    }
}
