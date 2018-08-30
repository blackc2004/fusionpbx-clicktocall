using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MOBZystems;

namespace ClickToCall
{
    public partial class mySettings : Form
    {
        public mySettings()
        {
            InitializeComponent();
            getData();
            string REGROOT = "SOFTWARE\\ClickToCall\\";
            RegistryKey root = Registry.CurrentUser.CreateSubKey(REGROOT);
            string hotkeyString = (string)root.GetValue("Hotkey", "C");
            bool shiftKey = BoolFromString((string)root.GetValue("Shift", "1"));
            bool controlKey = BoolFromString((string)root.GetValue("Control", "1"));
            bool altKey = BoolFromString((string)root.GetValue("Alt", "0"));
            bool windowsKey = BoolFromString((string)root.GetValue("Windows", "0"));
            MOBZystems.Hotkey userHotkey = null;
            // Create a hot key with the settings:
            userHotkey = new MOBZystems.Hotkey(MOBZystems.Hotkey.KeyCodeFromString(hotkeyString), shiftKey, controlKey, altKey, windowsKey);
            // Catch the 'Pressed' event
            userHotkey.Pressed += new HandledEventHandler(UserHotkey_Pressed);
            userHotkey.Register(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "API_KEY", API_KEY_TXT.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "DOMAIN_TXT", DOMAIN_TXT.Text);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "SRC_TXT", SRC_TXT.Text);
            if(autoAnswer.Checked)
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "AUTO_ANSWER", "true");
            else
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "AUTO_ANSWER", "false");

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (startOnBoot.Checked)
                rk.SetValue("ClickToCall", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("ClickToCall", false);
            this.Close();
        }

        private void getData()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string startRK = rk.GetValue("ClickToCall","null").ToString();
            if (startRK != "null")
            {
                startOnBoot.Checked = true;
            }
            string API_KEY = "NULL";
            string DOMAIN_URL = "NULL";
            string SRC = "NULL";
            try { API_KEY = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "API_KEY", "NULL").ToString(); }
            catch { API_KEY = "NULL"; }
            try { DOMAIN_URL = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "DOMAIN_TXT", "NULL").ToString(); }
            catch { DOMAIN_URL = "NULL"; }
            try { SRC = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "SRC_TXT", "NULL").ToString(); }
            catch { SRC = "NULL"; }
            if (DOMAIN_URL != "NULL")
            {
                this.DOMAIN_TXT.Text = DOMAIN_URL.ToString();
            }
            if (API_KEY != "NULL")
            {
                this.API_KEY_TXT.Text = API_KEY.ToString();
            }
            if (SRC != "NULL")
            {
                this.SRC_TXT.Text = SRC.ToString();
            }
        }
        /// <summary>
        /// The hotkey was pressed! Handle it
        /// </summary>
        private void UserHotkey_Pressed(object sender, HandledEventArgs e)
        {
            PlaceCall PC = new PlaceCall();
            PC.f_placeCall(ProcessIcon.NotifyIcon);
        }
        private bool BoolFromString(string s)
        {
            if (s == null || s != "1")
                return false;
            else
                return true;
        }

    }
}

