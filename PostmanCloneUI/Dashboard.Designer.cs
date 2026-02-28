namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFormHeader = new Label();
            lblApiLabel = new Label();
            tbUrl = new TextBox();
            btCallApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            cbHttpMethod = new ComboBox();
            lblMethod = new Label();
            tcCallData = new TabControl();
            tabBody = new TabPage();
            tbBody = new TextBox();
            tabResults = new TabPage();
            tbResults = new TextBox();
            statusStrip.SuspendLayout();
            tcCallData.SuspendLayout();
            tabBody.SuspendLayout();
            tabResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormHeader
            // 
            lblFormHeader.AutoSize = true;
            lblFormHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormHeader.Location = new Point(12, 9);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new Size(317, 60);
            lblFormHeader.TabIndex = 0;
            lblFormHeader.Text = "Postman Clone";
            // 
            // lblApiLabel
            // 
            lblApiLabel.AutoSize = true;
            lblApiLabel.Location = new Point(12, 78);
            lblApiLabel.Name = "lblApiLabel";
            lblApiLabel.Size = new Size(72, 38);
            lblApiLabel.TabIndex = 1;
            lblApiLabel.Text = "URL:";
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(82, 78);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(1254, 43);
            tbUrl.TabIndex = 2;
            // 
            // btCallApi
            // 
            btCallApi.Location = new Point(1342, 78);
            btCallApi.Name = "btCallApi";
            btCallApi.Size = new Size(70, 43);
            btCallApi.TabIndex = 3;
            btCallApi.Text = "Go";
            btCallApi.UseVisualStyleBackColor = true;
            btCallApi.Click += btCallApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 795);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1430, 37);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            // 
            // cbHttpMethod
            // 
            cbHttpMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHttpMethod.FormattingEnabled = true;
            cbHttpMethod.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            cbHttpMethod.Location = new Point(1261, 127);
            cbHttpMethod.Name = "cbHttpMethod";
            cbHttpMethod.Size = new Size(151, 45);
            cbHttpMethod.TabIndex = 7;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(1135, 130);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(120, 38);
            lblMethod.TabIndex = 8;
            lblMethod.Text = "Method:";
            // 
            // tcCallData
            // 
            tcCallData.Controls.Add(tabBody);
            tcCallData.Controls.Add(tabResults);
            tcCallData.Location = new Point(12, 178);
            tcCallData.Name = "tcCallData";
            tcCallData.SelectedIndex = 0;
            tcCallData.Size = new Size(1406, 614);
            tcCallData.TabIndex = 9;
            // 
            // tabBody
            // 
            tabBody.Controls.Add(tbBody);
            tabBody.Location = new Point(4, 46);
            tabBody.Name = "tabBody";
            tabBody.Padding = new Padding(3);
            tabBody.Size = new Size(1398, 564);
            tabBody.TabIndex = 0;
            tabBody.Text = "Body";
            tabBody.UseVisualStyleBackColor = true;
            // 
            // tbBody
            // 
            tbBody.BackColor = Color.White;
            tbBody.BorderStyle = BorderStyle.FixedSingle;
            tbBody.Dock = DockStyle.Fill;
            tbBody.Location = new Point(3, 3);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.ScrollBars = ScrollBars.Both;
            tbBody.Size = new Size(1392, 558);
            tbBody.TabIndex = 7;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(tbResults);
            tabResults.Location = new Point(4, 29);
            tabResults.Name = "tabResults";
            tabResults.Padding = new Padding(3);
            tabResults.Size = new Size(1398, 581);
            tabResults.TabIndex = 1;
            tabResults.Text = "Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            tbResults.BackColor = Color.White;
            tbResults.BorderStyle = BorderStyle.FixedSingle;
            tbResults.Dock = DockStyle.Fill;
            tbResults.Location = new Point(3, 3);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ReadOnly = true;
            tbResults.ScrollBars = ScrollBars.Both;
            tbResults.Size = new Size(1392, 575);
            tbResults.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 832);
            Controls.Add(tcCallData);
            Controls.Add(lblMethod);
            Controls.Add(cbHttpMethod);
            Controls.Add(statusStrip);
            Controls.Add(btCallApi);
            Controls.Add(tbUrl);
            Controls.Add(lblApiLabel);
            Controls.Add(lblFormHeader);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Dashboard";
            Text = "Postman Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tcCallData.ResumeLayout(false);
            tabBody.ResumeLayout(false);
            tabBody.PerformLayout();
            tabResults.ResumeLayout(false);
            tabResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormHeader;
        private Label lblApiLabel;
        private TextBox tbUrl;
        private Button btCallApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox cbHttpMethod;
        private Label lblMethod;
        private TabControl tcCallData;
        private TabPage tabBody;
        private TabPage tabResults;
        private TextBox tbResults;
        private TextBox tbBody;
    }
}
