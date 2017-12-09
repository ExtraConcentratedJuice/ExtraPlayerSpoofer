using Steamworks;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;

namespace ExtraConcentratedJuice.ExtraPlayerSpoof
{
    public class ExtraPlayerSpoof : RocketPlugin<ExtraPlayerSpoofConfig>
    {
        protected override void Load()
        {
            Logger.Log("-----------");
            Logger.Log("Extra's Player Spoofer Loaded!");
            Logger.Log("Can you believe it? People are selling this one line plugin for $6!");
            Logger.Log("> Setting player count to: " + Configuration.Instance.player_count);
            Logger.Log("-----------");

            SteamGameServer.SetBotPlayerCount(Configuration.Instance.player_count);
        }

        protected override void Unload()
        {
        }

        private void OnLevelLoaded(int l)
        {
            SteamGameServer.SetBotPlayerCount(Configuration.Instance.player_count);
        }

    }
}
