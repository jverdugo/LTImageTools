namespace LTImageTools.ImageTools
{
    public class ImageStructure
    {
        public byte[] OriginalLoadImage { get; set; }
        public string ImageStatus { get; set; }
        public byte[] EncodedImage { get; set; }
        public byte[] DecodedImage { get; set; }
        public bool isEncoded { get; set; }
        public bool saveFile { get; set; }
        public string File { get; set; }
        public int Index { get; set; }
    }

    public class BindableImageStructure
    {
        public int Index { get; set; }
        public string File { get; set; }
        public bool isEncoded { get; set; }
        public string ImageStatus { get; set; }
        public bool saveFile { get; set; }
    }
}
