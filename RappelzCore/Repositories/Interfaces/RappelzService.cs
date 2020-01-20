using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RappelzCore.Data;

namespace RappelzCore.Repositories.Interfaces
{
    public abstract class RappelzService
    {
        protected ArcadiaContext _arcadiaContext { get; set; }
        protected AuthContext _authContext { get; set; }
        protected BillingContext _billingContext { get; set; }
        protected TelecasterContext _telecasterContext { get; set; }

        protected RappelzService(ArcadiaContext arcadiaContext, AuthContext authContext, BillingContext billingContext, TelecasterContext telecasterContext)
        {
            _arcadiaContext = arcadiaContext;
            _authContext = authContext;
            _billingContext = billingContext;
            _telecasterContext = telecasterContext;
        }


        //Ready to implements CRUD methods
        public void TESTAR()
        {
            var g = _authContext.Account.FirstOrDefault();
            var gg = _authContext.Account.FirstOrDefault();
            var ggg = _authContext.Account.FirstOrDefault();
            var gggg = _authContext.Account.FirstOrDefault();
        }
    }
}
