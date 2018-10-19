using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tele = new TV();
            SmartTV smartele = new SmartTV();
            SmartRemote controlinteligente = new SmartRemote();
            Remote control = new Remote();
            control.TurnOnTV(tele);
            controlinteligente.TurnOnTV(smartele);
            controlinteligente.StartNetflix(smartele);
            control.TurnOffTV(smartele);
            control.TurnOffTV(tele);
            GermanAdapter teleloca = new GermanAdapter(new GermanTV());
            control.TurnOffTV(teleloca);
            control.TurnOnTV(teleloca);

            




        }
    }
}
