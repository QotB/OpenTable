using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTable
{
    class log_in
    {
        public static bool logged_in = false;
       public static string User_Email;
        public static Dictionary<string, int> occasions=new Dictionary<string, int>();
        public static void store()
        {
            log_in.occasions.Add("Birthday", 0);
            log_in.occasions.Add("Anniversary", 1);
            log_in.occasions.Add("Date night", 2);
            log_in.occasions.Add("Business Meal", 3);
            log_in.occasions.Add("Celebration", 4);
        }
    }
}
