// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

namespace BarbezDotEu.VideoHost.DTO
{
    /// <summary>
    /// Represents website data associated with a video hosting user.
    /// </summary>
    public class WebsiteData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteData"/> class.
        /// </summary>
        /// <param name="uri">The URI of the website.</param>
        /// <param name="name">The name of the website.</param>
        /// <param name="link">The link to the website.</param>
        /// <param name="type">The type of website.</param>
        /// <param name="description">A description of the website.</param>
        public WebsiteData(string uri, string name, string link, string type, string description)
        {
            Uri = uri;
            Name = name;
            Link = link;
            Type = type;
            Description = description;
        }

        /// <summary>
        /// Gets the URI of the website.
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Gets the name of the website.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the link to the website.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// Gets the type of website.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the description of the website.
        /// </summary>
        public string Description { get; }
    }
}
