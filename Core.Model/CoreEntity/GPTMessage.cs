using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.CoreEntity
{
    public class GPTMessage
    {
        public GPTMessage(string role, string content)
        {
            this.Role = role;
            this.Content = content;
        }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
