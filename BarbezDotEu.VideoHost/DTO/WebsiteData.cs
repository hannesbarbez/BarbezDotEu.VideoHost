// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.VideoHost.DTO
{
    public class WebsiteData
    {
        public WebsiteData(string uri, string name, string link, string type, string description)
        {
            Uri = uri;
            Name = name;
            Link = link;
            Type = type;
            Description = description;
        }

        public string Uri { get; }
        public string Name { get; }
        public string Link { get; }
        public string Type { get; }
        public string Description { get; }
    }
}
