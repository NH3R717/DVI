namespace UmholtzTomas_Assignment02a
{
    partial class Form1
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNeed = new System.Windows.Forms.Button();
            this.btnHave = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lstNeed = new System.Windows.Forms.ListBox();
            this.lstHave = new System.Windows.Forms.ListBox();
            this.lblNeed = new System.Windows.Forms.Label();
            this.lblHave = new System.Windows.Forms.Label();
            this.lblPartyList = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.picDelete);
            this.pnlContainer.Controls.Add(this.picLeft);
            this.pnlContainer.Controls.Add(this.picRight);
            this.pnlContainer.Controls.Add(this.btnLoad);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Controls.Add(this.btnNeed);
            this.pnlContainer.Controls.Add(this.btnHave);
            this.pnlContainer.Controls.Add(this.txtItem);
            this.pnlContainer.Controls.Add(this.lstNeed);
            this.pnlContainer.Controls.Add(this.lstHave);
            this.pnlContainer.Controls.Add(this.lblNeed);
            this.pnlContainer.Controls.Add(this.lblHave);
            this.pnlContainer.Controls.Add(this.lblPartyList);
            this.pnlContainer.Location = new System.Drawing.Point(337, 111);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(641, 643);
            this.pnlContainer.TabIndex = 0;
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.Color.Transparent;
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = global::UmholtzTomas_Assignment02a.Properties.Resources.Untitled_2_02;
            this.picDelete.Location = new System.Drawing.Point(284, 316);
            this.picDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(44, 38);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 12;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            // 
            // picLeft
            // 
            this.picLeft.BackColor = System.Drawing.Color.Transparent;
            this.picLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLeft.Image = global::UmholtzTomas_Assignment02a.Properties.Resources.Untitled_2_01;
            this.picLeft.Location = new System.Drawing.Point(284, 256);
            this.picLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(44, 38);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeft.TabIndex = 11;
            this.picLeft.TabStop = false;
            this.picLeft.Click += new System.EventHandler(this.picLeft_Click);
            // 
            // picRight
            // 
            this.picRight.BackColor = System.Drawing.Color.Transparent;
            this.picRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRight.Image = global::UmholtzTomas_Assignment02a.Properties.Resources.Untitled_2_03;
            this.picRight.Location = new System.Drawing.Point(284, 196);
            this.picRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(44, 38);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRight.TabIndex = 10;
            this.picRight.TabStop = false;
            this.picRight.Click += new System.EventHandler(this.picRight_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(456, 555);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 38);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(315, 555);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNeed
            // 
            this.btnNeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeed.Location = new System.Drawing.Point(384, 490);
            this.btnNeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNeed.Name = "btnNeed";
            this.btnNeed.Size = new System.Drawing.Size(133, 38);
            this.btnNeed.TabIndex = 7;
            this.btnNeed.Text = "NEED";
            this.btnNeed.UseVisualStyleBackColor = true;
            this.btnNeed.Click += new System.EventHandler(this.btnNeed_Click);
            // 
            // btnHave
            // 
            this.btnHave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHave.Location = new System.Drawing.Point(91, 490);
            this.btnHave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHave.Name = "btnHave";
            this.btnHave.Size = new System.Drawing.Size(133, 38);
            this.btnHave.TabIndex = 6;
            this.btnHave.Text = "HAVE";
            this.btnHave.UseVisualStyleBackColor = true;
            this.btnHave.Click += new System.EventHandler(this.btnHave_Click);
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Location = new System.Drawing.Point(147, 450);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(314, 22);
            this.txtItem.TabIndex = 5;
            // 
            // lstNeed
            // 
            this.lstNeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNeed.FormattingEnabled = true;
            this.lstNeed.ItemHeight = 16;
            this.lstNeed.Location = new System.Drawing.Point(364, 159);
            this.lstNeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNeed.Name = "lstNeed";
            this.lstNeed.ScrollAlwaysVisible = true;
            this.lstNeed.Size = new System.Drawing.Size(185, 258);
            this.lstNeed.TabIndex = 4;
            // 
            // lstHave
            // 
            this.lstHave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHave.FormattingEnabled = true;
            this.lstHave.ItemHeight = 16;
            this.lstHave.Location = new System.Drawing.Point(68, 159);
            this.lstHave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHave.Name = "lstHave";
            this.lstHave.ScrollAlwaysVisible = true;
            this.lstHave.Size = new System.Drawing.Size(185, 258);
            this.lstHave.TabIndex = 3;
            // 
            // lblNeed
            // 
            this.lblNeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNeed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeed.Location = new System.Drawing.Point(384, 92);
            this.lblNeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(133, 35);
            this.lblNeed.TabIndex = 2;
            this.lblNeed.Text = "NEED";
            this.lblNeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHave
            // 
            this.lblHave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHave.Location = new System.Drawing.Point(91, 92);
            this.lblHave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHave.Name = "lblHave";
            this.lblHave.Size = new System.Drawing.Size(133, 35);
            this.lblHave.TabIndex = 1;
            this.lblHave.Text = "HAVE";
            this.lblHave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartyList
            // 
            this.lblPartyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartyList.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyList.Location = new System.Drawing.Point(244, 28);
            this.lblPartyList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartyList.Name = "lblPartyList";
            this.lblPartyList.Size = new System.Drawing.Size(133, 35);
            this.lblPartyList.TabIndex = 0;
            this.lblPartyList.Text = "Party List";
            this.lblPartyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.Label lblHave;
        private System.Windows.Forms.Label lblPartyList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNeed;
        private System.Windows.Forms.Button btnHave;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ListBox lstNeed;
        private System.Windows.Forms.ListBox lstHave;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picLeft;
    }
}

