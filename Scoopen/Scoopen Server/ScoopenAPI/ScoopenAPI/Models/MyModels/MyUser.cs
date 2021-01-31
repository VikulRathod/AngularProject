using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoopenAPI.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {

    }

    public class UserMetadata
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isDeleting")]
        public Nullable<bool> IsDeleted { get; set; }

        [JsonProperty("role")]
        public Nullable<int> RoleId { get; set; }
    }
}