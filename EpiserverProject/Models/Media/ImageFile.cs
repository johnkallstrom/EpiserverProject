using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverProject.Models.Media
{
    [ContentType(GUID = "40928B1E-CC0C-4383-A859-9C36754A612C")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        public virtual string Copyright { get; set; }
    }
}