using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagellanMock
{
   public partial class MessageForm : Form
   {
      public MessageForm()
      {
         InitializeComponent();
      }

      public Dictionary<string, string> FieldMap { get; set; }

      public string FileName { get; set; }

      public void AddTab(string name, Dictionary<string, string> fieldMap)
      {
         ResultsPane rp = new ResultsPane { FieldMap = fieldMap, Dock = DockStyle.Fill };
         TabPage tp = new TabPage { Text = name };
         tp.Controls.Add(rp);
         tabControl1.TabPages.Add(tp);
      }

      private void MessageForm_Load(object sender, EventArgs e)
      {
         this.Text = FileName;
      }
   }
}