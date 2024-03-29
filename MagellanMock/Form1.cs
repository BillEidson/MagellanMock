﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MagellanMock
{
   /// <summary>
   /// Form1 class
   /// </summary>
   public partial class Form1 : Form
   {
      private const int checkForFileReleased = 5000;
      private const int pollingDelay = 2000;
      private System.Threading.Timer timer = null;

      public Form1()
      {
         InitializeComponent();
         timer = new System.Threading.Timer(TimerCB, this, Timeout.Infinite, Timeout.Infinite);
      }

      #region Timer Event Handler

      private void TimerCB(object state)
      {
         foreach (var file in Directory.GetFiles(tbDropFolder.Text, "*.*"))
            ProcessInputFile(file);

         timer.Change(pollingDelay, Timeout.Infinite);
      }

      #endregion Timer Event Handler

      #region Private Implementation

      private void DoFolderLookupDialog(TextBox tb)
      {
         if (!string.IsNullOrEmpty(tb.Text) && Directory.Exists(tb.Text))
            folderBrowser.SelectedPath = tb.Text;

         switch (folderBrowser.ShowDialog())
         {
            case DialogResult.OK:
               tb.Text = folderBrowser.SelectedPath;
               break;
         }
      }

      private void ProcessInputFile(string file)
      {
         this.Invoke(() =>
         {
            lbResults.Items.Add("Moving file: " + file);
         });

         while (!TryFileOpenExclusive(file))
            System.Threading.Thread.Sleep(checkForFileReleased);

         this.Invoke(() =>
         {
            var result = new MessageProcessor().Execute(file, true);
            var sb = new System.Text.StringBuilder();

            result.Select(s => { return s.Response + "\r\n"; })
                  .OrderBy(s => s.Substring(0, 9))
                  .ToArray()
                  .Select(s => { sb.Append(s); return s; })
                  .ToArray();

            var fileName = Path.Combine(tbPickupFolder.Text, Path.GetFileName(file) + "R");

            if (File.Exists(fileName))
               File.Delete(fileName);

            File.WriteAllText(fileName, sb.ToString());
         });

         var procFileName = Path.Combine(tbProcessedFolder.Text, Path.GetFileName(file));

         if (File.Exists(procFileName))
            File.Delete(procFileName);
         File.Move(file, procFileName);
      }

      private bool TryFileOpenExclusive(string file)
      {
         try
         {
            using (var fs = File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
               return true;
         }
         catch (IOException iox) { Trace.WriteLine(iox.Message); }

         return false;
      }

      #endregion Private Implementation

      #region UI Event Handlers

      private void btnDropFolder_Click(object sender, EventArgs e)
      {
         DoFolderLookupDialog(tbDropFolder);
      }

      private void btnParse_Click(object sender, EventArgs e)
      {
         OpenFileDialog ofd = new OpenFileDialog();
         ofd.Title = "Open a Magellan File";
         ofd.InitialDirectory = tbPickupFolder.Text;

         var tis = new Tuple<int, string>(2, "2");

         switch (ofd.ShowDialog())
         {
            case DialogResult.OK:
               {
                  var result = new MessageProcessor().Execute(ofd.FileName, false);
                  MessageForm popupForm = new MessageForm { FileName = result[0].FileName };
                  foreach (var i in result)
                     popupForm.AddTab(i.Key, i.FieldMap);
                  popupForm.Show();
                  break;
               }
         }
      }

      private void btnPickupFolder_Click(object sender, EventArgs e)
      {
         DoFolderLookupDialog(tbPickupFolder);
      }

      private void btnProcessedFolder_Click(object sender, EventArgs e)
      {
         DoFolderLookupDialog(tbProcessedFolder);
      }

      private void btnRun_Click(object sender, EventArgs e)
      {
         btnRun.Enabled = false;
         lbResults.Items.Clear();
         timer.Change(pollingDelay, Timeout.Infinite);
      }

      #endregion UI Event Handlers
   }
}