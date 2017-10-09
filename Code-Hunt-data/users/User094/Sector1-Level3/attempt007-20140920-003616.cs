using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
	              if (x.GetTypeCode().ToString() == "0x02")
            {
                return true;
            }
            else if (z.GetTypeCode().ToString() == "0x02")
            {
                return true;
            }
            else
            {
                return true;
            }
	  
  }
}