using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignTwitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Twitter x = new Twitter();
            x.PostTweet(1, 5);
            x.GetNewsFeed(1);
            x.Follow(1, 2);
            x.PostTweet(2, 6);
            x.GetNewsFeed(1);
            x.Unfollow(1, 2);
            x.GetNewsFeed(1);
        }
        public class Twitter
        {
            Dictionary<int, List<int>> followersMap;
            Dictionary<int, int> tweetAndPosterMap;
            List<int> userFeed;
            public Twitter()
            {
                followersMap = new Dictionary<int, List<int>>();
                tweetAndPosterMap = new Dictionary<int, int>();
                userFeed = new List<int>();
            }
            public void PostTweet(int userId, int tweetId)
            {
                if (!followersMap.ContainsKey(userId))
                    followersMap.Add(userId, new List<int>() { userId });
                else
                    followersMap[userId].Add(userId);

                tweetAndPosterMap.Add(tweetId, userId);
                userFeed.Insert(0, tweetId);
            }
            public IList<int> GetNewsFeed(int userId)
            {
                if (!followersMap.ContainsKey(userId))
                    return new List<int>();
                int count = 10;
                List<int> res = new List<int>();
                for (int i = 0; i < userFeed.Count(); i++)
                {
                    if (followersMap[userId].Contains(tweetAndPosterMap[userFeed[i]]))
                    {
                        res.Add(userFeed[i]);
                        count--;
                        if (count == 0)
                            break;
                    }
                }
                return res;
            }
            public void Follow(int followerId, int followeeId)
            {
                if (!followersMap.ContainsKey(followerId))
                    followersMap.Add(followerId, new List<int>() { followeeId });
                else
                    followersMap[followerId].Add(followeeId);
            }
            public void Unfollow(int followerId, int followeeId)
                => followersMap[followerId].Remove(followeeId);
        }
    }
}
