using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Store the path of the textfile in your system 
            //create a filestream to read the file c:\tmp\security.jpg
            var fileStream = new FileStream(@"C:/tmp/security.jpg", FileMode.Open, FileAccess.Read);
            var fileDest = @"C:/tmp/bak_security.jpg";
            byte[] buffer = new byte[20480];
            int bytesRead;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                using (var fileStreamDest = new FileStream(fileDest, FileMode.Append, FileAccess.Write))
                {
                    fileStreamDest.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
