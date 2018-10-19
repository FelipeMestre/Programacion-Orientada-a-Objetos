namespace Adapter
{
        public class SmartTV : ISmartTV
        {
                public SmartTV()
                {
                        this.Status = false;
                        this.PlayingNetflix = false;
                        this.PlayingYoutube = false;
                }
                public bool Status { get; set; }
                private bool PlayingNetflix { get; set; }
                private bool PlayingYoutube { get; set; }
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
}