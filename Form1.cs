using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            //textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = Environment.NewLine + string.Format("File[Renamed]: {0} renamed to {1} at time: {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime())));
            textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = string.Format("File[Renamed]: {0} renamed to {1} at time: {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime())));
        }

        public void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            //textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = Environment.NewLine + string.Format("File[Deleted]: {0} Deleted at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
            textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = string.Format("File[Deleted]: {0} Deleted at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public void watcher_Created(object sender, FileSystemEventArgs e)
        {
            //textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = Environment.NewLine + string.Format("File[Created]: {0} Created at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));// e.FullPath,
            textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = string.Format("File[Created]: {0} Created at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));// e.FullPath,
        }

        public void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            //textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = String.Concat(Environment.NewLine, string.Format("File[Changed]: {0} Changed at time: {1}", e.FullPath, DateTime.Now.ToLocalTime()))));// e.Name,
            textBoxOut1.Invoke((MethodInvoker)(() => textBoxOut1.Text = string.Format("File[Changed]: {0} Changed at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }


        public void watcher2_Deleted(object sender, FileSystemEventArgs e)
        {
            textBoxOut2.Invoke((MethodInvoker)(() => textBoxOut2.Text = string.Format("File[Deleted]: {0} Deleted at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public void watcher2_Renamed(object sender, RenamedEventArgs e)
        {
            textBoxOut2.Invoke((MethodInvoker)(() => textBoxOut2.Text = string.Format("File[Renamed]: {0} renamed to {1} at time: {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime())));
        }

        public void watcher2_Created(object sender, FileSystemEventArgs e)
        {
            textBoxOut2.Invoke((MethodInvoker)(() => textBoxOut2.Text = string.Format("File[Created]: {0} Created at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public void watcher2_Changed(object sender, FileSystemEventArgs e)
        {
            textBoxOut2.Invoke((MethodInvoker)(() => textBoxOut2.Text = string.Format("File[Changed]: {0} Changed at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }


        public void watcher3_Renamed(object sender, RenamedEventArgs e)
        {
            textBoxOut3.Invoke((MethodInvoker)(() => textBoxOut3.Text = string.Format("File[Renamed]: {0} renamed to {1} at time: {2}", e.OldName, e.Name, DateTime.Now.ToLocalTime())));
        }

        public void watcher3_Deleted(object sender, FileSystemEventArgs e)
        {
            textBoxOut3.Invoke((MethodInvoker)(() => textBoxOut3.Text = string.Format("File[Deleted]: {0} Deleted at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public void watcher3_Created(object sender, FileSystemEventArgs e)
        {
            textBoxOut3.Invoke((MethodInvoker)(() => textBoxOut3.Text = string.Format("File[Created]: {0} Created at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public void watcher3_Changed(object sender, FileSystemEventArgs e)
        {
            textBoxOut3.Invoke((MethodInvoker)(() => textBoxOut3.Text = string.Format("File[Changed]: {0} Changed at time: {1}", e.FullPath, DateTime.Now.ToLocalTime())));
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxLink1.Text != "")
            {
                string link1 = textBoxLink1.Text;
                char at = '@';
                char ex = '"';
                string newlink1 = at + ex + link1;
                newlink1 = newlink1.Substring(2);//Trim the first 2 characters. It was 98
                try
                {
                    FileSystemWatcher watcher = new FileSystemWatcher(newlink1); //(@"C:\");//at+ex+link1+ex //C:\Users\uert\Documents
                    watcher.EnableRaisingEvents = true;
                    watcher.IncludeSubdirectories = true;

                    //Add event handlers
                    watcher.Changed += watcher_Changed;
                    watcher.Created += watcher_Created;
                    watcher.Deleted += watcher_Deleted;
                    watcher.Renamed += watcher_Renamed;
                }
                catch
                {
                    MessageBox.Show("Error: Use the following format C:\\ or C:\\Users\\[userName]\\Documents or C:\\Users\\[userName]\\Desktop");//Escape backslah with another backslash
                }

            }
            if(textBoxLink2.Text != "")
            {
                string link2 = textBoxLink2.Text;
                char at = '@';
                char ex = '"';
                string newlink2 = at + ex + link2;
                newlink2 = newlink2.Substring(2);//Trim the first 2 characters. It was 98
                try
                {
                    FileSystemWatcher watcher2 = new FileSystemWatcher(newlink2); //(@"C:\");//at+ex+link1+ex //C:\Users\uert\Documents
                    watcher2.EnableRaisingEvents = true;
                    watcher2.IncludeSubdirectories = true;

                    //Add event handlers
                    watcher2.Changed += watcher2_Changed;
                    watcher2.Created += watcher2_Created;
                    watcher2.Deleted += watcher2_Deleted;
                    watcher2.Renamed += watcher2_Renamed;
                }
                catch
                {
                    MessageBox.Show("Error: Use the following format C:\\ or C:\\Users\\[userName]\\Documents or C:\\Users\\[userName]\\Desktop");
                }

            }
            if (textBoxLink3.Text != "")
            {
                string link3 = textBoxLink3.Text;
                char at = '@';
                char ex = '"';
                string newlink3 = at + ex + link3;
                newlink3 = newlink3.Substring(2);//Trim the first 2 characters. It was 98
                try
                {
                    FileSystemWatcher watcher3 = new FileSystemWatcher(newlink3); //(@"C:\");//at+ex+link1+ex //C:\Users\uert\Documents
                    watcher3.EnableRaisingEvents = true;
                    watcher3.IncludeSubdirectories = true;

                    //Add event handlers
                    watcher3.Changed += watcher3_Changed;
                    watcher3.Created += watcher3_Created;
                    watcher3.Deleted += watcher3_Deleted;
                    watcher3.Renamed += watcher3_Renamed;
                }
                catch
                {
                    MessageBox.Show("Error: Use the following format C:\\ or C:\\Users\\[userName]\\Documents or C:\\Users\\[userName]\\Desktop");
                }

            }
            else { }//Do Nothing
        }

        private void textBoxOut1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
