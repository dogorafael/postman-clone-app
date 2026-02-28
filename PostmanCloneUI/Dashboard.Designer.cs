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
            tbResults = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            lblResults = new Label();
            statusStrip.SuspendLayout();
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
            // tbResults
            // 
            tbResults.BackColor = Color.White;
            tbResults.BorderStyle = BorderStyle.FixedSingle;
            tbResults.Location = new Point(12, 195);
            tbResults.Multiline = true;
            tbResults.Name = "tbResults";
            tbResults.ReadOnly = true;
            tbResults.ScrollBars = ScrollBars.Both;
            tbResults.Size = new Size(1400, 580);
            tbResults.TabIndex = 4;
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
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 144);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(104, 38);
            lblResults.TabIndex = 6;
            lblResults.Text = "Results";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1430, 832);
            Controls.Add(lblResults);
            Controls.Add(statusStrip);
            Controls.Add(tbResults);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormHeader;
        private Label lblApiLabel;
        private TextBox tbUrl;
        private Button btCallApi;
        private TextBox tbResults;
        private StatusStrip statusStrip;
        private Label lblResults;
        private ToolStripStatusLabel systemStatus;
    }
}
