﻿namespace WindowsFormsApp2
{
    partial class FormAccounts
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
            this.tbxAccSearchName = new System.Windows.Forms.TextBox();
            this.lblAccSearchName = new System.Windows.Forms.Label();
            this.btnAccDel = new System.Windows.Forms.Button();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.btnAccAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAccSearchName
            // 
            this.tbxAccSearchName.Location = new System.Drawing.Point(36, 46);
            this.tbxAccSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAccSearchName.Name = "tbxAccSearchName";
            this.tbxAccSearchName.Size = new System.Drawing.Size(227, 22);
            this.tbxAccSearchName.TabIndex = 2;
            this.tbxAccSearchName.TextChanged += new System.EventHandler(this.tbxAccSearchName_TextChanged);
            // 
            // lblAccSearchName
            // 
            this.lblAccSearchName.AutoSize = true;
            this.lblAccSearchName.Location = new System.Drawing.Point(34, 22);
            this.lblAccSearchName.Name = "lblAccSearchName";
            this.lblAccSearchName.Size = new System.Drawing.Size(82, 17);
            this.lblAccSearchName.TabIndex = 1;
            this.lblAccSearchName.Text = "&Rechercher";
            // 
            // btnAccDel
            // 
            this.btnAccDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccDel.Location = new System.Drawing.Point(731, 38);
            this.btnAccDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccDel.Name = "btnAccDel";
            this.btnAccDel.Size = new System.Drawing.Size(107, 30);
            this.btnAccDel.TabIndex = 4;
            this.btnAccDel.Text = "&Supprimer";
            this.btnAccDel.UseVisualStyleBackColor = true;
            this.btnAccDel.Click += new System.EventHandler(this.btnAccDel_Click);
            // 
            // dgvAcc
            // 
            this.dgvAcc.AllowUserToAddRows = false;
            this.dgvAcc.AllowUserToOrderColumns = true;
            this.dgvAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Location = new System.Drawing.Point(35, 92);
            this.dgvAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidth = 51;
            this.dgvAcc.RowTemplate.Height = 24;
            this.dgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcc.Size = new System.Drawing.Size(802, 360);
            this.dgvAcc.TabIndex = 12;
            this.dgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcc_CellDoubleClick);
            // 
            // btnAccAdd
            // 
            this.btnAccAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccAdd.Location = new System.Drawing.Point(577, 38);
            this.btnAccAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccAdd.Name = "btnAccAdd";
            this.btnAccAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAccAdd.TabIndex = 3;
            this.btnAccAdd.Text = "&Nouveau compte";
            this.btnAccAdd.UseVisualStyleBackColor = true;
            this.btnAccAdd.Click += new System.EventHandler(this.btnAccAdd_Click);
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 483);
            this.Controls.Add(this.btnAccAdd);
            this.Controls.Add(this.lblAccSearchName);
            this.Controls.Add(this.tbxAccSearchName);
            this.Controls.Add(this.dgvAcc);
            this.Controls.Add(this.btnAccDel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(595, 530);
            this.Name = "FormAccounts";
            this.Text = "Comptes";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxAccSearchName;
        private System.Windows.Forms.Label lblAccSearchName;
        private System.Windows.Forms.Button btnAccDel;
        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.Button btnAccAdd;
    }
}