using System.Collections.Generic;
namespace Program
{
        class Stock
        {
                public List<DVD> Dvds { get; }
                public List<Cd> Cds { get; }

                public Stock( List <DVD> dvds , List <Cd> cds)
                {
                        this.Dvds = dvds;
                        this.Cds = cds;
                }
                
                public void AgregarDvd (DVD dvd)
                {
                        this.Dvds.Add(dvd);
                }
                public void AgregarCD (Cd cd)
                {
                        this.Cds.Add(cd);
                }

        }
}