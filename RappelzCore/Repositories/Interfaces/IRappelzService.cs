using System;
using System.Collections.Generic;
using System.Text;
using RappelzCore.Data;

namespace RappelzCore.Repositories.Interfaces
{
    public class IRappelzService<TService>
    {
        private AuthContext auth;

        public IRappelzService(AuthContext auth)
        {
            this.auth = auth;
        }
    }
}
