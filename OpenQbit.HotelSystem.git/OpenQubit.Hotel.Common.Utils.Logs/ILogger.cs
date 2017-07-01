using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQubit.Hotel.Common.Utils.Logs
{
    public interface ILogger
    {
        bool logError(String err);
    }
}
