using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCPPWoWSmartScripter.Framework
{
    /// <summary>
    /// Class for i/o or text formating
    /// </summary>
    class Formating
    {
        /// <summary>
        /// Recursive update extended contexts
        /// </summary>
        /// <param name="p_Name"></param>
        /// <param name="p_Var"></param>
        /// <param name="p_ParentNode"></param>
        public static void ContextVarToTreeNode(string p_Name, ContextVar p_Var, object p_ParentNode, List<String> p_AutoExpand)
        {
            if (p_Var.IsArray == true)
            {
                int l_MaxLenght = 0;

                foreach (var l_Pair in p_Var.Nodes)
                {
                    if (l_Pair.Key.Length > l_MaxLenght)
                        l_MaxLenght = l_Pair.Key.Length;
                }

                string l_SpaceBuffer = "";

                for (int l_I = 0; l_I < l_MaxLenght; l_I++)
                    l_SpaceBuffer += " ";

                foreach (var l_Pair in p_Var.Nodes)
                {
                    if (l_Pair.Value.IsArray == false)
                    {
                        if (p_ParentNode.GetType() == typeof(TreeView))
                            ((TreeView)p_ParentNode).Nodes.Add(l_Pair.Key + l_SpaceBuffer.Substring(l_Pair.Key.Length) + " => [" + l_Pair.Value.Value + "]");
                        else
                            ((TreeNode)p_ParentNode).Nodes.Add(l_Pair.Key + l_SpaceBuffer.Substring(l_Pair.Key.Length) + " => [" + l_Pair.Value.Value + "]");
                    }
                    else
                    {
                        TreeNode l_Node = new TreeNode(l_Pair.Key);

                        ContextVarToTreeNode(l_Pair.Key, l_Pair.Value, l_Node, p_AutoExpand);

                        if (p_AutoExpand.Contains(l_Pair.Key))
                            l_Node.Expand();

                        if (p_ParentNode.GetType() == typeof(TreeView))
                            ((TreeView)p_ParentNode).Nodes.Add(l_Node);
                        else
                            ((TreeNode)p_ParentNode).Nodes.Add(l_Node);
                    }
                }
            }
            else if (p_Name != "root")
            {
                ((TreeNode)p_ParentNode).Nodes.Add(p_Name + " [" + p_Var.Value + "]");
            }
        }

        /// <summary>
        /// Parse decimal or hex string number to dec int
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static Int32 StringToInt32(string p_Value)
        {
            if (p_Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                p_Value = p_Value.Substring(2);
                return Int32.Parse(p_Value, System.Globalization.NumberStyles.HexNumber);
            }

            return Int32.Parse(p_Value);
        }
        /// <summary>
        /// Parse decimal or hex string number to dec int
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static UInt32 StringToUInt32(string p_Value)
        {
            if (p_Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                p_Value = p_Value.Substring(2);
                return UInt32.Parse(p_Value, System.Globalization.NumberStyles.HexNumber);
            }

            return UInt32.Parse(p_Value);
        }
        /// <summary>
        /// Parse decimal or hex string number to dec int
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static Int64 StringToInt64(string p_Value)
        {
            if (p_Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                p_Value = p_Value.Substring(2);
                return Int64.Parse(p_Value, System.Globalization.NumberStyles.HexNumber);
            }

            return Int64.Parse(p_Value);
        }
        /// <summary>
        /// Parse decimal or hex string number to dec int
        /// </summary>
        /// <param name="p_Value"></param>
        /// <returns></returns>
        public static UInt64 StringToUInt64(string p_Value)
        {
            if (p_Value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                p_Value = p_Value.Substring(2);
                return UInt64.Parse(p_Value, System.Globalization.NumberStyles.HexNumber);
            }

            return UInt64.Parse(p_Value);
        }
    }
}
