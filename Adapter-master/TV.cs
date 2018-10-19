namespace Adapter
{
        public class TV : ITV
        {
                public TV()
                {
                        this.Status = false;
                }
                public bool Status { get; private set; }
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