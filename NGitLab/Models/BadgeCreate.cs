﻿using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class BadgeCreate
    {
        [DataMember(Name = "link_url")]
        public string LinkUrl;

        [DataMember(Name = "image_url")]
        public string ImageUrl;
    }
}
