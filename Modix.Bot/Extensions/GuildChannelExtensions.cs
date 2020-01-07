using System.Linq;
using Discord;

namespace Modix.Bot.Extensions
{
    internal static class GuildChannelExtensions
    {
        private static readonly ulong[] PrivateChannels = { 606206696502722577 };
        public static bool IsPublic(this IGuildChannel channel)
        {
            if (channel is { })
            {
                // If the current channel is NOT contained in the list of private channels
                return !PrivateChannels.Contains(channel.Id);
            }

            return false;
        }
    }
}
