using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LTImageTools.ImageTools
{
    public class ImageOperations
    {
        public string DirectoryPath { get; set; }
        public List<ImageStructure> ImageFilesContainer;
        public List<BindableImageStructure> BindableFileContainer;
        private List<string> ImageFiles;
        private List<string> ExtensionFilter = new List<string> { ".png" };
        private byte[] bytePattern = new byte[] { 0x6D, 0x79, 0x63, 0x67 };

        public void LoadImages()
        {
            if (string.IsNullOrEmpty(DirectoryPath))
                throw new Exception("Path to folder containing images is not set");
            if (Directory.Exists(DirectoryPath))
            {
                ImageFiles = Directory.GetFiles(DirectoryPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(Q => ExtensionFilter.Contains(Path.GetExtension(Q).ToLower())).ToList();
                if (ImageFiles.Count <= 0)
                    throw new Exception("No images found, configure your image directory path again");
                ImageFilesContainer = new List<ImageStructure>();
                BindableFileContainer = new List<BindableImageStructure>();
                var index = 0;
                foreach (var imageFile in ImageFiles)
                {
                    var structFile = new ImageStructure();
                    structFile.File = Path.GetFileName(imageFile);
                    structFile.OriginalLoadImage = File.ReadAllBytes(imageFile);
                    structFile.saveFile = false;
                    structFile.Index = index;
                    index++;
                    ImageFilesContainer.Add(structFile);
                }
                PerformEncodeDecode();
            }
        }

        private void PerformEncodeDecode()
        {
            foreach (var ContainerFile in ImageFilesContainer)
            {
                var bindableFile = new BindableImageStructure();
                bindableFile.Index = ContainerFile.Index;
                bindableFile.saveFile = ContainerFile.saveFile;
                bindableFile.File = ContainerFile.File;
                var imageEncodeFootPrint = new byte[4];
                Buffer.BlockCopy(ContainerFile.OriginalLoadImage, 0, imageEncodeFootPrint, 0, 4);
                if (imageEncodeFootPrint.SequenceEqual(bytePattern))
                {
                    bindableFile.ImageStatus = ContainerFile.ImageStatus = "Encoded";
                    bindableFile.isEncoded = ContainerFile.isEncoded = true;
                    ContainerFile.EncodedImage = new byte[ContainerFile.OriginalLoadImage.Length];
                    Buffer.BlockCopy(ContainerFile.OriginalLoadImage, 0, ContainerFile.EncodedImage, 0, ContainerFile.OriginalLoadImage.Length);
                    ContainerFile.DecodedImage = Decode(ContainerFile.OriginalLoadImage);
                }
                else
                {
                    bindableFile.ImageStatus = ContainerFile.ImageStatus = "Decoded";
                    bindableFile.isEncoded = ContainerFile.isEncoded = false;
                    ContainerFile.DecodedImage = new byte[ContainerFile.OriginalLoadImage.Length];
                    Buffer.BlockCopy(ContainerFile.OriginalLoadImage, 0, ContainerFile.DecodedImage, 0, ContainerFile.DecodedImage.Length);
                    ContainerFile.EncodedImage = Encode(ContainerFile.OriginalLoadImage);
                }
                BindableFileContainer.Add(bindableFile);
            }
        }

        private byte[] Decode(byte[] ImageByteArray)
        {
            var DecodedImage = new byte[ImageByteArray.Length - 4];
            Buffer.BlockCopy(ImageByteArray, ImageByteArray.Length - 100, DecodedImage, 0, 100);
            Buffer.BlockCopy(ImageByteArray, 4, DecodedImage, 100, ImageByteArray.Length - 104);
            return DecodedImage;
        }

        private byte[] Encode(byte[] ImageByteArray)
        {
            var EncodedImage = new byte[ImageByteArray.Length + 4];
            Buffer.BlockCopy(bytePattern, 0, EncodedImage, 0, 4);
            Buffer.BlockCopy(ImageByteArray, 100, EncodedImage, 4, ImageByteArray.Length - 100);
            Buffer.BlockCopy(ImageByteArray, 0, EncodedImage, EncodedImage.Length - 100, 100);
            return EncodedImage;
        }
    }
}
