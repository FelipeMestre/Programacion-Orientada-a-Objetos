namespace Adapter
{
        public class GermanTV
    {
        string status = "eingeschaltet";
        public void Ausschalten()
        {
            this.status = "ausgeschaltet";
        }
        public void Einschalten()
        {
            this.status = "eingeschaltet";
        }
        public string Status
        {
            get {return this.status;}
        }
    }
        class GermanAdapter : ITV
        {
            
                public GermanAdapter(GermanTV Germantv)
                {
                    this.germanTV = Germantv;
                }
                private GermanTV germanTV;
                public bool Status{
                    get {
                        return (germanTV.Status == "ausgeschaltet");
                    }
                }

                public void TurnOff()
                {
                        this.germanTV.Ausschalten();
                }

                public void TurnOn()
                {
                        this.germanTV.Einschalten();
                }
        }
}