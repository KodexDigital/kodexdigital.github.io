using Microsoft.EntityFrameworkCore;
using Resume.Persistence.Data;
using Resume.Persistence.Data.Context;
using Shyjus.BrowserDetection;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Resume.Services.Services
{
    public class LikeResumeService
    {
        private readonly KEODbContext context;
        private readonly IBrowserDetector browserDetector;

        private string IpAddress { get; set; } = null;
        private string Host { get; set; } = null;
        public LikeResumeService(KEODbContext context, IBrowserDetector browserDetector)
        {
            this.context = context;
            this.browserDetector = browserDetector;
            Host = Dns.GetHostName();
            IpAddress = Dns.GetHostEntry(Host).AddressList[0].ToString();
        }

        public async Task LikeResume()
        {
            var devicetype = browserDetector.Browser.DeviceType;
            var os = browserDetector.Browser.OS;
            var browser = browserDetector.Browser.Name;

            var like = new ResumeLike
            {
                SystemName = Host,
                SystemOS = $"{devicetype} | {os} | {browser}" ,
                IPAddress = IpAddress,
                Date = DateTime.Today,
                IsLiked = true,
                Counter = 1
            };
            await context.Likes.AddAsync(like);
            await context.SaveChangesAsync();

        }

        public async Task<bool> IsResmueLiked()
        {
            var isLiked = await context.Likes.AnyAsync(x => x.IPAddress.Equals(IpAddress) && x.IsLiked);
            if (isLiked)
                return true;
            return false;
        }

        public async Task<ResumeLike[]> FetchAllLikesAsyn()
        {
            var likes = await context.Likes.ToListAsync();
            return likes.ToArray();
        }
    }
}
