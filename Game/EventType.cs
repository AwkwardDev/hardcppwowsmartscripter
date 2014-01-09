using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter.Game
{
    /// <summary>
    /// Event type
    /// </summary>
    public struct _EventType
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
    }

    /// <summary>
    /// Event flag manager
    /// </summary>
    class EventTypes
    {
        /// <summary>
        /// Singleton
        /// </summary>
        public static EventTypes Instance = new EventTypes();

        /// <summary>
        /// Flags
        /// </summary>
        public List<_EventType> Types = new List<_EventType>();

        /// <summary>
        /// Constructor
        /// </summary>
        public EventTypes()
        {
            AddType(0, "Update in combat",      "Initial Min",  "Initial Max",  "Repeat Min",           "Repeat Max");
            AddType(1, "Update out of combat",  "Initial Min",  "Initial Max",  "Repeat Min",           "Repeat Max");
            AddType(2, "Health Percent",        "HP Min %",     "HP Max %",     "Repeat Min",           "Repeat Max");
            AddType(3, "Mana Percent",          "Mana Min %",   "Mana Max %",   "Repeat Min",           "Repeat Max");
            AddType(4, "Aggro",                 "",             "",             "",                     "");
            AddType(5, "Kill",                  "Cooldown Min", "Cooldown Max", "Player only (0/1)",    "Creature entry (if param3 is 0)");
            AddType(6, "Death",                 "",             "",             "",                     "");
            AddType(7, "Evade",                 "",             "",             "",                     "");
            AddType(8, "Spell Hit",             "Spell ID",     "School",       "Cooldown Min",         "Cooldown Max");
            AddType(9, "Range",                 "Min Distance", "Max Distance", "Repeat Min",           "Repeat Max");

            AddType(10, "Target Out of combat in line of sight",    "No Hostile",           "Max Range",    "Cooldown Min",         "Cooldown Max");
            AddType(11, "Respawn",                                  "Type",                 "Map ID",       "Zone ID",              "");
            AddType(12, "Target Health Percent",                    "HPMin %",              "HPMax %",      "Repeat Min",           "Repeat Max");
            AddType(13, "Victim Casting",                           "Repeat Min",           "Repeat Max",   "Spell ID (0 If Any)",  "");
            AddType(14, "Friendly Health",                          "HP Deficit",           "Radius",       "Repeat Min",           "Repeat Max");
            AddType(15, "Friendly Is Crowd Controlled",             "Radius",               "Repeat Min",   "Repeat Max",           "");
            AddType(16, "Friendly Missing Buff",                    "Spell Id",             "Radius",       "Repeat Min",           "Repeat Max");
            AddType(17, "Summoned Unit",                            "Creture Id (0 all)",   "Cooldown Min", "Cooldown Max",         "");
            AddType(18, "Target Mana Percent",                      "Mana Min %",           "Mana Max %",   "Repeat Min",           "Repeat Max");
            AddType(19, "Accepted Quest",                           "Quest ID (0 any)",     "",             "",                     "");

            AddType(20, "Reward Quest",                 "Quest ID (0 any)", "",             "",             "");
            AddType(21, "Reached Home",                 "",                 "",             "",             "");
            AddType(22, "Receive Emote",                "Emote Id",         "Cooldown Min", "Cooldown Max", "Condition");
            AddType(23, "Has Aura",                     "Spell ID",         "Stacks",       "Repeat Min",   "Repeat Max");
            AddType(24, "Target Buffed",                "Spell ID",         "Stacks",       "Repeat Min",   "Repeat Max");
            AddType(25, "Reset",                        "",                 "",             "",             "");
            AddType(26, "In Combat in line of sight",   "No Hostile",       "Max Range",    "Cooldown Min", "Cooldown Max");
            AddType(27, "Passenger Boarded",            "Cooldown Min",     "Cooldown Max", "",             "");
            AddType(28, "Passenger Removed",            "Cooldown Min",     "Cooldown Max", "",             "");
            AddType(29, "Charmed",                      "",                 "",             "",             "");

            AddType(30, "Charmed Target",   "",                     "",                 "",             "");
            AddType(31, "Spell Hit Target", "Spell ID",             "School",           "Repeat Min",   "Repeat Max");
            AddType(32, "Damaged",          "Min Dmg",              "Max Dmg",          "Repeat Min",   "Repeat Max");
            AddType(33, "Damaged Target",   "Min Dmg",              "Max Dmg",          "Repeat Min",   "Repeat Max");
            AddType(34, "Movement Inform",  "Movement Type (any)",  "Point ID",         "",             "");
            AddType(35, "Summon Despawned", "Entry",                "Cooldown Min",     "Cooldown Max", "");
            AddType(36, "Corpse Removed",   "",                     "",                 "",             "");
            AddType(37, "AI Init",          "",                     "",                 "",             "");
            AddType(38, "Data Set",         "Field",                "Value",            "Cooldown Min", "Cooldown Max");
            AddType(39, "Waypoint Start",   "Point Id (0 any)",     "Path Id (0 any)",  "",             "");

            AddType(40, "Waypoint Reached",         "Point Id (0 any)",     "Path Id (0 any)",  "",             "");
            AddType(41, "Transport Add Player",     "",                     "",                 "",             "");
            AddType(42, "Transport Add Creature",   "Entry (0 any)",        "",                 "",             "");
            AddType(43, "Transport Remove Player",  "",                     "",                 "",             "");
            AddType(44, "Transport Relocate",       "Point Id",             "",                 "",             "");
            AddType(45, "Instance Player Enter",    "Team (0 any)",         "Cooldown Min",     "Cooldown Max", "");
            AddType(46, "AreaTrigger On Trigger",   "Trigger Id (0 any)",   "",                 "",             "");
            AddType(47, "Quest Accepted",           "",                     "",                 "",             "");
            AddType(48, "Quest Obj Completion",     "",                     "",                 "",             "");
            AddType(49, "Quest Completion",         "",                     "",                 "",             "");

            AddType(50, "Quest Rewarded",       "",                             "",                     "",             "");
            AddType(51, "Quest Fail",           "",                             "",                     "",             "");
            AddType(52, "Text Over",            "Group Id (from creatue_text)", "Creature Id (0 any)",  "",              "");
            AddType(53, "Receive Mail",         "Min Heal",                     "Max Heal",             "Cooldown Min", "Cooldown Max");
            AddType(54, "Just Summoned",        "",                             "",                     "",             "");
            AddType(55, "Waypoint Paused",      "Point Id (0 any)",             "Path Id (0 any)",      "",             "");
            AddType(56, "Waypoint Resumed",     "Point Id (0 any)",             "Path Id (0 any)",      "",             "");
            AddType(57, "Waypoint Stopped",     "Point Id (0 any)",             "Path Id (0 any)",      "",             "");
            AddType(58, "Waypoint Ended",       "Point Id (0 any)",             "Path Id (0 any)",      "",             "");
            AddType(59, "Time Event Triggered", "Id",                           "",                     "",             "");

            AddType(60, "Update",           "Initial Min",              "Initial Max",  "Repeat Min", "Repeat Max");
            AddType(61, "Link",             "",                         "",             "",             "");
            AddType(62, "Gossip Select",    "menu_ID",                  "ID",           "",             "");
            AddType(63, "Just Created",     "",                         "",             "",             "");
            AddType(64, "Gossip Hello",     "",                         "",             "",             "");
            AddType(65, "Follow Completed", "",                         "",             "",             "");
            AddType(66, "Dummy Efect",      "spell Id",                 "effect Index", "",             "");
            AddType(67, "Is Behind Target", "Cooldown Min",             "Cooldown Max", "",             "");
            AddType(68, "Game Event Start", "game_event.eventEntry",    "",             "",             "");
            AddType(69, "Game Event End",   "game_event.eventEntry",    "",             "",             "");

            AddType(70, "Go State Changed",         "State (0 - Active, 1 - Ready, 2 - Active alternative)",    "",         "",             "");
            AddType(71, "Go Event Inform",          "Event Id",                                                 "",         "",             "");
            AddType(72, "Action Done",              "Event Id",                                                 "",         "",             "");
            AddType(73, "On Spell Click",           "",                                                         "",         "",             "");
            AddType(74, "Friendly Health Percent",  "Min HP %",                                                 "Max HP %", "Repeat Min",   "Repeat Max");
        }

        /// <summary>
        /// Get type by id
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public _EventType GetType(uint p_Value)
        {
            foreach (var l_Type in Types)
            {
                if (l_Type.Value == p_Value)
                    return l_Type;
            }

            return new _EventType();
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
        private void AddType(uint p_Value, string p_Name, string p_Param1, string p_Param2, string p_Param3, string p_Param4)
        {
            _EventType l_Type = new _EventType();
            l_Type.Value    = p_Value;
            l_Type.Name     = p_Name;
            l_Type.Param1   = p_Param1;
            l_Type.Param2   = p_Param2;
            l_Type.Param3   = p_Param3;
            l_Type.Param4   = p_Param4;

            Types.Add(l_Type);
        }
    }
}
