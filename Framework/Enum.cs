using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter.Framework
{
    /// <summary>
    /// Enums tools
    /// </summary>
    class Enum
    {
        /// <summary>
        /// Return list of all flags name present in a field flag
        /// </summary>
        /// <param name="p_Value">Flags value</param>
        /// <param name="p_Type">Type of enum</param>
        /// <returns>List of all present flags name</returns>
        public static List<string> GetPresentFlags(UInt32 p_Value, Type p_Type)
        {
            List<string> l_Out = new List<string>();

            string[] l_Names = System.Enum.GetNames(p_Type);
            Array l_Values = System.Enum.GetValues(p_Type);

            for (int l_I = 0; l_I < l_Values.Length; l_I++)
            {
                if ((p_Value & (uint)l_Values.GetValue(l_I)) != 0)
                    l_Out.Add(l_Names[l_I]);
            }

            return l_Out;
        }
    }
}
