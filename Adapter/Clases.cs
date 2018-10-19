namespace Adapter
{
        public class TV : ITV
        {
                public TV()
                {
                        this.Status = false;
                }
                public bool Status {get; private set;}
                public void TurnOff()
                {
                        this.Status = false;
                }
                public void TurnOn()
                {
                        this.Status = true;
                }
        }
        public class Remote : IRemote
        {
                public void TurnOnTV(ITV TV)
                {
                        TV.TurnOn();
                }
                public void TurnOffTV( ITV TV)
                {
                        TV.TurnOff();
                }

        }
        public class SmartTV : ISmartTV
        {
                public SmartTV()
                {
                        this.Status = false;
                        this.PlayingNetflix = false;
                        this.PlayingYoutube = false;
                }
               public bool Status {get;set;}
               private bool PlayingNetflix {get;set;}
               private bool PlayingYoutube {get;set;}
               public void PlayNetflix()
               {
                       if (this.Status)
                       {
                               this.PlayingNetflix = true;
                               this.PlayingYoutube = false;
                       }
               }
               public void PlayYoutube()
               {
                       if (this.Status)
                       {
                               this.PlayingNetflix = false;
                               this.PlayingYoutube = true;
                       }
               }
                public void TurnOff()
                {
                        this.Status = false;
                }
                public void TurnOn()
                {
                        this.Status = true;
                }

               
        }
        public class SmartRemote : ISmartRemote, IRemote
        {
                public void StartNetflix(ISmartTV TV)
                {
                      TV.PlayNetflix(); 
                }
                public void StartYouTube(ISmartTV TV)
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
 