﻿using System;
using System.Collections.Generic;
using System.Text;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Data
{
    public class ServiceInitialize : RappelzService
    {
        protected ArcadiaContext arcadiaContext;
        protected AuthContext authContext;
        protected BillingContext billingContext;
        protected TelecasterContext telecasterContext;

        public ServiceInitialize(ArcadiaContext arcadiaContext, AuthContext authContext, BillingContext billingContext, TelecasterContext telecasterContext) : base(arcadiaContext,authContext,billingContext, telecasterContext)
        {
        }
        
    }
}
