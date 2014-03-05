// <auto-generated/>
using System;

namespace SampleArchitecture.Service.Areas.HelpPage
{
    /// <summary>
    /// This represents an image sample on the help page. There's a display template named ImageSample associated with this class.
    /// </summary>
    public class ImageSample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSample"/> class.
        /// </summary>
        /// <param name="sourceImage">The URL of an image.</param>
        public ImageSample(string sourceImage)
        {
            if (sourceImage == null)
            {
                throw new ArgumentNullException("sourceImage");
            }

            SourceImage = sourceImage;
        }

        public string SourceImage { get; private set; }

        public override bool Equals(object obj)
        {
            ImageSample other = obj as ImageSample;
            return other != null && SourceImage == other.SourceImage;
        }

        public override int GetHashCode()
        {
            return SourceImage.GetHashCode();
        }

        public override string ToString()
        {
            return SourceImage;
        }
    }
}