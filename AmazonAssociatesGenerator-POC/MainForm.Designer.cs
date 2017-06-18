namespace AmazonAssociatesGenerator_POC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.lblASIN = new System.Windows.Forms.Label();
            this.tbTrackingID = new System.Windows.Forms.TextBox();
            this.tbASIN = new System.Windows.Forms.TextBox();
            this.linkTester = new System.Windows.Forms.LinkLabel();
            this.linkCopy = new System.Windows.Forms.LinkLabel();
            this.linkJustin = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkReferral = new System.Windows.Forms.LinkLabel();
            this.customErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customErr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(90, 239);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(90, 22);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Canada",
            "United States"});
            this.cbCountry.Location = new System.Drawing.Point(201, 236);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(254, 30);
            this.cbCountry.TabIndex = 1;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingID.Location = new System.Drawing.Point(58, 308);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(116, 22);
            this.lblTrackingID.TabIndex = 2;
            this.lblTrackingID.Text = "Tracking ID:";
            this.lblTrackingID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblASIN
            // 
            this.lblASIN.AutoSize = true;
            this.lblASIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASIN.Location = new System.Drawing.Point(36, 373);
            this.lblASIN.Name = "lblASIN";
            this.lblASIN.Size = new System.Drawing.Size(136, 22);
            this.lblASIN.TabIndex = 3;
            this.lblASIN.Text = "Product ASIN:";
            this.lblASIN.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTrackingID
            // 
            this.tbTrackingID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrackingID.Location = new System.Drawing.Point(201, 305);
            this.tbTrackingID.Name = "tbTrackingID";
            this.tbTrackingID.Size = new System.Drawing.Size(254, 31);
            this.tbTrackingID.TabIndex = 4;
            // 
            // tbASIN
            // 
            this.tbASIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbASIN.Location = new System.Drawing.Point(201, 370);
            this.tbASIN.Name = "tbASIN";
            this.tbASIN.Size = new System.Drawing.Size(254, 31);
            this.tbASIN.TabIndex = 5;
            // 
            // linkTester
            // 
            this.linkTester.AutoSize = true;
            this.linkTester.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTester.Location = new System.Drawing.Point(389, 436);
            this.linkTester.Name = "linkTester";
            this.linkTester.Size = new System.Drawing.Size(126, 23);
            this.linkTester.TabIndex = 6;
            this.linkTester.TabStop = true;
            this.linkTester.Text = "Test your Link!";
            this.linkTester.Visible = false;
            this.linkTester.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTester_LinkClicked);
            // 
            // linkCopy
            // 
            this.linkCopy.AutoSize = true;
            this.linkCopy.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCopy.Location = new System.Drawing.Point(78, 436);
            this.linkCopy.Name = "linkCopy";
            this.linkCopy.Size = new System.Drawing.Size(176, 23);
            this.linkCopy.TabIndex = 7;
            this.linkCopy.TabStop = true;
            this.linkCopy.Text = "Copy Generated Link";
            this.linkCopy.Visible = false;
            this.linkCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopy_LinkClicked);
            // 
            // linkJustin
            // 
            this.linkJustin.AutoSize = true;
            this.linkJustin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkJustin.Location = new System.Drawing.Point(79, 524);
            this.linkJustin.Name = "linkJustin";
            this.linkJustin.Size = new System.Drawing.Size(93, 18);
            this.linkJustin.TabIndex = 8;
            this.linkJustin.TabStop = true;
            this.linkJustin.Text = "Justin Ellery";
            this.linkJustin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJustin_LinkClicked);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(7, 524);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(75, 18);
            this.lblCreatedBy.TabIndex = 9;
            this.lblCreatedBy.Text = "Created by";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGithub.Location = new System.Drawing.Point(574, 524);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(54, 18);
            this.linkGithub.TabIndex = 10;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Github";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(417, 524);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(161, 18);
            this.lblSource.TabIndex = 11;
            this.lblSource.Text = "Check out the source on";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AllowDrop = true;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(280, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 32);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(166, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // linkReferral
            // 
            this.linkReferral.AutoSize = true;
            this.linkReferral.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReferral.Location = new System.Drawing.Point(250, 165);
            this.linkReferral.Name = "linkReferral";
            this.linkReferral.Size = new System.Drawing.Size(157, 23);
            this.linkReferral.TabIndex = 14;
            this.linkReferral.TabStop = true;
            this.linkReferral.Text = "Your Referral Link!";
            this.linkReferral.Visible = false;
            this.linkReferral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReferral_LinkClicked);
            // 
            // customErr
            // 
            this.customErr.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 551);
            this.Controls.Add(this.linkReferral);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.linkJustin);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.linkCopy);
            this.Controls.Add(this.linkTester);
            this.Controls.Add(this.tbASIN);
            this.Controls.Add(this.tbTrackingID);
            this.Controls.Add(this.lblASIN);
            this.Controls.Add(this.lblTrackingID);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon Assosciates Referral Link Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.Label lblASIN;
        private System.Windows.Forms.TextBox tbTrackingID;
        private System.Windows.Forms.TextBox tbASIN;
        private System.Windows.Forms.LinkLabel linkTester;
        private System.Windows.Forms.LinkLabel linkCopy;
        private System.Windows.Forms.LinkLabel linkJustin;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkReferral;
        private System.Windows.Forms.ErrorProvider customErr;
    }
}

