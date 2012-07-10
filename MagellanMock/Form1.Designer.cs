namespace MagellanMock
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
         this.tbDropFolder = new System.Windows.Forms.TextBox();
         this.tbPickupFolder = new System.Windows.Forms.TextBox();
         this.btnDropFolder = new System.Windows.Forms.Button();
         this.btnPickupFolder = new System.Windows.Forms.Button();
         this.btnRun = new System.Windows.Forms.Button();
         this.lbResults = new System.Windows.Forms.ListBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
         this.btnParse = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.tbProcessedFolder = new System.Windows.Forms.TextBox();
         this.btnProcessedFolder = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // tbDropFolder
         // 
         this.tbDropFolder.Location = new System.Drawing.Point(111, 13);
         this.tbDropFolder.Name = "tbDropFolder";
         this.tbDropFolder.Size = new System.Drawing.Size(398, 20);
         this.tbDropFolder.TabIndex = 0;
         this.tbDropFolder.Text = "C:\\Temp\\Folder\\Input";
         // 
         // tbPickupFolder
         // 
         this.tbPickupFolder.Location = new System.Drawing.Point(111, 40);
         this.tbPickupFolder.Name = "tbPickupFolder";
         this.tbPickupFolder.Size = new System.Drawing.Size(398, 20);
         this.tbPickupFolder.TabIndex = 1;
         this.tbPickupFolder.Text = "C:\\Temp\\Folder\\Output";
         // 
         // btnDropFolder
         // 
         this.btnDropFolder.Location = new System.Drawing.Point(515, 13);
         this.btnDropFolder.Name = "btnDropFolder";
         this.btnDropFolder.Size = new System.Drawing.Size(32, 23);
         this.btnDropFolder.TabIndex = 2;
         this.btnDropFolder.Text = "...";
         this.btnDropFolder.UseVisualStyleBackColor = true;
         this.btnDropFolder.Click += new System.EventHandler(this.btnDropFolder_Click);
         // 
         // btnPickupFolder
         // 
         this.btnPickupFolder.Location = new System.Drawing.Point(515, 40);
         this.btnPickupFolder.Name = "btnPickupFolder";
         this.btnPickupFolder.Size = new System.Drawing.Size(32, 23);
         this.btnPickupFolder.TabIndex = 3;
         this.btnPickupFolder.Text = "...";
         this.btnPickupFolder.UseVisualStyleBackColor = true;
         this.btnPickupFolder.Click += new System.EventHandler(this.btnPickupFolder_Click);
         // 
         // btnRun
         // 
         this.btnRun.Location = new System.Drawing.Point(553, 13);
         this.btnRun.Name = "btnRun";
         this.btnRun.Size = new System.Drawing.Size(53, 23);
         this.btnRun.TabIndex = 4;
         this.btnRun.Text = "Run";
         this.btnRun.UseVisualStyleBackColor = true;
         this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
         // 
         // lbResults
         // 
         this.lbResults.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbResults.FormattingEnabled = true;
         this.lbResults.ItemHeight = 11;
         this.lbResults.Location = new System.Drawing.Point(13, 129);
         this.lbResults.Name = "lbResults";
         this.lbResults.Size = new System.Drawing.Size(593, 268);
         this.lbResults.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(62, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Drop Folder";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(13, 40);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(72, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "Pickup Folder";
         // 
         // folderBrowser
         // 
         this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
         // 
         // btnParse
         // 
         this.btnParse.Location = new System.Drawing.Point(12, 100);
         this.btnParse.Name = "btnParse";
         this.btnParse.Size = new System.Drawing.Size(75, 23);
         this.btnParse.TabIndex = 8;
         this.btnParse.Text = "Parse";
         this.btnParse.UseVisualStyleBackColor = true;
         this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(16, 67);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(89, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "Processed Folder";
         // 
         // tbProcessedFolder
         // 
         this.tbProcessedFolder.Location = new System.Drawing.Point(111, 67);
         this.tbProcessedFolder.Name = "tbProcessedFolder";
         this.tbProcessedFolder.Size = new System.Drawing.Size(398, 20);
         this.tbProcessedFolder.TabIndex = 10;
         this.tbProcessedFolder.Text = "C:\\Temp\\Folder\\Processed";
         // 
         // btnProcessedFolder
         // 
         this.btnProcessedFolder.Location = new System.Drawing.Point(516, 67);
         this.btnProcessedFolder.Name = "btnProcessedFolder";
         this.btnProcessedFolder.Size = new System.Drawing.Size(31, 23);
         this.btnProcessedFolder.TabIndex = 11;
         this.btnProcessedFolder.Text = "...";
         this.btnProcessedFolder.UseVisualStyleBackColor = true;
         this.btnProcessedFolder.Click += new System.EventHandler(this.btnProcessedFolder_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(618, 416);
         this.Controls.Add(this.btnProcessedFolder);
         this.Controls.Add(this.tbProcessedFolder);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btnParse);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lbResults);
         this.Controls.Add(this.btnRun);
         this.Controls.Add(this.btnPickupFolder);
         this.Controls.Add(this.btnDropFolder);
         this.Controls.Add(this.tbPickupFolder);
         this.Controls.Add(this.tbDropFolder);
         this.Name = "Form1";
         this.Text = "Magellan Mock";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbDropFolder;
      private System.Windows.Forms.TextBox tbPickupFolder;
      private System.Windows.Forms.Button btnDropFolder;
      private System.Windows.Forms.Button btnPickupFolder;
      private System.Windows.Forms.Button btnRun;
      private System.Windows.Forms.ListBox lbResults;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.FolderBrowserDialog folderBrowser;
      private System.Windows.Forms.Button btnParse;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox tbProcessedFolder;
      private System.Windows.Forms.Button btnProcessedFolder;
   }
}

