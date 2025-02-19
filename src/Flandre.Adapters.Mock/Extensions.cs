﻿using Flandre.Core.Messaging;

namespace Flandre.Adapters.Mock;

public static class FlandreTestingExtensions
{
    public static MockClient GetChannelClient(this MockAdapter adapter, string guildId, string channelId,
        string userId)
    {
        return new MockClient(adapter)
        {
            EnvironmentType = MessageSourceType.Channel,
            GuildId = guildId,
            ChannelId = channelId,
            UserId = userId
        };
    }

    public static MockClient GetChannelClient(this MockAdapter adapter)
    {
        return GetChannelClient(adapter, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString());
    }

    public static MockClient GetFriendClient(this MockAdapter adapter, string userId)
    {
        return new MockClient(adapter)
        {
            EnvironmentType = MessageSourceType.Private,
            UserId = userId
        };
    }

    public static MockClient GetFriendClient(this MockAdapter adapter)
    {
        return GetFriendClient(adapter, Guid.NewGuid().ToString());
    }
}