using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using System.Diagnostics;

namespace CompAndDel
{
    class FilterPipe : IFilter
    {
        IPipe pipe;
        /// <summary>
        /// El filtro envia una imagen a una cañeria y luego retorna la misma imagen. 
        /// </summary>
        /// <param name="pipe">Cañerìa a la cual se le va a enviar la imagen</param>
        public FilterPipe(String name, IPipe pipe) 
        {
            this.pipe = pipe;
        }
        /// <summary>
        /// Envia la imagen a la cañeria pipe y retorna la misma imagen.
        /// </summary>
        /// <param name="image">Imagen a la que se le va a aplicar el filtro</param>
        /// <returns></returns>
        public IPicture Filter(IPicture image)
        {
            Debug.Assert(image != null);
            pipe.Send(image);
            return image;
        }

    }
        class TwitterFilter : IFilter
        {
                TwitterImage sender;

                public TwitterFilter(TwitterImage sender)
                {
                    this.sender = sender;
                    
                }

                public IPicture Filter(IPicture image)
                {
                        PictureProvider foto = new PictureProvider();
                        foto.SavePicture(image, @"C:\Users\estudiante.fit\Documents\Semestre Dos\Programación 2\imagen.jpg");
                        this.sender.PublishToTwitter("By Fmestre", @"C:\Users\estudiante.fit\Documents\Semestre Dos\Programación 2\imagen.jpg");
                        return image;
                }
        }
}
