using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DocumentStorageService.Api.Core.Domain
{
    public class FileType
    {
        [Key]
        public int file_type_id { get; set; }
        public string file_type { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? finish_date { get; set; }

        [JsonIgnore]
        public virtual Document document { get; set; }
        [JsonIgnore]

        [ForeignKey("document")]
        public int document_id { get; set; }
    }
}
