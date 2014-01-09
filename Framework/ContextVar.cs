using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCPPWoWSmartScripter.Framework
{
    /// <summary>
    /// Context var
    /// </summary>
    class ContextVar
    {
        /// <summary>
        /// Normal node value
        /// </summary>
        public String Value { get; set; }
        /// <summary>
        /// Array sub nodes
        /// </summary>
        public Dictionary<String, ContextVar> Nodes;
        /// <summary>
        /// Is array
        /// </summary>
        public bool IsArray { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ContextVar()
        {
            Value = "";
            IsArray = false;
            Nodes = new Dictionary<String, ContextVar>();
        }

        /// <summary>
        /// Set subnode value
        /// </summary>
        /// <param name="p_Name"></param>
        /// <param name="p_Data"></param>
        public ContextVar SetValue(string p_Name, ContextVar p_Data)
        {
            IsArray = true;
            Nodes[p_Name] = p_Data;

            return this;
        }

        /// <summary>
        /// Set subnode value
        /// </summary>
        /// <param name="p_Name"></param>
        /// <param name="p_Data"></param>
        public ContextVar SetValue(string p_Name, string p_Value)
        {
            if (p_Name == null)
                return this;

            IsArray = true;
            Nodes[p_Name] = new ContextVar { Value = p_Value };

            return this;
        }

        /// <summary>
        /// Set subnode value
        /// </summary>
        /// <param name="p_Name"></param>
        /// <param name="p_Data"></param>
        public ContextVar SetValue<T>(string p_NamePrefix, List<T> p_Value)
        {
            if (p_NamePrefix == null || p_Value == null)
                return this;

            IsArray = true;

            uint l_I = 0;

            foreach (var l_Current in p_Value)
                Nodes[p_NamePrefix + (l_I++).ToString()] = new ContextVar { Value = l_Current.ToString() };

            return this;
        }

        /// <summary>
        /// Set this node value
        /// </summary>
        /// <param name="p_Value"></param>
        public ContextVar SetValue(string p_Value)
        {
            IsArray = false;
            Nodes.Clear();
            Value = p_Value;

            return this;
        }

        /// <summary>
        /// Remove value
        /// </summary>
        /// <param name="p_Name"></param>
        public ContextVar RemoveValue(string p_Name)
        {
            if (Nodes.ContainsKey(p_Name))
                Nodes.Remove(p_Name);

            return this;
        }

        /// <summary>
        /// Clone this context var
        /// </summary>
        /// <returns></returns>
        public ContextVar Clone()
        {
            ContextVar l_Out = new ContextVar();

            l_Out.IsArray = IsArray ? true : false;
            l_Out.Value = (String)Value.Clone();

            foreach (var l_Pair in Nodes)
                l_Out.Nodes.Add(l_Pair.Key, l_Pair.Value.Clone());

            return l_Out;
        }
    }
}
