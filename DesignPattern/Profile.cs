using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Profile
    {
        protected int maxDownloadTimes;
        protected int maxConnections;
        protected int DownloadedTimes;

        public bool CheckCanDownload()
        {
            if (DownloadedTimes < maxDownloadTimes)
                return true;
            return false;
        }

        public int CheckDownloadedTimes()
        {
            return DownloadedTimes;
        }

        public bool CheckValidDownloadConnection(int numOfConnection)
        {
            if (numOfConnection <= maxConnections)
                return true;
            return false;
        }
    }

    class Basic : Profile
    {
        public Basic()
        {
            maxConnections = 1;
            DownloadedTimes = 0;
            maxDownloadTimes = 1;
        }
    }

    class VIP : Profile
    {
        public VIP()
        {
            maxConnections = 20;
            DownloadedTimes = -1;
            maxDownloadTimes = 1;
        }
    }
}
