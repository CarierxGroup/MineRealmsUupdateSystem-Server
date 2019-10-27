using System;
using System.Collections.Generic;
using System.Text;
using MRUS.Core;

namespace MRUS.Server
{
    internal class MRUSService : MarshalByRefObject, IMRUSService
    {
        private UpdateConfiguration fileConfig;
        public MRUSService(UpdateConfiguration _fileConfig)
        {
            this.fileConfig = _fileConfig;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public int GetLatestVersion()
        {
            return this.fileConfig.ClientVersion;
        }
    }
}
