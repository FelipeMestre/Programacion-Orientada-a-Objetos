namespace Adapter
{
        public class Remote : IRemote
        {
                private void TurnOnTV(ITV TV)
                {
                        TV.TurnOn();
                }
                private void TurnOffTV(ITV TV)
                {
                        TV.TurnOff();
                }
        }
}