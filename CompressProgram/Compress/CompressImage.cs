using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace CompressProgram.Compress
{
    public class CompressImage
    {
        
        public CompressImage() {}

        public async Task ApplyCompressedImage(Image sourceImage, int imageQuality, string fileSavePath)
        {
            Task.Run(() => CompressedImage(sourceImage, imageQuality, fileSavePath));
        }
        
        private static void CompressedImage(Image sourceImage, int imageQuality, string fileSavePath)
        {
            try
            {
                //Create an ImageCodecInfo-object for the codec information
                ImageCodecInfo jpegCodec = null;

                //Set quality factor for compression
                var imageQualitysParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, imageQuality);

                //List all avaible codecs (system wide)
                var allCodecs = ImageCodecInfo.GetImageEncoders();

                var codecParameter = new EncoderParameters(1);
            
                codecParameter.Param[0] = imageQualitysParameter;

                //Find and choose JPEG codec
                foreach (var t in allCodecs)
                {
                    if (t.MimeType == "image/jpeg")
                    {
                        jpegCodec = t;
                        break;
                    }
                }

                //Save compressed image
                sourceImage.Save(fileSavePath, jpegCodec, codecParameter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}