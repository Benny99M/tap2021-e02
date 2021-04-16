using System;
using System.Collections.Generic;
using System.Text;

namespace ADIBAS.DataAccess
{
    interface IUnitOfWork
    {
        void Commit();
    }
}
