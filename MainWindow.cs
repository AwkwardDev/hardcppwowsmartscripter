using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCPPWoWSmartScripter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BuildScriptEventView(ScriptEvent p_Event, Framework.ContextVar p_Parent, bool p_First = false)
        {
            string  l_Name = "";
            var     l_Type = Game.EventTypes.Instance.GetType(p_Event.EventType);

            if (!p_First)
                l_Name = "[EVENT.ID=" + p_Event.ID.ToString() + "][" + l_Type.Name + "] => " + p_Event.Comment.Replace("\\n", " | ");

            Framework.ContextVar l_Var = p_First ? p_Parent : new Framework.ContextVar();

            l_Var.SetValue("Type", l_Type.Name);
            l_Var.SetValue("Chance", p_Event.Chance.ToString() + " %");
            l_Var.SetValue("Phase Mask", p_Event.PhaseMask.ToString());

            string l_Flags = "";

            foreach (var l_Flag in Game.EventFlags.Instance.Flags)
            {
                if ((p_Event.EventFlags & l_Flag.Value) != 0)
                    l_Flags += (l_Flags == "" ? "" : ", ") + l_Flag.Name;
            }

            l_Var.SetValue("Flags", l_Flags);
            l_Var.SetValue("Parameter 1 (" + l_Type.Param1 + ")", p_Event.Params[0].ToString());
            l_Var.SetValue("Parameter 2 (" + l_Type.Param2 + ")", p_Event.Params[1].ToString());
            l_Var.SetValue("Parameter 3 (" + l_Type.Param3 + ")", p_Event.Params[2].ToString());
            l_Var.SetValue("Parameter 4 (" + l_Type.Param4 + ")", p_Event.Params[3].ToString());
            l_Var.SetValue("Comment", p_Event.Comment.Replace("\\n", "\n"));

            l_Var.SetValue("Sub Events", new Framework.ContextVar());
            l_Var.SetValue("Actions", new Framework.ContextVar());

            foreach (var l_SubEvent in p_Event.SubEvents)
                BuildScriptEventView(l_SubEvent, l_Var.Nodes["Sub Events"]);

            foreach (var l_Action in p_Event.Actions)
                BuildScriptActionView(l_Action, l_Var.Nodes["Actions"]);

            if (!p_First)
                p_Parent.SetValue(l_Name, l_Var);
        }
        private void BuildScriptActionView(ScriptAction p_Action, Framework.ContextVar p_Parent)
        {
            var     l_Type = Game.ActionTypes.Instance.GetType(p_Action.Type);
            string  l_Name = "[ACTION.ID=" + p_Action.ID.ToString() + "][" + l_Type.Name + "] => " + p_Action.Comment.Replace("\\n", " | ");

            Framework.ContextVar l_Var = new Framework.ContextVar();

            l_Var.SetValue("Type", l_Type.Name);
            l_Var.SetValue("Parameter 1 (" + l_Type.Param1 + ")", p_Action.Params[0].ToString());
            l_Var.SetValue("Parameter 2 (" + l_Type.Param2 + ")", p_Action.Params[1].ToString());
            l_Var.SetValue("Parameter 3 (" + l_Type.Param3 + ")", p_Action.Params[2].ToString());
            l_Var.SetValue("Parameter 4 (" + l_Type.Param4 + ")", p_Action.Params[3].ToString());
            l_Var.SetValue("Parameter 5 (" + l_Type.Param5 + ")", p_Action.Params[4].ToString());
            l_Var.SetValue("Parameter 6 (" + l_Type.Param6 + ")", p_Action.Params[5].ToString());

            l_Var.SetValue("Comment", p_Action.Comment.Replace("\\n", "\n"));

            var l_TargetType = Game.TargetTypes.Instance.GetType(p_Action.Type);

            l_Var.SetValue("Target Type", l_TargetType.Name);
            l_Var.SetValue("Target Parameter 1 (" + l_TargetType.Param1 + ")", p_Action.TargetParams[0].ToString());
            l_Var.SetValue("Target Parameter 2 (" + l_TargetType.Param2 + ")", p_Action.TargetParams[1].ToString());
            l_Var.SetValue("Target Parameter 3 (" + l_TargetType.Param3 + ")", p_Action.TargetParams[2].ToString());

            l_Var.SetValue("Target X", p_Action.TargetX.ToString());
            l_Var.SetValue("Target Y", p_Action.TargetY.ToString());
            l_Var.SetValue("Target Z", p_Action.TargetZ.ToString());
            l_Var.SetValue("Target O", p_Action.TargetO.ToString());

            p_Parent.SetValue(l_Name, l_Var);
        }
        private void RefreshEventList()
        {
            EventView.Nodes.Clear();

            List<String> l_AutoExpand = new List<String>();
            l_AutoExpand.Add("Sub Events");

            foreach (var l_Event in Script.Events)
            {
                Framework.ContextVar l_Data = new Framework.ContextVar();
                BuildScriptEventView(l_Event, l_Data, true);

                var     l_Type = Game.EventTypes.Instance.GetType(l_Event.EventType);
                string l_Name  = "[EVENT.ID=" + l_Event.ID.ToString() + "][" + l_Type.Name + "] => " + l_Event.Comment;

                TreeNode l_Node = new TreeNode(l_Name);
                Framework.Formating.ContextVarToTreeNode("root", l_Data, l_Node, l_AutoExpand);

                l_Node.Expand();

                EventView.Nodes.Add(l_Node);
            }
        }

        private ScriptEvent GetCurrentScriptEvent(TreeNode l_Current)
        {
            if (l_Current != null)
            {
                if (l_Current.Text.StartsWith("[EVENT.ID="))
                {
                    try
                    {
                        string l_Tmp = l_Current.Text.Split(']').ElementAt(0).Split('=').ElementAt(1);
                        return Script.GetEvent(uint.Parse(l_Tmp));
                    }
                    catch (System.Exception /*l_Ex*/)
                    {
                        return null;
                    }
                }
                else
                {
                    return GetCurrentScriptEvent(l_Current.Parent);
                }
            }

            return null;
        }
        private ScriptAction GetCurrentScriptAction(TreeNode l_Current)
        {
            if (l_Current != null)
            {
                if (l_Current.Text.StartsWith("[ACTION.ID="))
                {
                    try
                    {
                        string l_Tmp = l_Current.Text.Split(']').ElementAt(0).Split('=').ElementAt(1);
                        uint l_ActionID = uint.Parse(l_Tmp);

                        ScriptEvent l_Event = GetCurrentScriptEvent(l_Current);

                        if (l_Event == null)
                            return null;

                        foreach (var l_Action in l_Event.Actions)
                            if (l_Action.ID == l_ActionID)
                                return l_Action;
                    }
                    catch (System.Exception /*l_Ex*/)
                    {
                        return null;
                    }
                }
                else
                {
                    return GetCurrentScriptAction(l_Current.Parent);
                }
            }

            return null;
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            ScriptEvent l_Parent = GetCurrentScriptEvent(EventView.SelectedNode);

            EventManager l_Manager = new EventManager(new ScriptEvent(), true, l_Parent == null ? false : true, l_Parent == null ? new ScriptEvent() : l_Parent);
            l_Manager.ShowDialog(this);

            if (!l_Manager.IsCanceled)
                RefreshEventList();
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            ScriptEvent l_Event = GetCurrentScriptEvent(EventView.SelectedNode);

            if (l_Event == null)
            {
                MessageBox.Show(this, "No event selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EventManager l_Manager = new EventManager(l_Event, false, false, null);
            l_Manager.ShowDialog(this);

            if (!l_Manager.IsCanceled)
                RefreshEventList();
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            ScriptEvent l_Event = GetCurrentScriptEvent(EventView.SelectedNode);

            if (l_Event == null)
            {
                MessageBox.Show(this, "No event selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult l_Result = MessageBox.Show(this, "Delete all sub-events and sub-actions", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        
            if (l_Result == DialogResult.OK)
            {
                Script.DeleteEvent(l_Event.ID);
                RefreshEventList();
            }
        }

        private void AddAction_Click(object sender, EventArgs e)
        {
            ScriptEvent l_Event = GetCurrentScriptEvent(EventView.SelectedNode);

            if (l_Event == null)
            {
                MessageBox.Show(this, "No event selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActionManager l_Manager = new ActionManager(new ScriptAction(), l_Event, true);
            l_Manager.ShowDialog(this);

            if (!l_Manager.IsCanceled)
                RefreshEventList();
        }

        private void EditAction_Click(object sender, EventArgs e)
        {
            ScriptAction l_Action = GetCurrentScriptAction(EventView.SelectedNode);

            if (l_Action == null)
            {
                MessageBox.Show(this, "No action selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptEvent l_Event = GetCurrentScriptEvent(EventView.SelectedNode);

            if (l_Event == null)
            {
                MessageBox.Show(this, "No event selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActionManager l_Manager = new ActionManager(l_Action, l_Event, false);
            l_Manager.ShowDialog(this);

            if (!l_Manager.IsCanceled)
                RefreshEventList();
        }

        private void DeleteAction_Click(object sender, EventArgs e)
        {
            ScriptAction l_Action = GetCurrentScriptAction(EventView.SelectedNode);

            if (l_Action == null)
            {
                MessageBox.Show(this, "No action selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScriptEvent l_Event = GetCurrentScriptEvent(EventView.SelectedNode);

            if (l_Event == null)
            {
                MessageBox.Show(this, "No event selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult l_Result = MessageBox.Show(this, "Delete the action ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (l_Result == DialogResult.OK)
            {
                foreach (var l_CurrentAction in l_Event.Actions)
                {
                    if (l_Action.ID == l_CurrentAction.ID)
                    {
                        l_Event.Actions.Remove(l_CurrentAction);
                        break;
                    }
                }

                RefreshEventList();
            }
        }
    }
}
