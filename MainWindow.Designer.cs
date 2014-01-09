namespace HardCPPWoWSmartScripter
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.EventView = new System.Windows.Forms.TreeView();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.AddAction = new System.Windows.Forms.Button();
            this.EditAction = new System.Windows.Forms.Button();
            this.DeleteAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventView
            // 
            this.EventView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventView.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.EventView.FullRowSelect = true;
            this.EventView.HideSelection = false;
            this.EventView.Location = new System.Drawing.Point(13, 13);
            this.EventView.Name = "EventView";
            this.EventView.Size = new System.Drawing.Size(1271, 636);
            this.EventView.TabIndex = 0;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEventButton.Location = new System.Drawing.Point(1290, 12);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(165, 23);
            this.AddEventButton.TabIndex = 1;
            this.AddEventButton.Text = "Add event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // EditEvent
            // 
            this.EditEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEvent.Location = new System.Drawing.Point(1290, 41);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(165, 23);
            this.EditEvent.TabIndex = 2;
            this.EditEvent.Text = "Edit event";
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEvent.Location = new System.Drawing.Point(1291, 71);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(164, 23);
            this.DeleteEvent.TabIndex = 3;
            this.DeleteEvent.Text = "Delete event";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // AddAction
            // 
            this.AddAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAction.Location = new System.Drawing.Point(1291, 115);
            this.AddAction.Name = "AddAction";
            this.AddAction.Size = new System.Drawing.Size(165, 23);
            this.AddAction.TabIndex = 4;
            this.AddAction.Text = "Add action";
            this.AddAction.UseVisualStyleBackColor = true;
            this.AddAction.Click += new System.EventHandler(this.AddAction_Click);
            // 
            // EditAction
            // 
            this.EditAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditAction.Location = new System.Drawing.Point(1291, 144);
            this.EditAction.Name = "EditAction";
            this.EditAction.Size = new System.Drawing.Size(165, 23);
            this.EditAction.TabIndex = 5;
            this.EditAction.Text = "Edit action";
            this.EditAction.UseVisualStyleBackColor = true;
            this.EditAction.Click += new System.EventHandler(this.EditAction_Click);
            // 
            // DeleteAction
            // 
            this.DeleteAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAction.Location = new System.Drawing.Point(1290, 173);
            this.DeleteAction.Name = "DeleteAction";
            this.DeleteAction.Size = new System.Drawing.Size(165, 23);
            this.DeleteAction.TabIndex = 6;
            this.DeleteAction.Text = "Delete action";
            this.DeleteAction.UseVisualStyleBackColor = true;
            this.DeleteAction.Click += new System.EventHandler(this.DeleteAction_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 661);
            this.Controls.Add(this.DeleteAction);
            this.Controls.Add(this.EditAction);
            this.Controls.Add(this.AddAction);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.EditEvent);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.EventView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "HardCPP WoW Smart Scripter - Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView EventView;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.Button AddAction;
        private System.Windows.Forms.Button EditAction;
        private System.Windows.Forms.Button DeleteAction;
    }
}

