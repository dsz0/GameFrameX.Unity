using Base;
using GameFrameX.Network.Runtime;
using GameFrameX.Runtime;
using Hotfix.Proto;
using ICSharpCode.SharpZipLib.Core;

namespace Hotfix.Manager
{
    public sealed class PlayerManager : GameFrameworkSingleton<PlayerManager>, IMessageHandler
    {
        public PlayerManager()
        {
            PlayerInfo = new PlayerInfo();
            Register();
        }

        public PlayerInfo PlayerInfo { get;set; }


        [MessageHandler(typeof(NotifyHeartBeat), nameof(NotifyHeartBeatHandler))]
        private void NotifyHeartBeatHandler(NotifyHeartBeat message)
        {
            Log.Debug("NotifyHeartBeat==>" + message);
        }


        public void Register()
        {
            ProtoMessageHandler.Add(this);
            
        }
    }
}