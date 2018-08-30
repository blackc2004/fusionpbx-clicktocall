using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using ClickToCall.Properties;

namespace ClickToCall
{
    class ProcessIcon : IDisposable
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        private static NotifyIcon ni = new NotifyIcon();
        public static NotifyIcon NotifyIcon { get { return ni; } }
        public ProcessIcon()
        {
            //ni = new NotifyIcon();
        }

        public void Display()
        {
            ni.MouseClick += new MouseEventHandler(ni_MouseClick);
            ni.Icon = Resources.ClickToCall;
            ni.Text = "System Tray Demo";
            ni.Visible = true;

            ni.ContextMenuStrip = new ContextMenus().Create();
            Form f = new mySettings();
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        void ni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlaceCall PC = new PlaceCall();
                PC.f_placeCall(ni);
            }
        }
    }
}
