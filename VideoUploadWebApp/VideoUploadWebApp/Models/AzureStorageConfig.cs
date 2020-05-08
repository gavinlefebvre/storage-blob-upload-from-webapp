namespace VideoUploadWebApp.Models
{
    public class AzureStorageConfig
    {
        public string AccountName { get; set; }
        public string AccountKey { get; set; }
        public string VideoContainer { get; set; }
        public string ThumbnailContainer { get; set; }
    }
}
