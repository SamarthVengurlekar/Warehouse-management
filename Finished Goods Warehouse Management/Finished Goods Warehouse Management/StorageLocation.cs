using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finished_Goods_Warehouse_Management
{
    internal class StorageLocation
    {
        public int Building;
        public string Aisle;
        public int Bay;
        public string Tier;
        public int Position;
        public string primarykey;

        public void createLocationId()
        {
            primarykey = Building + "-" + Aisle + "-" + Bay + "-" + Tier + "-" + Position;
        }

        public string getPrimaryKey() { return primarykey; }
    }
}
