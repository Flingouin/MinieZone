using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
    class EnumHelper
    {
        public static string EnumSexeConverter(EnumSexe enumSexe)
        {
            string result = string.Empty;
            switch (enumSexe)
            {
                case EnumSexe.Homme:
                    result = "Monsieur";
                    break;
                case EnumSexe.Femme:
                    result = "Madame";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
