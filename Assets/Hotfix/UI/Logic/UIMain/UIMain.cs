using FairyGUI;
using GameFrameX.Runtime;
using Hotfix.Manager;
using Hotfix.Proto;

namespace Hotfix.UI
{
    public partial class UIMain
    {
        public override void OnOpen(object userData)
        {
            base.OnOpen(userData);

            this.m_player_icon.icon = UIPackage.GetItemURL(FUIPackage.UICommonAvatar, PlayerManager.Instance.PlayerInfo.Avatar.ToString());
            this.m_player_name.text = PlayerManager.Instance.PlayerInfo.Name;
            this.m_player_level.text = "当前等级:" + PlayerManager.Instance.PlayerInfo.Level;
            this.m_bag_button.onClick.Set(OnBagBtnClick);
            this.m_user_button.onClick.Set(OnUserBtnClick);
        }

        private async void OnBagBtnClick()
        {
            ReqBagInfo reqBagInfo = new ReqBagInfo();
            var respBagInfo = await GameApp.Network.GetNetworkChannel("network").Call<RespBagInfo>(reqBagInfo);
            Log.Debug(respBagInfo);
        }
        
        private async void OnUserBtnClick()
        {
            ReqPlayerInfo reqUserInfo = new ReqPlayerInfo();
            reqUserInfo.PlayerId = PlayerManager.Instance.PlayerInfo.Id;
            //GameApp.Network.GetNetworkChannel("network").Send(reqUserInfo); //发了消息之后就不管了。
            var respUserInfo = await GameApp.Network.GetNetworkChannel("network").Call<RespPlayerInfo>(reqUserInfo);
            Log.Debug(respUserInfo);
        }
    }
}