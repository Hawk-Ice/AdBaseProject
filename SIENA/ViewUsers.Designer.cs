﻿namespace SIENA
{
    partial class ViewUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.userDataTable = new System.Windows.Forms.DataGridView();
            this.addUser = new System.Windows.Forms.Label();
            this.btnSearchBox = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataTable
            // 
            this.userDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataTable.Location = new System.Drawing.Point(14, 74);
            this.userDataTable.Name = "userDataTable";
            this.userDataTable.Size = new System.Drawing.Size(739, 509);
            this.userDataTable.TabIndex = 1;
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(16, 21);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(167, 37);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Search User";
            // 
            // btnSearchBox
            // 
            this.btnSearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBox.BackgroundImage")));
            this.btnSearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBox.Location = new System.Drawing.Point(729, 34);
            this.btnSearchBox.Name = "btnSearchBox";
            this.btnSearchBox.Size = new System.Drawing.Size(25, 25);
            this.btnSearchBox.TabIndex = 83;
            this.btnSearchBox.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(396, 37);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(334, 20);
            this.txtSearchBox.TabIndex = 82;
            this.txtSearchBox.Text = "Search account";
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchBox);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.userDataTable);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(777, 602);
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView userDataTable;
        private System.Windows.Forms.Label addUser;
        private System.Windows.Forms.Button btnSearchBox;
        private System.Windows.Forms.TextBox txtSearchBox;
    }
}
