using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspFirstApp.Repository
{
    public interface RequestInterface
    {
        void accepted(int id);
        void rejected(int id);
    }
}
