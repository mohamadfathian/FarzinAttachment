namespace farzinAttachment
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.sdf = new System.Windows.Forms.Label();
            this.entityTypeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntityTypeCode = new System.Windows.Forms.TextBox();
            this.chkInsertINDB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(169, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(375, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to continue learning how to build a desktop app!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(92, 80);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(477, 17);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(269, 23);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(161, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Hello World!";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(249, 121);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(168, 22);
            this.txtSource.TabIndex = 4;
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(157, 124);
            this.sdf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(82, 17);
            this.sdf.TabIndex = 5;
            this.sdf.Text = "SourcePath";
            // 
            // entityTypeCode
            // 
            this.entityTypeCode.Location = new System.Drawing.Point(249, 153);
            this.entityTypeCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entityTypeCode.Name = "entityTypeCode";
            this.entityTypeCode.Size = new System.Drawing.Size(168, 22);
            this.entityTypeCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "EntityTypeCode";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(572, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 276);
            this.listBox1.TabIndex = 8;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(572, 379);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(541, 133);
            this.txtQuery.TabIndex = 9;
            this.txtQuery.Text = "select entitycode,entityNumber from Entity_TransmitalForm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Query:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "DestinationFolder";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(249, 379);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(168, 22);
            this.txtFilePath.TabIndex = 11;
            // 
            // BtnConverter
            // 
            this.BtnConverter.Location = new System.Drawing.Point(249, 479);
            this.BtnConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(129, 34);
            this.BtnConverter.TabIndex = 13;
            this.BtnConverter.Text = "StartConvert";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "EntityTypeCode";
            // 
            // txtEntityTypeCode
            // 
            this.txtEntityTypeCode.Location = new System.Drawing.Point(249, 411);
            this.txtEntityTypeCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntityTypeCode.Name = "txtEntityTypeCode";
            this.txtEntityTypeCode.Size = new System.Drawing.Size(168, 22);
            this.txtEntityTypeCode.TabIndex = 14;
            // 
            // chkInsertINDB
            // 
            this.chkInsertINDB.AutoSize = true;
            this.chkInsertINDB.Location = new System.Drawing.Point(249, 569);
            this.chkInsertINDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkInsertINDB.Name = "chkInsertINDB";
            this.chkInsertINDB.Size = new System.Drawing.Size(143, 21);
            this.chkInsertINDB.TabIndex = 16;
            this.chkInsertINDB.Text = "insert in database";
            this.chkInsertINDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 741);
            this.Controls.Add(this.chkInsertINDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntityTypeCode);
            this.Controls.Add(this.BtnConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityTypeCode);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.TextBox entityTypeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntityTypeCode;
        private System.Windows.Forms.CheckBox chkInsertINDB;
        private System.Windows.Forms.TextBox txtQuery;
    }
}

