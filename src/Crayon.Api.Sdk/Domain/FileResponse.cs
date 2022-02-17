namespace Crayon.Api.Sdk.Domain
{
    public class FileResponse
    {
        public FileResponse(byte[] fileContent, string fileName, string fileContentType)
        {
            FileContent = fileContent;
            FileName = fileName;
            FileContentType = fileContentType;
        }

        public byte[] FileContent { get; }

        public string FileName { get; }

        public string FileContentType { get; }
    }
}