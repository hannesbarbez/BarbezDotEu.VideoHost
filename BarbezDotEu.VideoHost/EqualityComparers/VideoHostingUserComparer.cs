// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using BarbezDotEu.VideoHost.DTO;

namespace BarbezDotEu.VideoHost.EqualityComparers
{
    /// <summary>
    /// Implements a comparer for <see cref="VideoHostingUser"/> that compares users based on their link.
    /// </summary>
    public class VideoHostingUserComparer : IEqualityComparer<VideoHostingUser>
    {
        /// <inheritdoc/>
        public bool Equals([AllowNull] VideoHostingUser x, [AllowNull] VideoHostingUser y)
        {
            return x.Link.EndsWith(y.Link, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <inheritdoc/>
        public int GetHashCode([DisallowNull] VideoHostingUser obj)
        {
            return obj.Link.ToLowerInvariant().GetHashCode();
        }
    }
}
