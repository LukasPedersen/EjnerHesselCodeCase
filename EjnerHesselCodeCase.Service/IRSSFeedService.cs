using EjnerHesselCodeCase.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjnerHesselCodeCase.Service
{
    public interface IRSSFeedService
    {
        public AuthorPosts AllPosts(string authorId);
        public IEnumerable<Feed> LatestPosts();
        public IEnumerable<Feed> FeaturedPosts();
        public IEnumerable<Feed> TrendingPosts();
    }
}
