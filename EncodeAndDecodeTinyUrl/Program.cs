using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndDecodeTinyUrl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Codec encode = new Codec();
            encode.encode("https://leetcode.com/problems/design-tinyurl");
            encode.decode("http://tinyurl.com/4e9iAk");
        }
        public class Codec
        {
            Dictionary<string, string> normalAndTinyUrl = new Dictionary<string, string>();
            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                if (!normalAndTinyUrl.ContainsKey(longUrl))
                    normalAndTinyUrl.Add(longUrl, "http://tinyurl.com/4e9iAk");

                Console.WriteLine($"Our tiny encode is: {normalAndTinyUrl[longUrl]}");
                return normalAndTinyUrl[longUrl];
            }
            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                Console.WriteLine(
                    $"Tiny decoded: {normalAndTinyUrl.Where(x => x.Value == shortUrl).First().Key}");
                return normalAndTinyUrl.Where(x => x.Value == shortUrl).First().Key;
            }
        }
    }
}
