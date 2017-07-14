using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspFirstApp.Repository
{
    public interface RecordsInterface
    {
        IQueryable viewrecords(string email);
    }
}
