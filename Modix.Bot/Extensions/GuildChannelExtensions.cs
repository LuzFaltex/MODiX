using Discord;

namespace Modix.Bot.Extensions
{
    internal static class GuildChannelExtensions
    {
        private const ulong StaffRoleId = 606205846854303755;
        public static bool IsPublic(this IGuildChannel channel)
        {
            if (channel?.Guild is IGuild guild)
            {
                var role = guild.GetRole(StaffRoleId);
                var permissions = channel.GetPermissionOverwrite(role);

                return permissions.HasValue && permissions.Value.ViewChannel == PermValue.Allow;
            }

            return false;
        }
    }
}
