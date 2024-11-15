using System.Windows.Forms;

namespace Attractions.Views {
    partial class FormAttractionEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttractionEditor));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbfCreatedDate = new System.Windows.Forms.Label();
            this.lbUpdatedDate = new System.Windows.Forms.Label();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPreviousImage = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpClosingTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpOpeningTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fbAttractionName = new Attractions.Views.fieldBox();
            this.tbTransformInformation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fbRegion = new Attractions.Views.fieldBox();
            this.fbAddress = new Attractions.Views.fieldBox();
            this.fbLongitude = new Attractions.Views.fieldBox();
            this.fbLatitude = new Attractions.Views.fieldBox();
            this.fbWebsiteURL = new Attractions.Views.fieldBox();
            this.fbPhoneNumber = new Attractions.Views.fieldBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Location = new System.Drawing.Point(283, 605);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "確定";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(193, 605);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(108, 486);
            this.cbCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(220, 32);
            this.cbCategoryName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "分類";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(11, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "建立時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "修改時間";
            // 
            // lbfCreatedDate
            // 
            this.lbfCreatedDate.AutoSize = true;
            this.lbfCreatedDate.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbfCreatedDate.Location = new System.Drawing.Point(134, 430);
            this.lbfCreatedDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbfCreatedDate.Name = "lbfCreatedDate";
            this.lbfCreatedDate.Size = new System.Drawing.Size(86, 24);
            this.lbfCreatedDate.TabIndex = 26;
            this.lbfCreatedDate.Text = "沒有資料";
            // 
            // lbUpdatedDate
            // 
            this.lbUpdatedDate.AutoSize = true;
            this.lbUpdatedDate.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUpdatedDate.Location = new System.Drawing.Point(134, 479);
            this.lbUpdatedDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbUpdatedDate.Name = "lbUpdatedDate";
            this.lbUpdatedDate.Size = new System.Drawing.Size(86, 24);
            this.lbUpdatedDate.TabIndex = 27;
            this.lbUpdatedDate.Text = "沒有資料";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextImage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextImage.Image")));
            this.btnNextImage.Location = new System.Drawing.Point(173, 227);
            this.btnNextImage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(35, 30);
            this.btnNextImage.TabIndex = 28;
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPreviousImage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousImage.Image")));
            this.btnPreviousImage.Location = new System.Drawing.Point(130, 227);
            this.btnPreviousImage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(35, 30);
            this.btnPreviousImage.TabIndex = 29;
            this.btnPreviousImage.UseVisualStyleBackColor = true;
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpClosingTime);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.dtpOpeningTime);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbId);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.cbStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnNextImage);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviousImage);
            this.splitContainer1.Panel1.Controls.Add(this.fbAttractionName);
            this.splitContainer1.Panel1.Controls.Add(this.cbCategoryName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbTransformInformation);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lbUpdatedDate);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.fbRegion);
            this.splitContainer1.Panel2.Controls.Add(this.lbfCreatedDate);
            this.splitContainer1.Panel2.Controls.Add(this.fbAddress);
            this.splitContainer1.Panel2.Controls.Add(this.fbLongitude);
            this.splitContainer1.Panel2.Controls.Add(this.fbLatitude);
            this.splitContainer1.Panel2.Controls.Add(this.fbWebsiteURL);
            this.splitContainer1.Panel2.Controls.Add(this.fbPhoneNumber);
            this.splitContainer1.Size = new System.Drawing.Size(940, 691);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 31;
            // 
            // dtpClosingTime
            // 
            this.dtpClosingTime.CustomFormat = "HH:mm";
            this.dtpClosingTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpClosingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClosingTime.Location = new System.Drawing.Point(108, 582);
            this.dtpClosingTime.Name = "dtpClosingTime";
            this.dtpClosingTime.ShowUpDown = true;
            this.dtpClosingTime.Size = new System.Drawing.Size(218, 33);
            this.dtpClosingTime.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(7, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "結束時間";
            // 
            // dtpOpeningTime
            // 
            this.dtpOpeningTime.CustomFormat = "HH:mm";
            this.dtpOpeningTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpOpeningTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpeningTime.Location = new System.Drawing.Point(108, 536);
            this.dtpOpeningTime.Name = "dtpOpeningTime";
            this.dtpOpeningTime.ShowUpDown = true;
            this.dtpOpeningTime.Size = new System.Drawing.Size(218, 33);
            this.dtpOpeningTime.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(7, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "開放時間";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbDescription.Location = new System.Drawing.Point(108, 373);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(220, 84);
            this.tbDescription.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "簡介";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbId.Location = new System.Drawing.Point(104, 282);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 24);
            this.lbId.TabIndex = 34;
            this.lbId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "編號";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "正常開放",
            "開放時間和平時不同",
            "已關閉",
            "永久關閉"});
            this.cbStatus.Location = new System.Drawing.Point(108, 634);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(220, 32);
            this.cbStatus.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "狀態";
            // 
            // fbAttractionName
            // 
            this.fbAttractionName.fieldName = "名稱";
            this.fbAttractionName.fieldValue = "";
            this.fbAttractionName.Location = new System.Drawing.Point(10, 325);
            this.fbAttractionName.Margin = new System.Windows.Forms.Padding(4);
            this.fbAttractionName.Name = "fbAttractionName";
            this.fbAttractionName.Size = new System.Drawing.Size(316, 34);
            this.fbAttractionName.TabIndex = 0;
            // 
            // tbTransformInformation
            // 
            this.tbTransformInformation.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTransformInformation.Location = new System.Drawing.Point(140, 215);
            this.tbTransformInformation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbTransformInformation.Multiline = true;
            this.tbTransformInformation.Name = "tbTransformInformation";
            this.tbTransformInformation.Size = new System.Drawing.Size(220, 84);
            this.tbTransformInformation.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(31, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "交通資訊";
            // 
            // fbRegion
            // 
            this.fbRegion.fieldName = "地區";
            this.fbRegion.fieldValue = "";
            this.fbRegion.Location = new System.Drawing.Point(42, 14);
            this.fbRegion.Margin = new System.Windows.Forms.Padding(4);
            this.fbRegion.Name = "fbRegion";
            this.fbRegion.Size = new System.Drawing.Size(316, 34);
            this.fbRegion.TabIndex = 4;
            // 
            // fbAddress
            // 
            this.fbAddress.fieldName = "地址";
            this.fbAddress.fieldValue = "";
            this.fbAddress.Location = new System.Drawing.Point(42, 68);
            this.fbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.Size = new System.Drawing.Size(316, 34);
            this.fbAddress.TabIndex = 2;
            // 
            // fbLongitude
            // 
            this.fbLongitude.fieldName = "經度";
            this.fbLongitude.fieldValue = "";
            this.fbLongitude.Location = new System.Drawing.Point(42, 116);
            this.fbLongitude.Margin = new System.Windows.Forms.Padding(4);
            this.fbLongitude.Name = "fbLongitude";
            this.fbLongitude.Size = new System.Drawing.Size(316, 34);
            this.fbLongitude.TabIndex = 15;
            // 
            // fbLatitude
            // 
            this.fbLatitude.fieldName = "緯度";
            this.fbLatitude.fieldValue = "";
            this.fbLatitude.Location = new System.Drawing.Point(42, 166);
            this.fbLatitude.Margin = new System.Windows.Forms.Padding(4);
            this.fbLatitude.Name = "fbLatitude";
            this.fbLatitude.Size = new System.Drawing.Size(316, 34);
            this.fbLatitude.TabIndex = 16;
            // 
            // fbWebsiteURL
            // 
            this.fbWebsiteURL.fieldName = "網址";
            this.fbWebsiteURL.fieldValue = "";
            this.fbWebsiteURL.Location = new System.Drawing.Point(35, 375);
            this.fbWebsiteURL.Margin = new System.Windows.Forms.Padding(4);
            this.fbWebsiteURL.Name = "fbWebsiteURL";
            this.fbWebsiteURL.Size = new System.Drawing.Size(316, 30);
            this.fbWebsiteURL.TabIndex = 14;
            // 
            // fbPhoneNumber
            // 
            this.fbPhoneNumber.fieldName = "電話";
            this.fbPhoneNumber.fieldValue = "";
            this.fbPhoneNumber.Location = new System.Drawing.Point(35, 325);
            this.fbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.fbPhoneNumber.Name = "fbPhoneNumber";
            this.fbPhoneNumber.Size = new System.Drawing.Size(316, 34);
            this.fbPhoneNumber.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAttractionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 691);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAttractionEditor";
            this.Text = "FormAttractionEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAttractionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private fieldBox fbAttractionName;
        private fieldBox fbAddress;
        private fieldBox fbPhoneNumber;
        private fieldBox fbRegion;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private fieldBox fbWebsiteURL;
        private fieldBox fbLongitude;
        private fieldBox fbLatitude;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbfCreatedDate;
        private System.Windows.Forms.Label lbUpdatedDate;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPreviousImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTransformInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOpeningTime;
        private DateTimePicker dtpClosingTime;
        private Label label9;
        private Label label8;
        private OpenFileDialog openFileDialog1;
    }
}