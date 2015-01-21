namespace ServerFTP
{
    partial class FormMain
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
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGestionClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.Size = new System.Drawing.Size(508, 109);
            this.richTextBoxConsole.TabIndex = 0;
            this.richTextBoxConsole.Text = "";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(540, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Server";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(540, 41);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop Server";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGestionClient
            // 
            this.buttonGestionClient.Location = new System.Drawing.Point(707, 11);
            this.buttonGestionClient.Name = "buttonGestionClient";
            this.buttonGestionClient.Size = new System.Drawing.Size(267, 74);
            this.buttonGestionClient.TabIndex = 3;
            this.buttonGestionClient.Text = "Gestion utilisateurs";
            this.buttonGestionClient.UseVisualStyleBackColor = true;
            this.buttonGestionClient.Click += new System.EventHandler(this.buttonGestionClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelClients
            // 
            this.panelClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelClients.Location = new System.Drawing.Point(13, 161);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(507, 216);
            this.panelClients.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 389);
            this.Controls.Add(this.panelClients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGestionClient);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.richTextBoxConsole);
            this.Name = "FormMain";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGestionClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelClients;
    }
}

