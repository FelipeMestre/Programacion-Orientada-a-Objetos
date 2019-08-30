namespace CompAndDel
{
        public class BoolPipe : IPipe
        {
                public BoolPipe(IPipe TruePipe, IPipe FalsePipe, IBoolFilter filtro)
                {
                        this.TruePipe = TruePipe;
                        this.FalsePipe = FalsePipe;
                        this.Filtro = filtro;
                }

                IPipe TruePipe { get; }
                IPipe FalsePipe { get; }
                IBoolFilter Filtro { get; }

                public IPicture Send(IPicture picture)
                {
                        IPicture imagen = Filtro.Filter(picture);
                        if (Filtro.marca)
                        {
                                return TruePipe.Send(imagen);
                        }
                        else
                        {
                                return FalsePipe.Send(imagen);
                        }                                          
                }
        }
    
}