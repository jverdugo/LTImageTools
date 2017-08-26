using System.Collections.Generic;
using System.IO;
namespace LTImageTools.ImageTools
{
    public class ImageFileIO
    {
        public void Encode(List<ImageStructure> ImageContainer, string outputPath)
        {
            foreach (var element in ImageContainer)
            {
                var EncodedImage = element.EncodedImage;
                string TargetPath = Path.Combine(outputPath, element.File);
                File.WriteAllBytes(TargetPath, EncodedImage);
            }
        }

        public void Decode(List<ImageStructure> ImageContainer, string outputPath)
        {
            foreach(var element in ImageContainer)
            {
                var DecodedImage = element.DecodedImage;
                string TargetPath = Path.Combine(outputPath, element.File);
                File.WriteAllBytes(TargetPath, DecodedImage);
            }
        }
    }
}
