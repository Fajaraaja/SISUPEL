using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISUPEL.Config
{
    abstract class ConfigCls
    {
        public abstract DataTable eksekusiQuery(String query);

        public abstract int eksekusiNonQuery(String query);
    }
}
