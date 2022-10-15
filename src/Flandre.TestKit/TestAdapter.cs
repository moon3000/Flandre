﻿using Flandre.Core.Common;

#pragma warning disable CS1998

namespace Flandre.TestKit;

public class TestAdapter : IAdapter
{
    internal readonly TestBot Bot = new();

    public async Task Start()
    {
    }

    public async Task Stop()
    {
    }

    public IEnumerable<IBot> GetBots()
    {
        return new[] { Bot };
    }
}