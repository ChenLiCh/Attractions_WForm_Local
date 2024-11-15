namespace Attractions.Views {
    partial class CustomImageBox {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbAttractionId = new System.Windows.Forms.Label();
            this.lbAttractionName = new System.Windows.Forms.Label();
            this.pbAttractionImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttractionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbAttractionId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbAttractionName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbAttractionImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.12418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.87582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(166, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbAttractionId
            // 
            this.lbAttractionId.AutoSize = true;
            this.lbAttractionId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAttractionId.Location = new System.Drawing.Point(3, 128);
            this.lbAttractionId.Name = "lbAttractionId";
            this.lbAttractionId.Size = new System.Drawing.Size(54, 20);
            this.lbAttractionId.TabIndex = 0;
            this.lbAttractionId.Text = "label1";
            // 
            // lbAttractionName
            // 
            this.lbAttractionName.AutoSize = true;
            this.lbAttractionName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAttractionName.Location = new System.Drawing.Point(3, 165);
            this.lbAttractionName.Name = "lbAttractionName";
            this.lbAttractionName.Size = new System.Drawing.Size(54, 20);
            this.lbAttractionName.TabIndex = 1;
            this.lbAttractionName.Text = "label2";
            // 
            // pbAttractionImage
            // 
            this.pbAttractionImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAttractionImage.Location = new System.Drawing.Point(3, 3);
            this.pbAttractionImage.Name = "pbAttractionImage";
            this.pbAttractionImage.Size = new System.Drawing.Size(160, 122);
            this.pbAttractionImage.TabIndex = 2;
            this.pbAttractionImage.TabStop = false;
            // 
            // CustomImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomImageBox";
            this.Size = new System.Drawing.Size(166, 204);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttractionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbAttractionId;
        private System.Windows.Forms.Label lbAttractionName;
        private System.Windows.Forms.PictureBox pbAttractionImage;
    }
}
