namespace Adapter
{
        public class SmartRemote : ISmartRemote, IRemote
        {
                private void StartNetflix(ISmartTV TV)
                {
                        TV.PlayNetflix();
                }
                private void StartYouTube(ISmartTV TV)
                {
                        TV.PlayYoutube();
                }
                public void TurnOnTV(ITV TV)
                {
                        TV.TurnOn();
                }
                public void TurnOffTV(ITV TV)
                {
                        TV.TurnOff();
                }
        }
}