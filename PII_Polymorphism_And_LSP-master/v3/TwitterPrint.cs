using System;
using System.IO;

namespace Polymorphism
{
        class TwitterPrinter : IPrinter
        {
                public void PrintTicket(Sale sale)
                {
                        TwitterApi Tweet = new TwitterApi("dtOgpyjBBXglAzMEjMMZtFf73", "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN", "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz", "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF");
                        Tweet.Tweet(sale.GetTextToPrint()+ " By Felipe Mestre").Wait();
                }
                
        }
}