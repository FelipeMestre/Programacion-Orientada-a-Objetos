using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Drawing;
using SixLabors.Shapes;

namespace CognitiveCore
{
    public class CognitiveFace
    {
        // Replace <Subscription Key> with your valid subscription key.
        string subscriptionKey = "";

        // NOTE: You must use the same region in your REST call as you used to
        // obtain your subscription keys. For example, if you obtained your
        // subscription keys from westus, replace "westcentralus" in the URL
        // below with "westus".
        //
        // Free trial subscription keys are generated in the westcentralus region.
        // If you use a free trial subscription key, you shouldn't need to change
        // this region.
        const string uriBase = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        Rgba32 boxColor;
        /// <summary>
        /// Indica si la ultima llamada encontró o no una cara en la imagen
        /// </summary>
        /// <value></value>
        public bool FaceFound { get; private set; }
        /// <summary>
        /// Esta clase se encarga de consultar el servicio cloud para encontrar caras en las fotos
        /// </summary>
        /// <param name="subscriptionKey">api key para invocar el servicio</param>
        /// <param name="boxColor">color a utilizar para dibujar un recuadro si se encuentra una cara</param>
        public CognitiveFace(string subscriptionKey, System.Drawing.Color boxColor)
        {
            this.subscriptionKey = subscriptionKey;
            this.boxColor = new Rgba32(boxColor.R,boxColor.G,boxColor.B,boxColor.A);
        }
        public void Recognize(string path)
        {
            FaceFound = false;
            this.MakeAnalysisRequest(path).Wait();
        }
        /// <summary>
        /// Gets the analysis of the specified image by using the Face REST API.
        /// </summary>
        /// <param name="imageFilePath">The image file.</param>
        private async Task MakeAnalysisRequest(string imageFilePath)
        {
            HttpClient client = new HttpClient();

            // Request headers.
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", this.subscriptionKey);

            // Request parameters. A third optional parameter is "details".
            string requestParameters = "returnFaceId=true&returnFaceLandmarks=false" +
                "&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses," +
                "emotion,hair,makeup,occlusion,accessories,blur,exposure,noise";

            // Assemble the URI for the REST API Call.
            string uri = uriBase + "?" + requestParameters;

            HttpResponseMessage response;

            // Request body. Posts a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json"
                // and "multipart/form-data".
                content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/octet-stream");

                // Execute the REST API call.
                response = await client.PostAsync(uri, content);

                // Get the JSON response.
                string contentString = await response.Content.ReadAsStringAsync();
                List<CognitiveResult> resArray = JsonConvert.DeserializeObject<List<CognitiveResult>>(contentString);
                if (resArray.Count > 0)
                {
                    this.FaceFound = true;
                }
                foreach (CognitiveResult face in resArray)
                {
                    DrawRectangle(face, imageFilePath);
                }
            }
        }
        private void DrawRectangle(CognitiveResult face, string imgPath)
        {
            int x0 = face.faceRectangle.left;
            int y0 = face.faceRectangle.top;
            int width = face.faceRectangle.width;
            int height = face.faceRectangle.height;
            SixLabors.Primitives.RectangleF recc = new SixLabors.Primitives.RectangleF(x0,y0,width,height);
            float thick = 4;
            using (Image<Rgba32> image = Image.Load(imgPath))
            {
                image.Mutate(DrawRectangleExtensions=> DrawRectangleExtensions.Draw(
                        color:boxColor,
                        thickness:thick,
                        shape: recc
                    )
                );
                image.Save(imgPath); // Automatic encoder selected based on extension.
            }
        }

        /// <summary>
        /// Returns the contents of the specified file as a byte array.
        /// </summary>
        /// <param name="imageFilePath">The image file to read.</param>
        /// <returns>The byte array of the image data.</returns>
        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
        static CognitiveResult result;
        private class CognitiveResult
        {
            public string faceId { get; set; }
            public FaceRect faceRectangle { get; set; }
        }
        private class FaceRect
        {
            public int top { get; set; }
            public int left { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }
    }
}