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
    public struct _ActionType
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
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param4;
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param5;
        /// <summary>
        /// Parameter description
        /// </summary>
        public string Param6;
    }

    /// <summary>
    /// Event flag manager
    /// </summary>
    class ActionTypes
    {
        /// <summary>
        /// Singleton
        /// </summary>
        public static ActionTypes Instance = new ActionTypes();

        /// <summary>
        /// Flags
        /// </summary>
        public List<_ActionType> Types = new List<_ActionType>();

        /// <summary>
        /// Constructor
        /// </summary>
        public ActionTypes()
        {
            AddType(1, "None", "", "", "", "", "", "");
            AddType(2, "Talk", "Creature_text.groupid", "duration to wait before TEXT_OVER event is triggered", "", "", "", "");
            AddType(3, "Set Faction", "FactionID (or 0 for default)", "", "", "", "", "");
            AddType(4, "Morph To Entry Or Model", "Creature_template.entry", "Creature_template.modelID", "", "", "", "");
            AddType(5, "Sound", "Sound ID", "Only Self", "", "", "", "");
            AddType(6, "Play Emote", "Emote ID", "", "", "", "", "");
            AddType(7, "Fail Quest", "Quest ID", "", "", "", "", "");
            AddType(8, "Add Quest", "Quest ID", "", "", "", "", "");
            AddType(9, "Set React State", "State", "", "", "", "", "");
            AddType(10, "Activate GameObject", "", "", "", "", "", "");
        }

        /// <summary>
        /// Get type by id
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public _ActionType GetType(uint p_Value)
        {
            foreach (var l_Type in Types)
            {
                if (l_Type.Value == p_Value)
                    return l_Type;
            }

            return new _ActionType();
        }

        /// <summary>
        /// Add type
        /// </summary>
        /// <param name="p_Value"></param>
        /// <param name="p_Name"></param>
        /// <param name="p_Param1"></param>
        /// <param name="p_Param2"></param>
        /// <param name="p_Param3"></param>
        /// <param name="p_Param4"></param>
        /// <param name="p_Param5"></param>
        /// <param name="p_Param6"></param>
        private void AddType(uint p_Value, string p_Name, string p_Param1, string p_Param2, string p_Param3, string p_Param4, string p_Param5, string p_Param6)
        {
            _ActionType l_Type = new _ActionType();
            l_Type.Value    = p_Value;
            l_Type.Name     = p_Name;
            l_Type.Param1   = p_Param1;
            l_Type.Param2   = p_Param2;
            l_Type.Param3   = p_Param3;
            l_Type.Param4   = p_Param4;
            l_Type.Param5   = p_Param5;
            l_Type.Param6   = p_Param6;

            Types.Add(l_Type);
        }
    }
}
