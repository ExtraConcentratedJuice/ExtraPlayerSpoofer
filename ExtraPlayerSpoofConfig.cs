using Rocket.API;


namespace ExtraConcentratedJuice.ExtraPlayerSpoof
{
    public class ExtraPlayerSpoofConfig : IRocketPluginConfiguration
    {
        public int player_count;
        public void LoadDefaults()
        {
            player_count = 69;
        }
    }
}
