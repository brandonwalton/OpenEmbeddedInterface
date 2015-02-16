namespace OpenEmbeddedInterface.Gui
{
    partial class NewProjectDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWorkingDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInterface = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTargetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTargetVendor = new System.Windows.Forms.TextBox();
            this.gbProject = new System.Windows.Forms.GroupBox();
            this.dbTarget = new System.Windows.Forms.GroupBox();
            this.tbTargetDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCreate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbProject.SuspendLayout();
            this.dbTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the details for the new project below, the working directory will be" +
    " populated with the project files.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(110, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(231, 20);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "The Project Name";
            this.tbName.Click += new System.EventHandler(this.EraseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Working Directory:";
            // 
            // tbWorkingDirectory
            // 
            this.tbWorkingDirectory.Location = new System.Drawing.Point(110, 41);
            this.tbWorkingDirectory.Name = "tbWorkingDirectory";
            this.tbWorkingDirectory.Size = new System.Drawing.Size(188, 20);
            this.tbWorkingDirectory.TabIndex = 4;
            this.tbWorkingDirectory.Text = "C:\\Project";
            this.tbWorkingDirectory.Click += new System.EventHandler(this.EraseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Default Interface:";
            // 
            // cbInterface
            // 
            this.cbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterface.FormattingEnabled = true;
            this.cbInterface.Items.AddRange(new object[] {
            "DecideLater",
            "UART",
            "I2C",
            "SPI",
            "CAN",
            "Ethernet",
            "BitBanging"});
            this.cbInterface.Location = new System.Drawing.Point(110, 67);
            this.cbInterface.Name = "cbInterface";
            this.cbInterface.Size = new System.Drawing.Size(188, 21);
            this.cbInterface.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            // 
            // tbTargetName
            // 
            this.tbTargetName.Location = new System.Drawing.Point(84, 19);
            this.tbTargetName.Name = "tbTargetName";
            this.tbTargetName.Size = new System.Drawing.Size(257, 20);
            this.tbTargetName.TabIndex = 9;
            this.tbTargetName.Text = "Microcontroller 3CS512R256F";
            this.tbTargetName.Click += new System.EventHandler(this.EraseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vendor:";
            // 
            // tbTargetVendor
            // 
            this.tbTargetVendor.Location = new System.Drawing.Point(84, 45);
            this.tbTargetVendor.Name = "tbTargetVendor";
            this.tbTargetVendor.Size = new System.Drawing.Size(257, 20);
            this.tbTargetVendor.TabIndex = 11;
            this.tbTargetVendor.Text = "Microcontrollers Inc. GmbH";
            this.tbTargetVendor.Click += new System.EventHandler(this.EraseClick);
            // 
            // gbProject
            // 
            this.gbProject.Controls.Add(this.tbName);
            this.gbProject.Controls.Add(this.label2);
            this.gbProject.Controls.Add(this.label3);
            this.gbProject.Controls.Add(this.tbWorkingDirectory);
            this.gbProject.Controls.Add(this.button1);
            this.gbProject.Controls.Add(this.cbInterface);
            this.gbProject.Controls.Add(this.label4);
            this.gbProject.Location = new System.Drawing.Point(12, 50);
            this.gbProject.Name = "gbProject";
            this.gbProject.Size = new System.Drawing.Size(356, 100);
            this.gbProject.TabIndex = 12;
            this.gbProject.TabStop = false;
            this.gbProject.Text = "Project";
            // 
            // dbTarget
            // 
            this.dbTarget.Controls.Add(this.tbTargetDescription);
            this.dbTarget.Controls.Add(this.label7);
            this.dbTarget.Controls.Add(this.label5);
            this.dbTarget.Controls.Add(this.tbTargetName);
            this.dbTarget.Controls.Add(this.tbTargetVendor);
            this.dbTarget.Controls.Add(this.label6);
            this.dbTarget.Location = new System.Drawing.Point(12, 156);
            this.dbTarget.Name = "dbTarget";
            this.dbTarget.Size = new System.Drawing.Size(356, 187);
            this.dbTarget.TabIndex = 13;
            this.dbTarget.TabStop = false;
            this.dbTarget.Text = "Hardware Target Information";
            // 
            // tbTargetDescription
            // 
            this.tbTargetDescription.Location = new System.Drawing.Point(84, 71);
            this.tbTargetDescription.Multiline = true;
            this.tbTargetDescription.Name = "tbTargetDescription";
            this.tbTargetDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTargetDescription.Size = new System.Drawing.Size(257, 106);
            this.tbTargetDescription.TabIndex = 13;
            this.tbTargetDescription.Text = "512K Ram\r\n256K Flash\r\n64 MHz microcontroller\r\n2 SPI\r\n1 CAN";
            this.tbTargetDescription.Click += new System.EventHandler(this.EraseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description:";
            // 
            // tbCreate
            // 
            this.tbCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbCreate.Location = new System.Drawing.Point(212, 349);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Size = new System.Drawing.Size(75, 23);
            this.tbCreate.TabIndex = 14;
            this.tbCreate.Text = "Create";
            this.tbCreate.UseVisualStyleBackColor = true;
            this.tbCreate.Click += new System.EventHandler(this.tbCreate_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(293, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbCreate);
            this.Controls.Add(this.dbTarget);
            this.Controls.Add(this.gbProject);
            this.Controls.Add(this.label1);
            this.Name = "NewProjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project...";
            this.gbProject.ResumeLayout(false);
            this.gbProject.PerformLayout();
            this.dbTarget.ResumeLayout(false);
            this.dbTarget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWorkingDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbInterface;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTargetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTargetVendor;
        private System.Windows.Forms.GroupBox gbProject;
        private System.Windows.Forms.GroupBox dbTarget;
        private System.Windows.Forms.TextBox tbTargetDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tbCreate;
        private System.Windows.Forms.Button button3;
    }
}