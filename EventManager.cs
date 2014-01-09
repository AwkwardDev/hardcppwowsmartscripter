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
    /// Event manager window
    /// </summary>
    public partial class EventManager : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p_Current"></param>
        /// <param name="p_Creation"></param>
        /// <param name="p_HaveParent"></param>
        /// <param name="p_ParentEvent"></param>
        public EventManager(ScriptEvent p_Current, bool p_Creation, bool p_HaveParent, ScriptEvent p_ParentEvent)
        {
            InitializeComponent();

            InitializationEventTypes();
            InitializationEventFlags();

            Parameter1Description.Text = "";
            Parameter2Description.Text = "";
            Parameter3Description.Text = "";
            Parameter4Description.Text = "";

            m_IsCreation    = p_Creation;
            m_HaveParent    = p_HaveParent;
            m_ParentEvent   = p_ParentEvent;
            m_Current       = p_Current;

            if (!p_Creation && p_Current != null)
            {
                if (p_Current.PhaseMask == 0)
                {
                    AllPhase.Checked = true;
                    AllPhase_CheckedChanged(this, null);
                }
                else
                {
                    for (int l_I = 1; l_I < 32; l_I++)
                    {
                        if ((p_Current.PhaseMask & (1 << l_I)) != 0)
                            PhaseList.Items.Add((1 << l_I).ToString());
                    }
                }

                EventChance.Value = (int)p_Current.Chance;
                EventChance_Scroll(this, null);

                int l_CurrentIndex = 0;
                foreach (var l_Flag in Game.EventFlags.Instance.Flags)
                {
                    if ((p_Current.EventFlags & l_Flag.Value) != 0)
                        EventFlags.SelectedIndices.Add(l_CurrentIndex);

                    l_CurrentIndex++;
                }

                l_CurrentIndex = 0;
                foreach (var l_Type in Game.EventTypes.Instance.Types)
                {
                    if ((p_Current.EventType & l_Type.Value) != 0)
                    {
                        EventType.SelectedIndices.Add(l_CurrentIndex);
                        break;
                    }

                    l_CurrentIndex++;
                }
                EventType_SelectedIndexChanged(this, null);

                Parameter1.Text = p_Current.Params[0].ToString();
                Parameter2.Text = p_Current.Params[1].ToString();
                Parameter3.Text = p_Current.Params[2].ToString();
                Parameter4.Text = p_Current.Params[3].ToString();

                Comment.Text = p_Current.Comment.Replace("\\n", "\n");
            }
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Initialize all type
        /// </summary>
        private void InitializationEventTypes()
        {
            var l_Types = Game.EventTypes.Instance.Types;

            EventType.Items.Clear();

            foreach (var l_Current in l_Types)
                EventType.Items.Add(new ListViewItem(l_Current.Value.ToString() + " - " + l_Current.Name));
        }
        /// <summary>
        /// Initialize all flags
        /// </summary>
        private void InitializationEventFlags()
        {
            var l_Flags = Game.EventFlags.Instance.Flags;

            EventFlags.Items.Clear();

            foreach (var l_Current in l_Flags)
                EventFlags.Items.Add(new ListViewItem("0x" + l_Current.Value.ToString("X2") + " - " + l_Current.Name));
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Change event chance
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void EventChance_Scroll(object p_Sender, EventArgs p_Event)
        {
            EventChanceText.Text = EventChance.Value + " %";
        }
        /// <summary>
        /// Toggle all phase state
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void AllPhase_CheckedChanged(object p_Sender, EventArgs p_Event)
        {
            PhaseList.Enabled   = !AllPhase.Checked;
            PhaseAdd.Enabled    = !AllPhase.Checked;
            PhaseRemove.Enabled = !AllPhase.Checked;
            PhaseValue.Enabled  = !AllPhase.Checked;
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Change current event type
        /// </summary>
        /// <param name="p_Sender"></param>
        /// <param name="p_Event"></param>
        private void EventType_SelectedIndexChanged(object p_Sender, EventArgs p_Event)
        {
            uint l_TypeID = 0;

            try
            {
                l_TypeID = uint.Parse(EventType.SelectedItems[0].Text.Split('-').ElementAt(0));
            }
            catch (System.Exception /*l_Ex*/)
            {
            	
            }

            var l_Type = Game.EventTypes.Instance.GetType(l_TypeID);

            Parameter1Description.Text = l_Type.Param1;
            Parameter2Description.Text = l_Type.Param2;
            Parameter3Description.Text = l_Type.Param3;
            Parameter4Description.Text = l_Type.Param4;
        }

        //////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////

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

                m_Current.Chance = (uint)EventChance.Value;
                m_Current.Comment = "";

                ListView.SelectedListViewItemCollection l_SelectedFlags = EventFlags.SelectedItems;
                foreach (ListViewItem l_Current in l_SelectedFlags)
                    m_Current.EventFlags |= Framework.Formating.StringToUInt32(l_Current.Text.Split('-').ElementAt(0));

                m_Current.EventType = uint.Parse(EventType.SelectedItems[0].Text.Split('-').ElementAt(0));

                if (Parameter1.Text != "")
                    m_Current.Params[0] = Framework.Formating.StringToUInt32(Parameter1.Text);
                if (Parameter2.Text != "")
                    m_Current.Params[1] = Framework.Formating.StringToUInt32(Parameter2.Text);
                if (Parameter3.Text != "")
                    m_Current.Params[2] = Framework.Formating.StringToUInt32(Parameter3.Text);
                if (Parameter4.Text != "")
                    m_Current.Params[3] = Framework.Formating.StringToUInt32(Parameter4.Text);

                if (AllPhase.Checked)
                    m_Current.PhaseMask = 0;
                else
                    foreach (ListViewItem l_Current in PhaseList.Items)
                        m_Current.PhaseMask |= Framework.Formating.StringToUInt32(l_Current.Text);

                m_Current.Comment = Comment.Text.Replace("\n", "\\n");

                if (m_IsCreation && m_HaveParent)
                    m_ParentEvent.SubEvents.Add(m_Current);
                else if (m_IsCreation)
                    Script.Events.Add(m_Current);


                this.Close();
                IsCanceled = false;

            }
            catch (System.Exception l_Ex)
            {
                MessageBox.Show(l_Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        /// Have a parent event
        /// </summary>
        private bool m_HaveParent;

        /// <summary>
        /// Current event
        /// </summary>
        private ScriptEvent m_Current;
        /// <summary>
        /// Current event parent
        /// </summary>
        private ScriptEvent m_ParentEvent;
        #endregion
    }
}
