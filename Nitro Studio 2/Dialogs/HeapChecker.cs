using GotaSoundIO.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitroStudio2
{
    public partial class HeapChecker : Form
    {
        int heap_used = 0;
        int heap_size = 0;
        public HeapChecker(int used, int size)
        {
            InitializeComponent();
            heap_size = size;
            heap_used = used;
        }

        public static string GetBytesSize(int byteCount)
        {
            string[] suf = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + " " + suf[place];
        }

        private void HeapChecker_Load(object sender, EventArgs e)
        {
            pVisual.Maximum = heap_size;
            pVisual.Value = heap_used;
            double d = heap_used / heap_size;
            lUsage.Text = "Heap Usage: " + GetBytesSize(heap_used) + " / " + GetBytesSize(heap_size) + "(" + (Math.Round(d))*100 + "%)";
            lRemain.Text = "Heap Remaining: " + GetBytesSize(heap_size - heap_used);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
