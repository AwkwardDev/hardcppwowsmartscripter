namespace HardCPPWoWSmartScripter
{
    partial class EventManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PhaseList = new System.Windows.Forms.ListView();
            this.PhaseValue = new System.Windows.Forms.TextBox();
            this.PhaseAdd = new System.Windows.Forms.Button();
            this.PhaseRemove = new System.Windows.Forms.Button();
            this.AllPhase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventChance = new System.Windows.Forms.TrackBar();
            this.EventChanceText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EventType = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.Parameter1Description = new System.Windows.Forms.Label();
            this.Parameter1 = new System.Windows.Forms.TextBox();
            this.Parameter2 = new System.Windows.Forms.TextBox();
            this.Parameter2Description = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Parameter3 = new System.Windows.Forms.TextBox();
            this.Parameter3Description = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Parameter4 = new System.Windows.Forms.TextBox();
            this.Parameter4Description = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.EventFlags = new System.Windows.Forms.ListView();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EventChance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phase";
            // 
            // PhaseList
            // 
            this.PhaseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhaseList.HideSelection = false;
            this.PhaseList.Location = new System.Drawing.Point(91, 13);
            this.PhaseList.Name = "PhaseList";
            this.PhaseList.Size = new System.Drawing.Size(689, 101);
            this.PhaseList.TabIndex = 1;
            this.PhaseList.UseCompatibleStateImageBehavior = false;
            this.PhaseList.View = System.Windows.Forms.View.Details;
            // 
            // PhaseValue
            // 
            this.PhaseValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhaseValue.Location = new System.Drawing.Point(91, 121);
            this.PhaseValue.Name = "PhaseValue";
            this.PhaseValue.Size = new System.Drawing.Size(556, 20);
            this.PhaseValue.TabIndex = 2;
            // 
            // PhaseAdd
            // 
            this.PhaseAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhaseAdd.Location = new System.Drawing.Point(653, 119);
            this.PhaseAdd.Name = "PhaseAdd";
            this.PhaseAdd.Size = new System.Drawing.Size(58, 23);
            this.PhaseAdd.TabIndex = 3;
            this.PhaseAdd.Text = "Add";
            this.PhaseAdd.UseVisualStyleBackColor = true;
            // 
            // PhaseRemove
            // 
            this.PhaseRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PhaseRemove.Location = new System.Drawing.Point(722, 119);
            this.PhaseRemove.Name = "PhaseRemove";
            this.PhaseRemove.Size = new System.Drawing.Size(58, 23);
            this.PhaseRemove.TabIndex = 4;
            this.PhaseRemove.Text = "Remove";
            this.PhaseRemove.UseVisualStyleBackColor = true;
            // 
            // AllPhase
            // 
            this.AllPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPhase.AutoSize = true;
            this.AllPhase.Location = new System.Drawing.Point(787, 13);
            this.AllPhase.Name = "AllPhase";
            this.AllPhase.Size = new System.Drawing.Size(70, 17);
            this.AllPhase.TabIndex = 5;
            this.AllPhase.Text = "All Phase";
            this.AllPhase.UseVisualStyleBackColor = true;
            this.AllPhase.CheckedChanged += new System.EventHandler(this.AllPhase_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chance";
            // 
            // EventChance
            // 
            this.EventChance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventChance.Location = new System.Drawing.Point(91, 148);
            this.EventChance.Maximum = 100;
            this.EventChance.Name = "EventChance";
            this.EventChance.Size = new System.Drawing.Size(689, 45);
            this.EventChance.TabIndex = 7;
            this.EventChance.Value = 100;
            this.EventChance.Scroll += new System.EventHandler(this.EventChance_Scroll);
            // 
            // EventChanceText
            // 
            this.EventChanceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventChanceText.AutoSize = true;
            this.EventChanceText.Location = new System.Drawing.Point(786, 163);
            this.EventChanceText.Name = "EventChanceText";
            this.EventChanceText.Size = new System.Drawing.Size(36, 13);
            this.EventChanceText.TabIndex = 8;
            this.EventChanceText.Text = "100 %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Flags";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // EventType
            // 
            this.EventType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventType.HideSelection = false;
            this.EventType.Location = new System.Drawing.Point(91, 306);
            this.EventType.MultiSelect = false;
            this.EventType.Name = "EventType";
            this.EventType.Size = new System.Drawing.Size(689, 115);
            this.EventType.TabIndex = 12;
            this.EventType.UseCompatibleStateImageBehavior = false;
            this.EventType.View = System.Windows.Forms.View.List;
            this.EventType.SelectedIndexChanged += new System.EventHandler(this.EventType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parameter 1 : ";
            // 
            // Parameter1Description
            // 
            this.Parameter1Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter1Description.AutoSize = true;
            this.Parameter1Description.Location = new System.Drawing.Point(85, 526);
            this.Parameter1Description.Name = "Parameter1Description";
            this.Parameter1Description.Size = new System.Drawing.Size(120, 13);
            this.Parameter1Description.TabIndex = 14;
            this.Parameter1Description.Text = "Parameter 1 Description";
            // 
            // Parameter1
            // 
            this.Parameter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter1.Location = new System.Drawing.Point(88, 543);
            this.Parameter1.Name = "Parameter1";
            this.Parameter1.Size = new System.Drawing.Size(689, 20);
            this.Parameter1.TabIndex = 15;
            // 
            // Parameter2
            // 
            this.Parameter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter2.Location = new System.Drawing.Point(88, 591);
            this.Parameter2.Name = "Parameter2";
            this.Parameter2.Size = new System.Drawing.Size(689, 20);
            this.Parameter2.TabIndex = 18;
            // 
            // Parameter2Description
            // 
            this.Parameter2Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter2Description.AutoSize = true;
            this.Parameter2Description.Location = new System.Drawing.Point(85, 574);
            this.Parameter2Description.Name = "Parameter2Description";
            this.Parameter2Description.Size = new System.Drawing.Size(120, 13);
            this.Parameter2Description.TabIndex = 17;
            this.Parameter2Description.Text = "Parameter 2 Description";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Parameter 2 : ";
            // 
            // Parameter3
            // 
            this.Parameter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter3.Location = new System.Drawing.Point(88, 640);
            this.Parameter3.Name = "Parameter3";
            this.Parameter3.Size = new System.Drawing.Size(689, 20);
            this.Parameter3.TabIndex = 21;
            // 
            // Parameter3Description
            // 
            this.Parameter3Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter3Description.AutoSize = true;
            this.Parameter3Description.Location = new System.Drawing.Point(85, 623);
            this.Parameter3Description.Name = "Parameter3Description";
            this.Parameter3Description.Size = new System.Drawing.Size(120, 13);
            this.Parameter3Description.TabIndex = 20;
            this.Parameter3Description.Text = "Parameter 3 Description";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 623);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Parameter 3 : ";
            // 
            // Parameter4
            // 
            this.Parameter4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter4.Location = new System.Drawing.Point(88, 689);
            this.Parameter4.Name = "Parameter4";
            this.Parameter4.Size = new System.Drawing.Size(689, 20);
            this.Parameter4.TabIndex = 24;
            // 
            // Parameter4Description
            // 
            this.Parameter4Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter4Description.AutoSize = true;
            this.Parameter4Description.Location = new System.Drawing.Point(85, 672);
            this.Parameter4Description.Name = "Parameter4Description";
            this.Parameter4Description.Size = new System.Drawing.Size(120, 13);
            this.Parameter4Description.TabIndex = 23;
            this.Parameter4Description.Text = "Parameter 4 Description";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 672);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Parameter 4 : ";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(9, 736);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(280, 23);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(577, 736);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(280, 23);
            this.OK.TabIndex = 26;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // EventFlags
            // 
            this.EventFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventFlags.HideSelection = false;
            this.EventFlags.Location = new System.Drawing.Point(91, 214);
            this.EventFlags.Name = "EventFlags";
            this.EventFlags.Size = new System.Drawing.Size(689, 73);
            this.EventFlags.TabIndex = 27;
            this.EventFlags.UseCompatibleStateImageBehavior = false;
            this.EventFlags.View = System.Windows.Forms.View.List;
            // 
            // CommentLabel
            // 
            this.CommentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(13, 431);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(51, 13);
            this.CommentLabel.TabIndex = 28;
            this.CommentLabel.Text = "Comment";
            // 
            // Comment
            // 
            this.Comment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment.Location = new System.Drawing.Point(91, 428);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(689, 86);
            this.Comment.TabIndex = 29;
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 767);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.EventFlags);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Parameter4);
            this.Controls.Add(this.Parameter4Description);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Parameter3);
            this.Controls.Add(this.Parameter3Description);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Parameter2);
            this.Controls.Add(this.Parameter2Description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Parameter1);
            this.Controls.Add(this.Parameter1Description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EventType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventChanceText);
            this.Controls.Add(this.EventChance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllPhase);
            this.Controls.Add(this.PhaseRemove);
            this.Controls.Add(this.PhaseAdd);
            this.Controls.Add(this.PhaseValue);
            this.Controls.Add(this.PhaseList);
            this.Controls.Add(this.label1);
            this.Name = "EventManager";
            this.Text = "HardCPP WoW Smart Scripter - Event Manager";
            ((System.ComponentModel.ISupportInitialize)(this.EventChance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView PhaseList;
        private System.Windows.Forms.TextBox PhaseValue;
        private System.Windows.Forms.Button PhaseAdd;
        private System.Windows.Forms.Button PhaseRemove;
        private System.Windows.Forms.CheckBox AllPhase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar EventChance;
        private System.Windows.Forms.Label EventChanceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView EventType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Parameter1Description;
        private System.Windows.Forms.TextBox Parameter1;
        private System.Windows.Forms.TextBox Parameter2;
        private System.Windows.Forms.Label Parameter2Description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Parameter3;
        private System.Windows.Forms.Label Parameter3Description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Parameter4;
        private System.Windows.Forms.Label Parameter4Description;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ListView EventFlags;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox Comment;
    }
}