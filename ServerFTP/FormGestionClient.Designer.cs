﻿namespace ServerFTP
{
    partial class FormGestionClient
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
            this.components = new System.ComponentModel.Container();
            this.labelClientList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userStoreBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userStoreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientList
            // 
            this.labelClientList.AutoSize = true;
            this.labelClientList.Location = new System.Drawing.Point(13, 13);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(57, 13);
            this.labelClientList.TabIndex = 1;
            this.labelClientList.Text = "Liste client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.userStoreBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1069, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // userStoreBindingSource2
            // 
            this.userStoreBindingSource2.DataSource = typeof(ServerFTP.ClasseMetier.UserStore);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // userStoreBindingSource1
            // 
            this.userStoreBindingSource1.DataSource = typeof(ServerFTP.ClasseMetier.UserStore);
            // 
            // userStoreBindingSource
            // 
            this.userStoreBindingSource.DataSource = typeof(ServerFTP.ClasseMetier.UserStore);
            // 
            // FormGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelClientList);
            this.Name = "FormGestionClient";
            this.Text = "FormGestionClient";
            this.Load += new System.EventHandler(this.FormGestionClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userStoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userStoreBindingSource1;
        private System.Windows.Forms.BindingSource userStoreBindingSource;
        private System.Windows.Forms.BindingSource userStoreBindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}