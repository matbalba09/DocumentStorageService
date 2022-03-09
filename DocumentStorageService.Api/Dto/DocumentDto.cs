namespace DocumentStorageService.Api.Dto
{
    public class DocumentDto
    {
        //public int doc_id { get; set; }
        public int? app_id { get; set; }
        public int creation_obua_id { get; set; }
        public int creation_timestamp { get; set; }
        public int last_upload_obua_id { get; set; }
        public DateTime last_upload_timestamp { get; set; }
        public int? last_download_obua_id { get; set; }
        public DateTime? last_download_timestamp { get; set; }
        public string description { get; set; }
        public int document_type_id { get; set; }
        public int file_size { get; set; }
        //[JsonIgnore]
        //public virtual FileType file_type { get; set; }
        public int file_type { get; set; }
        public string filename { get; set; }
        public string data { get; set; }
    }
}
