using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter.Game
{
    /// <summary>
    /// Event flag
    /// </summary>
    public struct _EventFlag
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
        /// Description
        /// </summary>
        public string Description;
    }

    /// <summary>
    /// Event flag manager
    /// </summary>
    class EventFlags
    {
        /// <summary>
        /// Singleton
        /// </summary>
        public static EventFlags Instance = new EventFlags();

        /// <summary>
        /// Flags
        /// </summary>
        public List<_EventFlag> Flags = new List<_EventFlag>();

        /// <summary>
        /// Constructor
        /// </summary>
        public EventFlags()
        {
            AddFlag(0x01, "Not Repeatable", "Event can not repeat");
            AddFlag(0x02, "Difficulty 0", "Event only occurs in normal dungeon");
            AddFlag(0x04, "Difficulty 1", "Event only occurs in heroic dungeon");
            AddFlag(0x08, "Difficulty 2", "Event only occurs in normal raid");
            AddFlag(0x10, "Difficulty 3", "Event only occurs in heroic raid");
            AddFlag(0x80, "Debug Only", "Event only occurs in debug build");
        }

        /// <summary>
        /// Add flag
        /// </summary>
        /// <param name="p_Value"></param>
        /// <param name="p_Name"></param>
        /// <param name="p_Description"></param>
        private void AddFlag(uint p_Value, string p_Name, string p_Description)
        {
            _EventFlag l_Flag = new _EventFlag();
            l_Flag.Value        = p_Value;
            l_Flag.Name         = p_Name;
            l_Flag.Description  = p_Description;

            Flags.Add(l_Flag);
        }
    }
}
