// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Collections.Generic;

namespace BarbezDotEu.VideoHost.DTO
{
    /// <summary>
    /// Implements a flatter, "ironed" version of a user on a video hosting platform where all relevant properties are immediately in the object, save for the user's websites.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="VideoHostingUser"/> class.
    /// </remarks>
    /// <param name="bio">The biography of the user.</param>
    /// <param name="createdTime">The creation time of the user account.</param>
    /// <param name="gender">The gender of the user.</param>
    /// <param name="link">The absolute URI link of the user profile.</param>
    /// <param name="location">The location information of the user.</param>
    /// <param name="name">The full name of the user.</param>
    /// <param name="shortBio">A short biography of the user.</param>
    /// <param name="uri">The relative URI of the user profile.</param>
    /// <param name="city">The city where the user is located.</param>
    /// <param name="country">The country where the user is located.</param>
    /// <param name="countryIsoCode">The ISO code for the user's country.</param>
    /// <param name="formattedAddress">The formatted address of the user.</param>
    /// <param name="latitude">The latitude coordinate of the user's location.</param>
    /// <param name="longitude">The longitude coordinate of the user's location.</param>
    /// <param name="neighborhood">The neighborhood of the user.</param>
    /// <param name="state">The state portion of the user's location.</param>
    /// <param name="stateIsoCode">The ISO code of the state.</param>
    /// <param name="subLocality">The sub-locality or district of the user.</param>
    /// <param name="totalVideos">The total number of videos by the user.</param>
    /// <param name="uriVideos">The URI for the user's videos.</param>
    /// <param name="totalAlbums">The total number of albums by the user.</param>
    /// <param name="uriAlbums">The URI for the user's albums.</param>
    /// <param name="totalAppearances">The total number of appearances by the user.</param>
    /// <param name="uriAppearances">The URI for the user's appearances.</param>
    /// <param name="totalChannels">The total number of channels of the user.</param>
    /// <param name="uriChannels">The URI for the user's channels.</param>
    /// <param name="totalFeed">The total number of feed items for the user.</param>
    /// <param name="uriFeed">The URI for the user's feed.</param>
    /// <param name="totalFoldersRoot">The total number of root-level folders for the user.</param>
    /// <param name="uriFoldersRoot">The URI for the user's root folders.</param>
    /// <param name="totalFollowers">The total number of followers of the user.</param>
    /// <param name="uriFollowers">The URI for the user's followers.</param>
    /// <param name="totalFollowing">The total number of following users.</param>
    /// <param name="uriFollowing">The URI for the list of users the user is following.</param>
    /// <param name="totalGroups">The total number of groups the user is a member of.</param>
    /// <param name="uriGroups">The URI for the user's groups.</param>
    /// <param name="totalLikes">The total number of likes by the user.</param>
    /// <param name="uriLikes">The URI for the user's likes.</param>
    /// <param name="totalMembership">The total number of memberships the user has.</param>
    /// <param name="uriMembership">The URI for the user's memberships.</param>
    /// <param name="totalModeratedChannels">The total number of channels that the user moderates.</param>
    /// <param name="uriModeratedChannels">The URI for the channels the user moderates.</param>
    /// <param name="totalPictures">The total number of pictures associated with the user.</param>
    /// <param name="uriPictures">The URI for the user's pictures.</param>
    /// <param name="totalPortfolios">The total number of portfolios of the user.</param>
    /// <param name="uriPortfolios">The URI for the user's portfolios.</param>
    /// <param name="totalSharedVideos">The total number of videos shared by the user.</param>
    /// <param name="uriSharedVideos">The URI for the user's shared videos.</param>
    /// <param name="totalTeams">The total number of teams that the user belongs to.</param>
    /// <param name="uriTeams">The URI for the user's teams.</param>
    /// <param name="websites">A collection of website data related to the user.</param>
    public class VideoHostingUser(
        string bio,
        DateTime createdTime,
        string gender,
        string link,
        string location,
        string name,
        string shortBio,
        string uri,
        string city,
        string country,
        string countryIsoCode,
        string formattedAddress,
        double? latitude,
        double? longitude,
        string neighborhood,
        string state,
        string stateIsoCode,
        string subLocality,
        long? totalVideos,
        string uriVideos,
        long? totalAlbums,
        string uriAlbums,
        long? totalAppearances,
        string uriAppearances,
        long? totalChannels,
        string uriChannels,
        long? totalFeed,
        string uriFeed,
        long? totalFoldersRoot,
        string uriFoldersRoot,
        long? totalFollowers,
        string uriFollowers,
        long? totalFollowing,
        string uriFollowing,
        long? totalGroups,
        string uriGroups,
        long? totalLikes,
        string uriLikes,
        long? totalMembership,
        string uriMembership,
        long? totalModeratedChannels,
        string uriModeratedChannels,
        long? totalPictures,
        string uriPictures,
        long? totalPortfolios,
        string uriPortfolios,
        long? totalSharedVideos,
        string uriSharedVideos,
        long? totalTeams,
        string uriTeams,
        IEnumerable<WebsiteData> websites)
    {

        /// <summary>
        /// Gets the biography of the user.
        /// </summary>
        public string Bio { get; } = bio;

        /// <summary>
        /// Gets the creation time of the user account.
        /// </summary>
        public DateTime CreatedTime { get; } = createdTime;

        /// <summary>
        /// Gets the gender of the user.
        /// </summary>
        public string Gender { get; } = gender;

        /// <summary>
        /// Gets the absolute URI link of the user profile.
        /// </summary>
        public string Link { get; } = link;

        /// <summary>
        /// Gets the location information of the user.
        /// </summary>
        public string Location { get; } = location;

        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// Gets a short biography of the user.
        /// </summary>
        public string ShortBio { get; } = shortBio;

        /// <summary>
        /// Gets the relative URI of the user profile.
        /// </summary>
        public string Uri { get; } = uri;

        /// <summary>
        /// Gets the city where the user is located.
        /// </summary>
        public string City { get; } = city;

        /// <summary>
        /// Gets the country where the user is located.
        /// </summary>
        public string Country { get; } = country;

        /// <summary>
        /// Gets the ISO code for the user's country.
        /// </summary>
        public string CountryIsoCode { get; } = countryIsoCode;

        /// <summary>
        /// Gets the formatted address of the user.
        /// </summary>
        public string FormattedAddress { get; } = formattedAddress;

        /// <summary>
        /// Gets the latitude coordinate of the user.
        /// </summary>
        public double? Latitude { get; } = latitude;

        /// <summary>
        /// Gets the longitude coordinate of the user.
        /// </summary>
        public double? Longitude { get; } = longitude;

        /// <summary>
        /// Gets the neighborhood of the user.
        /// </summary>
        public string Neighborhood { get; } = neighborhood;

        /// <summary>
        /// Gets the state portion of the user's location.
        /// </summary>
        public string State { get; } = state;

        /// <summary>
        /// Gets the ISO code of the state.
        /// </summary>
        public string StateIsoCode { get; } = stateIsoCode;

        /// <summary>
        /// Gets the sub-locality or district of the user.
        /// </summary>
        public string SubLocality { get; } = subLocality;

        /// <summary>
        /// Gets the total number of videos by the user.
        /// </summary>
        public long? TotalVideos { get; } = totalVideos;

        /// <summary>
        /// Gets the URI for the user's videos.
        /// </summary>
        public string UriVideos { get; } = uriVideos;

        /// <summary>
        /// Gets the total number of albums by the user.
        /// </summary>
        public long? TotalAlbums { get; } = totalAlbums;

        /// <summary>
        /// Gets the URI for the user's albums.
        /// </summary>
        public string UriAlbums { get; } = uriAlbums;

        /// <summary>
        /// Gets the total number of appearances by the user.
        /// </summary>
        public long? TotalAppearances { get; } = totalAppearances;

        /// <summary>
        /// Gets the URI for the user's appearances.
        /// </summary>
        public string UriAppearances { get; } = uriAppearances;

        /// <summary>
        /// Gets the total number of channels of the user.
        /// </summary>
        public long? TotalChannels { get; } = totalChannels;

        /// <summary>
        /// Gets the URI for the user's channels.
        /// </summary>
        public string UriChannels { get; } = uriChannels;

        /// <summary>
        /// Gets the total number of feed items for the user.
        /// </summary>
        public long? TotalFeed { get; } = totalFeed;

        /// <summary>
        /// Gets the URI for the user's feed.
        /// </summary>
        public string UriFeed { get; } = uriFeed;

        /// <summary>
        /// Gets the total number of root-level folders for the user.
        /// </summary>
        public long? TotalFoldersRoot { get; } = totalFoldersRoot;

        /// <summary>
        /// Gets the URI for the user's root folders.
        /// </summary>
        public string UriFoldersRoot { get; } = uriFoldersRoot;

        /// <summary>
        /// Gets the total number of followers of the user.
        /// </summary>
        public long? TotalFollowers { get; } = totalFollowers;

        /// <summary>
        /// Gets the URI for the user's followers.
        /// </summary>
        public string UriFollowers { get; } = uriFollowers;

        /// <summary>
        /// Gets the total number of users that the user is following.
        /// </summary>
        public long? TotalFollowing { get; } = totalFollowing;

        /// <summary>
        /// Gets the URI for the list of users the user is following.
        /// </summary>
        public string UriFollowing { get; } = uriFollowing;

        /// <summary>
        /// Gets the total number of groups the user is a member of.
        /// </summary>
        public long? TotalGroups { get; } = totalGroups;

        /// <summary>
        /// Gets the URI for the user's groups.
        /// </summary>
        public string UriGroups { get; } = uriGroups;

        /// <summary>
        /// Gets the total number of likes by the user.
        /// </summary>
        public long? TotalLikes { get; } = totalLikes;

        /// <summary>
        /// Gets the URI for the user's likes.
        /// </summary>
        public string UriLikes { get; } = uriLikes;

        /// <summary>
        /// Gets the total number of memberships the user has.
        /// </summary>
        public long? TotalMembership { get; } = totalMembership;

        /// <summary>
        /// Gets the URI for the user's memberships.
        /// </summary>
        public string UriMembership { get; } = uriMembership;

        /// <summary>
        /// Gets the total number of channels that the user moderates.
        /// </summary>
        public long? TotalModeratedChannels { get; } = totalModeratedChannels;

        /// <summary>
        /// Gets the URI for the channels the user moderates.
        /// </summary>
        public string UriModeratedChannels { get; } = uriModeratedChannels;

        /// <summary>
        /// Gets the total number of pictures associated with the user.
        /// </summary>
        public long? TotalPictures { get; } = totalPictures;

        /// <summary>
        /// Gets the URI for the user's pictures.
        /// </summary>
        public string UriPictures { get; } = uriPictures;

        /// <summary>
        /// Gets the total number of portfolios of the user.
        /// </summary>
        public long? TotalPortfolios { get; } = totalPortfolios;

        /// <summary>
        /// Gets the URI for the user's portfolios.
        /// </summary>
        public string UriPortfolios { get; } = uriPortfolios;

        /// <summary>
        /// Gets the total number of videos shared by the user.
        /// </summary>
        public long? TotalSharedVideos { get; } = totalSharedVideos;

        /// <summary>
        /// Gets the URI for the user's shared videos.
        /// </summary>
        public string UriSharedVideos { get; } = uriSharedVideos;

        /// <summary>
        /// Gets the total number of teams that the user belongs to.
        /// </summary>
        public long? TotalTeams { get; } = totalTeams;

        /// <summary>
        /// Gets the URI for the user's teams.
        /// </summary>
        public string UriTeams { get; } = uriTeams;

        /// <summary>
        /// Gets the collection of website data related to the user.
        /// </summary>
        public IEnumerable<WebsiteData> Websites { get; } = websites;
    }
}
