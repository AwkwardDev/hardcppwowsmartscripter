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
    /// <summary>
    /// Action manager window
    /// </summary>
    public partial class ActionManager : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ActionManager(ScriptAction p_Current, ScriptEvent p_Event, bool p_Create)
        {
            InitializeComponent();

            InitializationActionTypes();
            InitializationTargetTypes();

            TargetParameter1Description.Text = "";
            TargetParameter2Description.Text = "";
            TargetParameter3Description.Text = "";

            ActionParameter1Description.Text = "";
            ActionParameter2Description.Text = "";
            ActionParameter3Description.Text = "";
            ActionParameter4Description.Text = "";
            ActionParameter5Description.Text = "";
            ActionParameter6Description.Text = "";

            m_Current       = p_Current;
            m_Event         = p_Event;
            m_IsCreation    = p_Create;

            if (!p_Create && p_Current != null)
            {
                int l_CurrentIndex = 0;
                foreach (var l_Type in Game.ActionTypes.Instance.Types)
                {
                    if ((p_Current.Type & l_Type.Value) != 0)
                    {
                        ActionType.SelectedIndices.Add(l_CurrentIndex);
                        break;
                    }

                    l_CurrentIndex++;
                }
                ActionType_SelectedIndexChanged(this, null);

                l_CurrentIndex = 0;
                foreach (var l_Type in Game.TargetTypes.Instance.Types)
                {
                    if ((p_Current.Type & l_Type.Value) != 0)
                    {
                        TargetType.SelectedIndices.Add(l_CurrentIndex);
                        break;
                    }

                    l_CurrentIndex++;
                }
                TargetType_SelectedIndexChanged(this, null);

                ActionParameter1.Text = p_Current.Params[0].ToString();
                ActionParameter2.Text = p_Current.Params[1].ToString();
                ActionParameter3.Text = p_Current.Params[2].ToString();
                ActionParameter4.Text = p_Current.Params[3].ToString();
                ActionParameter5.Text = p_Current.Params[4].ToString();
                ActionParameter6.Text = p_Current.Params[5].ToString();

                TargetParameter1.Text = p_Current.TargetParams[0].ToString();
                TargetParameter2.Text = p_Current.TargetParams[1].ToString();
                TargetParameter3.Text = p_Current.TargetParams[2].ToString();

                TargetX.Text = p_Current.TargetX.ToString();
                TargetY.Text = p_Current.TargetY.ToString();
                TargetZ.Text = p_Current.TargetZ.ToString();
                TargetO.Text = p_Current.TargetO.ToString();

                Comment.Text = p_Current.Comment.Replace("\\n", "\n");
            }
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Initialize target types
        /// </summary>
        private void InitializationActionTypes()
        {
            var l_Types = Game.ActionTypes.Instance.Types;

            ActionType.Items.Clear();

            foreach (var l_Current in l_Types)
                ActionType.Items.Add(new ListViewItem(l_Current.Value.ToString() + " - " + l_Current.Name));
        }
        /// <summary>
        /// Initialize target types
        /// </summary>
        private void InitializationTargetTypes()
        {
            var l_Types = Game.TargetTypes.Instance.Types;

            TargetType.Items.Clear();

            foreach (var l_Current in l_Types)
                TargetType.Items.Add(new ListViewItem(l_Current.Value.ToString() + " - " + l_Current.Name));
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Change current target type change
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void TargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint l_TypeID = 0;

            try
            {
                l_TypeID = uint.Parse(TargetType.SelectedItems[0].Text.Split('-').ElementAt(0));
            }
            catch (System.Exception /*l_Ex*/)
            {

            }

            var l_Type = Game.TargetTypes.Instance.GetType(l_TypeID);

            TargetParameter1Description.Text = l_Type.Param1;
            TargetParameter2Description.Text = l_Type.Param2;
            TargetParameter3Description.Text = l_Type.Param3;
        }
        /// <summary>
        /// Change current action type
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void ActionType_SelectedIndexChanged(object p_Sender, EventArgs p_Event)
        {
            uint l_TypeID = 0;

            try
            {
                l_TypeID = uint.Parse(ActionType.SelectedItems[0].Text.Split('-').ElementAt(0));
            }
            catch (System.Exception /*l_Ex*/)
            {

            }

            var l_Type = Game.ActionTypes.Instance.GetType(l_TypeID);

            ActionParameter1Description.Text = l_Type.Param1;
            ActionParameter2Description.Text = l_Type.Param2;
            ActionParameter3Description.Text = l_Type.Param3;
            ActionParameter4Description.Text = l_Type.Param4;
            ActionParameter5Description.Text = l_Type.Param5;
            ActionParameter6Description.Text = l_Type.Param6;
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Save / Create
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void OK_Click(object p_Sender, EventArgs p_Event)
        {
            try
            {
                if (m_IsCreation)
                    m_Current.ID = Script.GenerateID();

                m_Current.Type = uint.Parse(ActionType.SelectedItems[0].Text.Split('-').ElementAt(0));
                m_Current.TargetType = uint.Parse(TargetType.SelectedItems[0].Text.Split('-').ElementAt(0));

                if (ActionParameter1.Text != "")
                    m_Current.Params[0] = Framework.Formating.StringToUInt32(ActionParameter1.Text);
                if (ActionParameter2.Text != "")
                    m_Current.Params[1] = Framework.Formating.StringToUInt32(ActionParameter2.Text);
                if (ActionParameter3.Text != "")
                    m_Current.Params[2] = Framework.Formating.StringToUInt32(ActionParameter3.Text);
                if (ActionParameter4.Text != "")
                    m_Current.Params[3] = Framework.Formating.StringToUInt32(ActionParameter4.Text);
                if (ActionParameter5.Text != "")
                    m_Current.Params[4] = Framework.Formating.StringToUInt32(ActionParameter5.Text);
                if (ActionParameter6.Text != "")
                    m_Current.Params[5] = Framework.Formating.StringToUInt32(ActionParameter6.Text);

                if (TargetParameter1.Text != "")
                    m_Current.TargetParams[0] = Framework.Formating.StringToUInt32(TargetParameter1.Text);
                if (TargetParameter2.Text != "")
                    m_Current.TargetParams[1] = Framework.Formating.StringToUInt32(TargetParameter2.Text);
                if (TargetParameter3.Text != "")
                    m_Current.TargetParams[2] = Framework.Formating.StringToUInt32(TargetParameter3.Text);

                if (TargetX.Text != "")
                    m_Current.TargetX = float.Parse(TargetX.Text);
                if (TargetY.Text != "")
                    m_Current.TargetY = float.Parse(TargetY.Text);
                if (TargetZ.Text != "")
                    m_Current.TargetZ = float.Parse(TargetZ.Text);
                if (TargetO.Text != "")
                    m_Current.TargetO = float.Parse(TargetO.Text);

                m_Current.Comment = Comment.Text.Replace("\n", "\\n");

                if (m_IsCreation)
                    m_Event.Actions.Add(m_Current);

                this.Close();
                IsCanceled = false;

            }
            catch (System.Exception l_Ex)
            {
                MessageBox.Show(l_Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Discard editing / changes
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void Cancel_Click(object p_Sender, EventArgs p_Event)
        {
            this.Close();
            IsCanceled = true;
        }

        #region Data
        /// <summary>
        /// Creation / Editing is canceled
        /// </summary>
        public bool IsCanceled;

        /// <summary>
        /// Is event creation window
        /// </summary>
        private bool m_IsCreation;

        /// <summary>
        /// Current event
        /// </summary>
        private ScriptAction m_Current;
        /// <summary>
        /// Current event parent
        /// </summary>
        private ScriptEvent m_Event;
        #endregion
    }
}
