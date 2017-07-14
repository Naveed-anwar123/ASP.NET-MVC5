using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspFirstApp.Repository
{
    public interface vRecordsInterface
    {
        IQueryable vrecords();
        void deleted(int id);
    }
}
