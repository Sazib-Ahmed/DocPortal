using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    /// <summary>
    /// Represents an interface for handling image-related operations.
    /// </summary>
    /// <typeparam name="TImage">The type of the image data.</typeparam>
    /// <typeparam name="TImageName">The type of the image name.</typeparam>
    /// <typeparam name="TResult">The type of the result returned by methods.</typeparam>
    public interface IImageHandler<TImage, TImageName, TResult>
    {
        /// <summary>
        /// Uploads an image with the specified image data and image name.
        /// </summary>
        /// <param name="image">The image data to upload.</param>
        /// <param name="imageName">The name of the image.</param>
        /// <returns>The result of the image upload operation.</returns>
        TResult UploadImage(TImage image, TImageName imageName);

        /// <summary>
        /// Retrieves an image with the specified image name.
        /// </summary>
        /// <param name="imageName">The name of the image to retrieve.</param>
        /// <returns>The retrieved image data.</returns>
        TImage GetImage(TImageName imageName);
    }
}
