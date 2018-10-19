using System;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider foto = new PictureProvider();
            IPicture foto1 = foto.GetPicture(@"C:\Users\estudiante.fit\Documents\GitHub\CompAndDel\fotojpg.jpg");
            
            int[,] matriz = new int[3,3] {{-1, 0, -1,},{0,4,0},{-1,0,-1}};
            Propiedades data = new Propiedades(matriz,1,27);
            FilterConvolution FiltroDeMatriz = new FilterConvolution(data);
            FilterGreyscale FiltroGreyscale = new FilterGreyscale();
            BoolFilter FiltroBooleano = new BoolFilter();
            
            TwitterImage sender = new TwitterImage("dtOgpyjBBXglAzMEjMMZtFf73",
                        "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN",
                        "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz",
                        "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF");
            TwitterFilter FiltroTwitter = new TwitterFilter(sender);
            
            PipeNull cañofinal = new PipeNull();
            PipeSerial caño3 = new PipeSerial(FiltroGreyscale,cañofinal);
            PipeSerial caño1 = new PipeSerial(FiltroTwitter,cañofinal);
            BoolPipe CañoBifurcado = new BoolPipe(caño1,caño3,FiltroBooleano);

            IPicture foto2 = CañoBifurcado.Send(foto1);
            foto.SavePicture(foto2, @"C:\Users\estudiante.fit\Documents\GitHub\CompAndDel\foto12.jpg");

        }
    }
}
