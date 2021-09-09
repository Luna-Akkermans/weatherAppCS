
namespace WeatherAppCS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BTNuserInput = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.UserInputPanel = new System.Windows.Forms.Panel();
            this.InputInfoPlcb = new System.Windows.Forms.Label();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.WeatherPic = new System.Windows.Forms.PictureBox();
            this.ConditionPlaceholder = new System.Windows.Forms.Label();
            this.LocationPlaceHolder = new System.Windows.Forms.Label();
            this.BTN_back = new System.Windows.Forms.Button();
            this.UserInputPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(885, 447);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            // 
            // BTNuserInput
            // 
            this.BTNuserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(3)))), ((int)(((byte)(104)))));
            this.BTNuserInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNuserInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNuserInput.Location = new System.Drawing.Point(490, 195);
            this.BTNuserInput.Name = "BTNuserInput";
            this.BTNuserInput.Size = new System.Drawing.Size(85, 36);
            this.BTNuserInput.TabIndex = 1;
            this.BTNuserInput.Text = "Get Weather";
            this.BTNuserInput.UseVisualStyleBackColor = true;
            this.BTNuserInput.Click += new System.EventHandler(this.BTNuserInput_Click);
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.TitleText.Location = new System.Drawing.Point(397, 142);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(119, 15);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "Weather app by Luna";
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.UserInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserInputTextBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(3)))), ((int)(((byte)(104)))));
            this.UserInputTextBox.Location = new System.Drawing.Point(324, 195);
            this.UserInputTextBox.Multiline = true;
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.PlaceholderText = "Amsterdam";
            this.UserInputTextBox.Size = new System.Drawing.Size(160, 35);
            this.UserInputTextBox.TabIndex = 0;
            // 
            // UserInputPanel
            // 
            this.UserInputPanel.Controls.Add(this.InputInfoPlcb);
            this.UserInputPanel.Controls.Add(this.UserInputTextBox);
            this.UserInputPanel.Controls.Add(this.TitleText);
            this.UserInputPanel.Controls.Add(this.BTNuserInput);
            this.UserInputPanel.Location = new System.Drawing.Point(15, 12);
            this.UserInputPanel.Name = "UserInputPanel";
            this.UserInputPanel.Size = new System.Drawing.Size(913, 433);
            this.UserInputPanel.TabIndex = 3;
            // 
            // InputInfoPlcb
            // 
            this.InputInfoPlcb.AutoSize = true;
            this.InputInfoPlcb.Location = new System.Drawing.Point(324, 177);
            this.InputInfoPlcb.Name = "InputInfoPlcb";
            this.InputInfoPlcb.Size = new System.Drawing.Size(31, 15);
            this.InputInfoPlcb.TabIndex = 4;
            this.InputInfoPlcb.Text = "City:";
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.WeatherPic);
            this.ResultPanel.Controls.Add(this.ConditionPlaceholder);
            this.ResultPanel.Controls.Add(this.LocationPlaceHolder);
            this.ResultPanel.Controls.Add(this.BTN_back);
            this.ResultPanel.Location = new System.Drawing.Point(15, 14);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(913, 430);
            this.ResultPanel.TabIndex = 3;
            this.ResultPanel.Visible = false;
            // 
            // WeatherPic
            // 
            this.WeatherPic.BackColor = System.Drawing.Color.Transparent;
            this.WeatherPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.WeatherPic.Image = ((System.Drawing.Image)(resources.GetObject("WeatherPic.Image")));
            this.WeatherPic.ImageLocation = "";
            this.WeatherPic.Location = new System.Drawing.Point(324, 166);
            this.WeatherPic.Name = "WeatherPic";
            this.WeatherPic.Size = new System.Drawing.Size(72, 65);
            this.WeatherPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WeatherPic.TabIndex = 5;
            this.WeatherPic.TabStop = false;
            // 
            // ConditionPlaceholder
            // 
            this.ConditionPlaceholder.AutoSize = true;
            this.ConditionPlaceholder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConditionPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.ConditionPlaceholder.Location = new System.Drawing.Point(403, 167);
            this.ConditionPlaceholder.Name = "ConditionPlaceholder";
            this.ConditionPlaceholder.Size = new System.Drawing.Size(81, 32);
            this.ConditionPlaceholder.TabIndex = 4;
            this.ConditionPlaceholder.Text = "Sunny";
            // 
            // LocationPlaceHolder
            // 
            this.LocationPlaceHolder.AutoSize = true;
            this.LocationPlaceHolder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.LocationPlaceHolder.Location = new System.Drawing.Point(324, 128);
            this.LocationPlaceHolder.Name = "LocationPlaceHolder";
            this.LocationPlaceHolder.Size = new System.Drawing.Size(136, 32);
            this.LocationPlaceHolder.TabIndex = 1;
            this.LocationPlaceHolder.Text = "Amsterdam";
            this.LocationPlaceHolder.Click += new System.EventHandler(this.CityPlaceHolder_Click);
            // 
            // BTN_back
            // 
            this.BTN_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(31)))), ((int)(((byte)(218)))));
            this.BTN_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.BTN_back.Location = new System.Drawing.Point(828, 3);
            this.BTN_back.Name = "BTN_back";
            this.BTN_back.Size = new System.Drawing.Size(82, 36);
            this.BTN_back.TabIndex = 0;
            this.BTN_back.Text = "Back";
            this.BTN_back.UseVisualStyleBackColor = false;
            this.BTN_back.Click += new System.EventHandler(this.BTN_back_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(19)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(940, 471);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.UserInputPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserInputPanel.ResumeLayout(false);
            this.UserInputPanel.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BTNuserInput;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Panel UserInputPanel;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Button BTN_back;
        private System.Windows.Forms.Label LocationPlaceHolder;
        private System.Windows.Forms.PictureBox WeatherPic;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label ConditionPlaceholder;
        private System.Windows.Forms.Label InputInfoPlcb;
    }
}

