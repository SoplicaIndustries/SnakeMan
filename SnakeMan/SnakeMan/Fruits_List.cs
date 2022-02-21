using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMan
{
    class Fruits_List
    {
        public static List<Panel> GetList()
        {
            return new List<Panel>
            {
                new Panel{Name = "Apple", BackColor=System.Drawing.Color.Red, AccessibleDescription = "Normal"},
                new Panel{Name = "Black berry", BackColor = System.Drawing.Color.Purple, AccessibleDescription = "Debuff"},
                new Panel{Name = "Banana", BackColor = System.Drawing.Color.Yellow, AccessibleDescription = "Buff"}

            };
            
            
   
        
        }
       
    }

  
}
