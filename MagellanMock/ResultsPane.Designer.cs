namespace MagellanMock
{
   partial class ResultsPane
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.recordPanel = new System.Windows.Forms.Panel();
         this.btnSetResponse = new System.Windows.Forms.Button();
         this.cbxACCEPTED = new System.Windows.Forms.CheckBox();
         this.cbxMatNumber = new System.Windows.Forms.CheckBox();
         this.tbMatNumber = new System.Windows.Forms.TextBox();
         this.tbNewError = new System.Windows.Forms.TextBox();
         this.lbErrors = new System.Windows.Forms.ListBox();
         this.btnAddError = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // recordPanel
         // 
         this.recordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.recordPanel.Location = new System.Drawing.Point(3, 161);
         this.recordPanel.Name = "recordPanel";
         this.recordPanel.Size = new System.Drawing.Size(681, 572);
         this.recordPanel.TabIndex = 16;
         // 
         // btnSetResponse
         // 
         this.btnSetResponse.Location = new System.Drawing.Point(9, 96);
         this.btnSetResponse.Name = "btnSetResponse";
         this.btnSetResponse.Size = new System.Drawing.Size(75, 23);
         this.btnSetResponse.TabIndex = 15;
         this.btnSetResponse.Text = "Set Response";
         this.btnSetResponse.UseVisualStyleBackColor = true;
         this.btnSetResponse.Click += new System.EventHandler(this.btnSetResponse_Click);
         // 
         // cbxACCEPTED
         // 
         this.cbxACCEPTED.AutoSize = true;
         this.cbxACCEPTED.Location = new System.Drawing.Point(239, 35);
         this.cbxACCEPTED.Name = "cbxACCEPTED";
         this.cbxACCEPTED.Size = new System.Drawing.Size(83, 17);
         this.cbxACCEPTED.TabIndex = 14;
         this.cbxACCEPTED.Text = "ACCEPTED";
         this.cbxACCEPTED.UseVisualStyleBackColor = true;
         // 
         // cbxMatNumber
         // 
         this.cbxMatNumber.AutoSize = true;
         this.cbxMatNumber.Location = new System.Drawing.Point(9, 34);
         this.cbxMatNumber.Name = "cbxMatNumber";
         this.cbxMatNumber.Size = new System.Drawing.Size(89, 17);
         this.cbxMatNumber.TabIndex = 13;
         this.cbxMatNumber.Text = "MAT Number";
         this.cbxMatNumber.UseVisualStyleBackColor = true;
         // 
         // tbMatNumber
         // 
         this.tbMatNumber.Location = new System.Drawing.Point(114, 32);
         this.tbMatNumber.Name = "tbMatNumber";
         this.tbMatNumber.Size = new System.Drawing.Size(100, 20);
         this.tbMatNumber.TabIndex = 12;
         // 
         // tbNewError
         // 
         this.tbNewError.Location = new System.Drawing.Point(114, 68);
         this.tbNewError.Name = "tbNewError";
         this.tbNewError.Size = new System.Drawing.Size(514, 20);
         this.tbNewError.TabIndex = 11;
         this.tbNewError.TextChanged += new System.EventHandler(this.tbNewError_TextChanged);
         // 
         // lbErrors
         // 
         this.lbErrors.FormattingEnabled = true;
         this.lbErrors.Location = new System.Drawing.Point(114, 96);
         this.lbErrors.Name = "lbErrors";
         this.lbErrors.Size = new System.Drawing.Size(514, 43);
         this.lbErrors.TabIndex = 10;
         // 
         // btnAddError
         // 
         this.btnAddError.Location = new System.Drawing.Point(9, 66);
         this.btnAddError.Name = "btnAddError";
         this.btnAddError.Size = new System.Drawing.Size(75, 23);
         this.btnAddError.TabIndex = 9;
         this.btnAddError.Text = "AddError";
         this.btnAddError.UseVisualStyleBackColor = true;
         this.btnAddError.Click += new System.EventHandler(this.btnAddError_Click);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 1;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Controls.Add(this.recordPanel, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46739F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.53261F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 736);
         this.tableLayoutPanel1.TabIndex = 17;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.lbErrors);
         this.panel1.Controls.Add(this.btnSetResponse);
         this.panel1.Controls.Add(this.btnAddError);
         this.panel1.Controls.Add(this.cbxACCEPTED);
         this.panel1.Controls.Add(this.tbNewError);
         this.panel1.Controls.Add(this.cbxMatNumber);
         this.panel1.Controls.Add(this.tbMatNumber);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(3, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(632, 152);
         this.panel1.TabIndex = 17;
         // 
         // ResultsPane
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "ResultsPane";
         this.Size = new System.Drawing.Size(687, 736);
         this.Load += new System.EventHandler(this.ResultsPane_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel recordPanel;
      private System.Windows.Forms.Button btnSetResponse;
      private System.Windows.Forms.CheckBox cbxACCEPTED;
      private System.Windows.Forms.CheckBox cbxMatNumber;
      private System.Windows.Forms.TextBox tbMatNumber;
      private System.Windows.Forms.TextBox tbNewError;
      private System.Windows.Forms.ListBox lbErrors;
      private System.Windows.Forms.Button btnAddError;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Panel panel1;
   }
}
