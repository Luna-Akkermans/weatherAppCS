
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
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.ExtraAddition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConditionPlaceholder = new System.Windows.Forms.Label();
            this.TempPlaceholder = new System.Windows.Forms.Label();
            this.CountryPlaceholder = new System.Windows.Forms.Label();
            this.CityPlaceHolder = new System.Windows.Forms.Label();
            this.BTN_back = new System.Windows.Forms.Button();
            this.UserInputPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.UserInputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(3)))), ((int)(((byte)(104)))));
            this.UserInputTextBox.Location = new System.Drawing.Point(324, 195);
            this.UserInputTextBox.Multiline = true;
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(160, 35);
            this.UserInputTextBox.TabIndex = 0;
            // 
            // UserInputPanel
            // 
            this.UserInputPanel.Controls.Add(this.UserInputTextBox);
            this.UserInputPanel.Controls.Add(this.TitleText);
            this.UserInputPanel.Controls.Add(this.BTNuserInput);
            this.UserInputPanel.Location = new System.Drawing.Point(15, 12);
            this.UserInputPanel.Name = "UserInputPanel";
            this.UserInputPanel.Size = new System.Drawing.Size(913, 433);
            this.UserInputPanel.TabIndex = 3;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.ExtraAddition);
            this.ResultPanel.Controls.Add(this.pictureBox1);
            this.ResultPanel.Controls.Add(this.ConditionPlaceholder);
            this.ResultPanel.Controls.Add(this.TempPlaceholder);
            this.ResultPanel.Controls.Add(this.CountryPlaceholder);
            this.ResultPanel.Controls.Add(this.CityPlaceHolder);
            this.ResultPanel.Controls.Add(this.BTN_back);
            this.ResultPanel.Location = new System.Drawing.Point(15, 12);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(913, 430);
            this.ResultPanel.TabIndex = 3;
            this.ResultPanel.Visible = false;
            // 
            // ExtraAddition
            // 
            this.ExtraAddition.AutoSize = true;
            this.ExtraAddition.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExtraAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.ExtraAddition.Location = new System.Drawing.Point(451, 128);
            this.ExtraAddition.Name = "ExtraAddition";
            this.ExtraAddition.Size = new System.Drawing.Size(19, 32);
            this.ExtraAddition.TabIndex = 6;
            this.ExtraAddition.Text = ",";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(324, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // TempPlaceholder
            // 
            this.TempPlaceholder.AutoSize = true;
            this.TempPlaceholder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.TempPlaceholder.Location = new System.Drawing.Point(403, 199);
            this.TempPlaceholder.Name = "TempPlaceholder";
            this.TempPlaceholder.Size = new System.Drawing.Size(58, 32);
            this.TempPlaceholder.TabIndex = 3;
            this.TempPlaceholder.Text = "10.1";
            // 
            // CountryPlaceholder
            // 
            this.CountryPlaceholder.AutoSize = true;
            this.CountryPlaceholder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.CountryPlaceholder.Location = new System.Drawing.Point(466, 128);
            this.CountryPlaceholder.Name = "CountryPlaceholder";
            this.CountryPlaceholder.Size = new System.Drawing.Size(144, 32);
            this.CountryPlaceholder.TabIndex = 2;
            this.CountryPlaceholder.Text = "Netherlands";
            // 
            // CityPlaceHolder
            // 
            this.CityPlaceHolder.AutoSize = true;
            this.CityPlaceHolder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityPlaceHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.CityPlaceHolder.Location = new System.Drawing.Point(324, 128);
            this.CityPlaceHolder.Name = "CityPlaceHolder";
            this.CityPlaceHolder.Size = new System.Drawing.Size(136, 32);
            this.CityPlaceHolder.TabIndex = 1;
            this.CityPlaceHolder.Text = "Amsterdam";
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
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.UserInputPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(218)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UserInputPanel.ResumeLayout(false);
            this.UserInputPanel.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label CityPlaceHolder;
        private System.Windows.Forms.Label ExtraAddition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label ConditionPlaceholder;
        private System.Windows.Forms.Label TempPlaceholder;
        private System.Windows.Forms.Label CountryPlaceholder;
    }
}

