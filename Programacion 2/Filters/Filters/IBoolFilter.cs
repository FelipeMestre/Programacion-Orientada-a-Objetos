using CognitiveCore;
using System.Drawing;
namespace CompAndDel
{
        public interface IBoolFilter : IFilter
        {
                bool marca {get;}
        }
        public class BoolFilter : IBoolFilter
        {


                public CognitiveFace Reconocedor = new CognitiveFace("6cc93ca750fc4e0b9b716925f303dcc1",Color.Red);
                public bool marca {get; private set;}

                IPicture IFilter.Filter(IPicture image)
                {
                        new PictureProvider().SavePicture(image, @"C:\Users\estudiante.fit\Documents\GitHub\CompAndDel\temp.jpg");
                        Reconocedor.Recognize(@"C:\Users\estudiante.fit\Documents\GitHub\CompAndDel\temp.jpg");
                        marca = Reconocedor.FaceFound;
                        image = new PictureProvider().GetPicture(@"C:\Users\estudiante.fit\Documents\GitHub\CompAndDel\temp.jpg");
                        return image;                                          
                }
        }

}