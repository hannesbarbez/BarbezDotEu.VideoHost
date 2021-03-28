// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;

namespace BarbezDotEu.VideoHost.DTO
{
    /// <summary>
    /// Implements a flatter, "ironed" version of a user on a video hosting platform where all relevant properties are immediately in the object, save for the user's websites.
    /// </summary>
    public class VideoHostingUser
    {
        public VideoHostingUser(string bio, DateTime createdTime, string gender, string link, string location, string name, string shortBio, string uri, string city, string country, string countryIsoCode, string formattedAddress, double? latitude, double? longitude, string neighborhood, string state, string stateIsoCode, string subLocality, long? totalVideos, string uriVideos, long? totalAlbums, string uriAlbums, long? totalAppearances, string uriAppearances, long? totalChannels, string uriChannels, long? totalFeed, string uriFeed, long? totalFoldersRoot, string uriFoldersRoot, long? totalFollowers, string uriFollowers, long? totalFollowing, string uriFollowing, long? totalGroups, string uriGroups, long? totalLikes, string uriLikes, long? totalMembership, string uriMembership, long? totalModeratedChannels, string uriModeratedChannels, long? totalPictures, string uriPictures, long? totalPortfolios, string uriPortfolios, long? totalSharedVideos, string uriSharedVideos, long? totalTeams, string uriTeams, IEnumerable<WebsiteData> websites)
        {
            Bio = bio;
            CreatedTime = createdTime;
            Gender = gender;
            Link = link;
            Location = location;
            Name = name;
            ShortBio = shortBio;
            Uri = uri;
            City = city;
            Country = country;
            CountryIsoCode = countryIsoCode;
            FormattedAddress = formattedAddress;
            Latitude = latitude;
            Longitude = longitude;
            Neighborhood = neighborhood;
            State = state;
            StateIsoCode = stateIsoCode;
            SubLocality = subLocality;
            TotalVideos = totalVideos;
            UriVideos = uriVideos;
            TotalAlbums = totalAlbums;
            UriAlbums = uriAlbums;
            TotalAppearances = totalAppearances;
            UriAppearances = uriAppearances;
            TotalChannels = totalChannels;
            UriChannels = uriChannels;
            TotalFeed = totalFeed;
            UriFeed = uriFeed;
            TotalFoldersRoot = totalFoldersRoot;
            UriFoldersRoot = uriFoldersRoot;
            TotalFollowers = totalFollowers;
            UriFollowers = uriFollowers;
            TotalFollowing = totalFollowing;
            UriFollowing = uriFollowing;
            TotalGroups = totalGroups;
            UriGroups = uriGroups;
            TotalLikes = totalLikes;
            UriLikes = uriLikes;
            TotalMembership = totalMembership;
            UriMembership = uriMembership;
            TotalModeratedChannels = totalModeratedChannels;
            UriModeratedChannels = uriModeratedChannels;
            TotalPictures = totalPictures;
            UriPictures = uriPictures;
            TotalPortfolios = totalPortfolios;
            UriPortfolios = uriPortfolios;
            TotalSharedVideos = totalSharedVideos;
            UriSharedVideos = uriSharedVideos;
            TotalTeams = totalTeams;
            UriTeams = uriTeams;
            Websites = websites;
        }

        public string Bio { get; }
        public DateTime CreatedTime { get; }
        public string Gender { get; }

        /// <summary>
        /// Gets or sets the absolute Uri.
        /// </summary>
        public string Link { get; }
        public string Location { get; }
        public string Name { get; }
        public string ShortBio { get; }

        /// <summary>
        /// Gets or sets the relative Uri.
        /// </summary>
        public string Uri { get; }
        public string City { get; }
        public string Country { get; }
        public string CountryIsoCode { get; }
        public string FormattedAddress { get; }
        public double? Latitude { get; }
        public double? Longitude { get; }
        public string Neighborhood { get; }
        public string State { get; }
        public string StateIsoCode { get; }
        public string SubLocality { get; }
        public long? TotalVideos { get; }
        public string UriVideos { get; }
        public long? TotalAlbums { get; }
        public string UriAlbums { get; }
        public long? TotalAppearances { get; }
        public string UriAppearances { get; }
        public long? TotalChannels { get; }
        public string UriChannels { get; }
        public long? TotalFeed { get; }
        public string UriFeed { get; }
        public long? TotalFoldersRoot { get; }
        public string UriFoldersRoot { get; }
        public long? TotalFollowers { get; }
        public string UriFollowers { get; }
        public long? TotalFollowing { get; }
        public string UriFollowing { get; }
        public long? TotalGroups { get; }
        public string UriGroups { get; }
        public long? TotalLikes { get; }
        public string UriLikes { get; }
        public long? TotalMembership { get; }
        public string UriMembership { get; }
        public long? TotalModeratedChannels { get; }
        public string UriModeratedChannels { get; }
        public long? TotalPictures { get; }
        public string UriPictures { get; }
        public long? TotalPortfolios { get; }
        public string UriPortfolios { get; }
        public long? TotalSharedVideos { get; }
        public string UriSharedVideos { get; }
        public long? TotalTeams { get; }
        public string UriTeams { get; }
        public IEnumerable<WebsiteData> Websites { get; }
    }
}
