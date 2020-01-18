using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RappelzCore.Repositories;
using RappelzCore.Repositories.Interfaces;
using RappelzCore.Services;

namespace RappelzCore.Repositories
{
    public class TESTE
    {
        public Repository<Account> account;
        
        public TESTE(Repository<Account> acc)
        {
            account = acc;
        }

        public void TESTT()
        {
            


        }
    }
}
