using System.Linq;
using Discord;

namespace Modix.Bot.Extensions
{
    internal static class GuildChannelExtensions
    {
        private static readonly ulong[] PrivateChannels = { 606205846854303755 };
        public static bool IsPublic(this IGuildChannel channel)
        {
            if (channel is { })
            {
                return PrivateChannels.Any(x => x.Equals(channel.Id));
            }

            return false;
        }
    }
}
