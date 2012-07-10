using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MagellanMock
{
   public partial class ResultsPane : UserControl
   {
      public ResultsPane()
      {
         InitializeComponent();
      }

      public Dictionary<string, string> FieldMap { get; set; }

      private void ResultsPane_Load(object sender, EventArgs e)
      {
         btnAddError.Enabled = false;
         DataGridView dg = new DataGridView();
         dg.Visible = true;
         dg.Dock = DockStyle.Fill;
         dg.DataSource = FieldMap.ToArray();
         dg.RowHeadersVisible = false;
         dg.ColumnHeadersVisible = false;
         dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         recordPanel.Controls.Add(dg);
      }

      private void btnAddError_Click(object sender, EventArgs e)
      {
         btnAddError.Enabled = false;
         lbErrors.Items.Add(tbNewError.Text);
         tbNewError.Text = string.Empty;
      }

      private void tbNewError_TextChanged(object sender, EventArgs e)
      {
         if (tbNewError.Text.Length > 0)
            btnAddError.Enabled = true;
         else
            btnAddError.Enabled = false;
      }

      private void btnSetResponse_Click(object sender, EventArgs e)
      {
      }
   }
}
