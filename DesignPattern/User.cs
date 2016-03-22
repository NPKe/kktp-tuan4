using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    enum ProfileType { Basic, VIP };
    class User
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        private Profile profile;

        private ProfileType profileType;

        public bool CheckCanDownload()
        {
            return profile.CheckCanDownload();
        }

        public bool CheckNumberOfValidConnection(int numOfConnection)
        {
            return profile.CheckValidDownloadConnection(numOfConnection);
        }

        public void Upgrade()
        {
            if (profileType == ProfileType.Basic)
                profile = new VIP();
        }

        public void Downgrade()
        {
            if (profileType == ProfileType.VIP)
                profile = new Basic();
        }
    }
}
