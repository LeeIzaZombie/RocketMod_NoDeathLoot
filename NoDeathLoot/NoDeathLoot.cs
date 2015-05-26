using System;
using UnityEngine;
using Rocket.Unturned;
using Rocket.Unturned.Plugins;

namespace NoDeathLoot
{
    public class PluginNoDeathLoot : RocketPlugin
    {
        public bool RunFromConsole
        {
            get { return true; }
        }
        public string Name
        {
            get { return "nodeathloot"; }
        }
        protected override void Load()
        {
            Rocket.Unturned.Events.RocketPlayerEvents.OnPlayerDeath += RocketPlayerEvents_OnPlayerDeath;
        }

        private void RocketPlayerEvents_OnPlayerDeath(Rocket.Unturned.Player.RocketPlayer player, SDG.EDeathCause cause, SDG.ELimb limb, Steamworks.CSteamID murderer)
        {
            player.Inventory.Clear(); //That's all.. ikr but it works!
        }

    }
}
