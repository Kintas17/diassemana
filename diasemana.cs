using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diadasemana
{
    class diasemana
    {
        private DateTime data = new DateTime().Date;

        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                return "O dia da semana em que você nasceu foi " + data.ToString("dddddd");
            }
        }
    }

}
