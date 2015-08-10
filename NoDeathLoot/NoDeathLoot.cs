using System;
using Rocket.Unturned;
using Rocket.Core.Plugins;
using ZaupClearInventoryLib;

namespace NoDeathLoot
{
    public class PluginNoDeathLoot : RocketPlugin
    {
        protected override void Load()
        {
            Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerDeath += UnturnedPlayerEvents_OnPlayerDeath;
        }

        void UnturnedPlayerEvents_OnPlayerDeath(Rocket.Unturned.Player.UnturnedPlayer player, SDG.Unturned.EDeathCause cause, SDG.Unturned.ELimb limb, Steamworks.CSteamID murderer)
        {
            ZaupClearInventoryLib.ZaupClearInventoryLib.Instance.ClearInv(player);
            ZaupClearInventoryLib.ZaupClearInventoryLib.Instance.ClearClothes(player);
        }
    }
}
