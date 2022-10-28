using Flandre.Core;
using Flandre.Adapters.Konata;
using Konata.Core.Common;
using Flandre.Core.Common;
using Flandre.Core.Messaging;

var app = new FlandreApp();

var config = new KonataAdapterConfig();
config.Bots.Add(new KonataBotConfig
{
    KeyStore = new BotKeyStore("1477336749", "Pippi301")
});

app
    .UseKonataAdapter(config)
    .Use(new ExamplePlugin())
    .Start();

class ExamplePlugin : Plugin
{
    public override void OnMessageReceived(MessageContext ctx)
        => ctx.Bot.SendMessage(ctx.Message);
}