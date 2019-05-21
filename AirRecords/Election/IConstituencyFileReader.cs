using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election
{
    public interface IConstituencyFileReader
    {
        Location ReadConstituencyDataFromFile(ConfigRecord configRecord);
    }
}
