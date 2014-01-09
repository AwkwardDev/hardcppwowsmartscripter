using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter
{
    /// <summary>
    /// Script Event
    /// </summary>
    public class ScriptEvent
    {
        /// <summary>
        /// Order
        /// </summary>
        public uint ID;
        /// <summary>
        /// Proc chance
        /// </summary>
        public uint Chance      = 100;
        /// <summary>
        /// Phase mask
        /// </summary>
        public uint PhaseMask   = 0;
        /// <summary>
        /// Event flags
        /// </summary>
        public uint EventFlags  = 0;
        /// <summary>
        /// Event type
        /// </summary>
        public uint EventType   = 0;
        /// <summary>
        /// Description
        /// </summary>
        public string Comment   = "";
        /// <summary>
        /// Event params
        /// </summary>
        public uint[] Params    = new uint[4] { 0, 0, 0, 0 };

        /// <summary>
        /// Event sub events
        /// </summary>
        public List<ScriptEvent> SubEvents = new List<ScriptEvent>();
        /// <summary>
        /// Event actions
        /// </summary>
        public List<ScriptAction> Actions = new List<ScriptAction>();
    }

    /// <summary>
    /// Script Action
    /// </summary>
    public class ScriptAction
    {
        /// <summary>
        /// Order
        /// </summary>
        public uint ID;
        /// <summary>
        /// Action type
        /// </summary>
        public uint Type = 0;
        /// <summary>
        /// Action params
        /// </summary>
        public uint[] Params = new uint[6] { 0, 0, 0, 0, 0, 0 };
        /// <summary>
        /// Target type
        /// </summary>
        public uint TargetType = 0;
        /// <summary>
        /// Target params
        /// </summary>
        public uint[] TargetParams = new uint[3] { 0, 0, 0 };
        /// <summary>
        /// Target position X
        /// </summary>
        public float TargetX = 0;
        /// <summary>
        /// Target position Y
        /// </summary>
        public float TargetY = 0;
        /// <summary>
        /// Target position Z
        /// </summary>
        public float TargetZ = 0;
        /// <summary>
        /// Target orientation
        /// </summary>
        public float TargetO = 0;
        /// <summary>
        /// Description
        /// </summary>
        public string Comment = "";
    }

    /// <summary>
    /// SmartAI Script
    /// </summary>
    public class Script
    {
        /// <summary>
        /// Events list (root node)
        /// </summary>
        public static List<ScriptEvent> Events = new List<ScriptEvent>();

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Clear current script
        /// </summary>
        public static void Clear()
        {
            Events.Clear();
            m_ID = 0;
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Generate ID
        /// </summary>
        /// <returns></returns>
        public static uint GenerateID()
        {
            return m_ID++;
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Get event by id
        /// </summary>
        /// <param name="p_ID"></param>
        /// <returns></returns>
        public static ScriptEvent GetEvent(uint p_ID)
        {
            bool l_Found = false;

            foreach (var l_Event in Events)
            {
                ScriptEvent l_Result = _GetEvent(p_ID, l_Event, ref l_Found);
    
                if (l_Found)
                    return l_Result;
            }

            return null;
        }
        /// <summary>
        /// Delete event by ID
        /// </summary>
        /// <param name="p_ID"></param>
        public static void DeleteEvent(uint p_ID)
        {
            bool l_Found = false;

            foreach (var l_Event in Events)
            {
                if (l_Event.ID == p_ID)
                {
                    Events.Remove(l_Event);
                    return;
                }

                _DeleteEvent(p_ID, l_Event, ref l_Found);

                if (l_Found)
                    return;
            }
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Internal recursive get event
        /// </summary>
        /// <param name="p_ID"></param>
        /// <param name="p_Current"></param>
        /// <param name="p_Found"></param>
        /// <returns></returns>
        private static ScriptEvent _GetEvent(uint p_ID, ScriptEvent p_Current, ref bool p_Found)
        {
            if (p_Current.ID == p_ID)
            {
                p_Found = true;
                return p_Current;
            }

            foreach (var l_SubEvent in p_Current.SubEvents)
            {
                ScriptEvent l_Result = _GetEvent(p_ID, l_SubEvent, ref p_Found);

                if (p_Found)
                    return l_Result;
            }

            return null;
        }
        /// <summary>
        /// Internal recursive delete event
        /// </summary>
        /// <param name="p_ID"></param>
        /// <param name="p_Current"></param>
        /// <param name="p_Found"></param>
        private static void _DeleteEvent(uint p_ID, ScriptEvent p_Current, ref bool p_Found)
        {
            foreach (var l_SubEvent in p_Current.SubEvents)
            {
                if (l_SubEvent.ID == p_ID)
                {
                    p_Current.SubEvents.Remove(l_SubEvent);
                    return;
                }

                _DeleteEvent(p_ID, l_SubEvent, ref p_Found);

                if (p_Found)
                    return;
            }

            return;
        }

        #region Data
        /// <summary>
        /// ID Generator
        /// </summary>
        private static uint m_ID = 0;
        #endregion
    }
}
