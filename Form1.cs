using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MergeOfFiles_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRU_Source_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.Title = "Выберите папку...";
            dlg.IsFolderPicker = true;
            //dlg.InitialDirectory = currentDirectory;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox1.Text = dlg.FileName;
                // Do something with selected folder string
            }
            
        }
         private void btnENG_Source_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.Title = "Выберите папку...";
            dialog.IsFolderPicker = true;
            
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox2.Text = dialog.FileName;
                // Do something with selected folder string
            }
            // Do something with selected folder string
        }


    }
}
