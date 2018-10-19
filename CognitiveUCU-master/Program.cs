using System;
using System.Drawing;

namespace CognitiveCore
{
    class Program
    {
        static void Main(string[] args)
        {
            CognitiveFace cog = new CognitiveFace("<api-key>", Color.GreenYellow);
            cog.Recognize(@"bill.jpg");
            FoundFace(cog);
            cog.Recognize(@"yacht.jpg");
            FoundFace(cog);
        }
        static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
                Console.WriteLine("Face Found! :)");
            else
                Console.WriteLine("No Face Found :(");
        }
    }
}
