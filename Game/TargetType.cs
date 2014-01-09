using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter.Game
{
    /// <summary>
    /// Target type
    /// </summary>
    public struct _TargetType
    {
        /// <summary>
        /// Value
        /// </summary>
        public uint Value;
        /// <summary>
        /// Name
        /// </summary>
        public string Name;
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param1;
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param2;
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param3;
    }

    /// <summary>
    /// Event flag manager
    /// </summary>
    class TargetTypes
    {
        /// <summary>
        /// Singleton
        /// </summary>
        public static TargetTypes Instance = new TargetTypes();

        /// <summary>
        /// Flags
        /// </summary>
        public List<_TargetType> Types = new List<_TargetType>();

        /// <summary>
        /// Constructor
        /// </summary>
        public TargetTypes()
        {
            AddType(0, "None", "", "", "");
            AddType(1, "Self", "", "", "");
            AddType(2, "Victim", "", "", "");
            AddType(3, "Hostile second aggro", "", "", "");
            AddType(4, "Hostile last aggro", "", "", "");
            AddType(5, "Hostile random", "", "", "");
            AddType(6, "Hostile random not top threat", "", "", "");
            AddType(7, "Action Invoker", "", "", "");
            AddType(8, "Position", "", "", "");
            AddType(9, "Creature Range", "Entry", "Min Dist", "Max Dist");
            AddType(10, "Creature Guid", "Guid", "Entry", "");
            AddType(11, "Creature Distance", "Entry", "Max Dist", "");
            AddType(12, "Stored", "ID", "", "");
            AddType(13, "GameObject Range", "Entry", "Min Dist", "Max Dist");
            AddType(14, "GameObject Guid", "Guid", "Entry", "");
            AddType(15, "GameObject Distance", "Entry", "Max Dist", "");
            AddType(16, "Invoker Party", "", "", "");
            AddType(17, "Player Range", "Min Dist", "Max Dist", "");
            AddType(18, "Player Distance", "Max Dist", "", "");
            AddType(19, "Closet Creature", "Entry", "Max Dist", "Dead ? (0/1)");
            AddType(20, "Closet GameObject", "Entry", "Max Dist", "");
            AddType(21, "Closet Player", "Max Dist", "", "");
            AddType(22, "Action Invoker Vehicle", "", "", "");
            AddType(23, "Owner OR Summoner", "", "", "");
            AddType(24, "Threat List", "", "", "");
            AddType(25, "Closet Enemy", "Max Dist", "Player Only ? (0/1)", "");
            AddType(26, "Closet Friendly", "Max Dist", "Player Only ? (0/1)", "");
        }

        /// <summary>
        /// Get type by id
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public _TargetType GetType(uint p_Value)
        {
            foreach (var l_Type in Types)
            {
                if (l_Type.Value == p_Value)
                    return l_Type;
            }

            return new _TargetType();
        }

        /// <summary>
        /// Add type
        /// </summary>
        /// <param name="p_Value"></param>
        /// <param name="p_Name"></param>
        /// <param name="p_Param1"></param>
        /// <param name="p_Param2"></param>
        /// <param name="p_Param3"></param>
        private void AddType(uint p_Value, string p_Name, string p_Param1, string p_Param2, string p_Param3)
        {
            _TargetType l_Type = new _TargetType();
            l_Type.Value = p_Value;
            l_Type.Name = p_Name;
            l_Type.Param1 = p_Param1;
            l_Type.Param2 = p_Param2;
            l_Type.Param3 = p_Param3;

            Types.Add(l_Type);
        }
    }
}
