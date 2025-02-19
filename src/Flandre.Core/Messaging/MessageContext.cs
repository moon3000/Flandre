﻿using Flandre.Core.Common;

namespace Flandre.Core.Messaging;

/// <summary>
/// 消息上下文
/// </summary>
public class MessageContext : Context
{
    /// <summary>
    /// 当前消息
    /// </summary>
    public Message Message { get; init; }

    /// <summary>
    /// 构造消息上下文
    /// </summary>
    /// <param name="app">FlandreApp 实例</param>
    /// <param name="bot">bot 实例</param>
    /// <param name="message">消息</param>
    public MessageContext(FlandreApp app, Bot bot, Message message)
        : base(app, bot)
    {
        Message = message;
    }

    /// <summary>
    /// 用户 ID，等同于 Message.Sender.UserId
    /// </summary>
    public string UserId => Message.Sender.UserId;
}