using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Borders : IBorders
    {
        List<Borders> BorderList;
        public int BorderID { get ; set ; }

        public Borders()
        {
            BorderList = new List<Borders>();
        }

        public void AddBorder()
        {
            
        }

        public void RemoveBorder()
        {
            
        }
    }
}
