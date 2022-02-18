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
                new Panel{Name = "Apple", BackColor=System.Drawing.Color.Red },
                new Panel{Name = "Gomu-Gomu", BackColor = System.Drawing.Color.Purple},
                new Panel{Name = "Banana", BackColor = System.Drawing.Color.Yellow },
            };
        
            
   
        
        }
       
    }

  
}
