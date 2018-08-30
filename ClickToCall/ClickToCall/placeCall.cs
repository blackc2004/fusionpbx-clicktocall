using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using ClickToCall.Properties;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Automation;
//using System.Runtime.InteropServices;
//using System.Windows.Interop;
using System.Windows;
using System.Text.RegularExpressions;

namespace ClickToCall
{
    class PlaceCall
    {
        public void f_placeCall(NotifyIcon ni)
        {
            string DEST = getDID();

            string API_KEY = "NULL";
            string DOMAIN_URL = "NULL";
            string SRC = "NULL";
            //string DEST = "NULL";
            string AUTO_ANSWER = "NULL";
            try { API_KEY = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "API_KEY", "NULL").ToString(); }
            catch { API_KEY = "NULL"; }
            try { DOMAIN_URL = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "DOMAIN_TXT", "NULL").ToString(); }
            catch { DOMAIN_URL = "NULL"; }
            try { SRC = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "SRC_TXT", "NULL").ToString(); }
            catch { SRC = "NULL"; }
            try { AUTO_ANSWER = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ClickToCall", "AUTO_ANSWER", "false").ToString(); }
            catch { AUTO_ANSWER = "false"; }

            if (DOMAIN_URL == "NULL" || API_KEY == "NULL" || SRC == "NULL")
            {
                ni.ShowBalloonTip(5000, "ERROR!", "Please setup your settings first", ToolTipIcon.Info);
            }
            else if (DEST == "NULL")
            {
                ni.ShowBalloonTip(5000, "ERROR!", "Could not find a phone number to call.", ToolTipIcon.Info);
            }
            else
            {
                string URL = "https://" + DOMAIN_URL + "/app/click_to_call/click_to_call.php?domain=" + DOMAIN_URL + "&key=" + API_KEY + "&src=" + SRC + "&dest=" + DEST + "&auto_answer=" + AUTO_ANSWER + "&src_cid_name=" + DEST + "&src_cid_number=" + DEST + "";
                ni.ShowBalloonTip(5000, "Calling...", Regex.Replace(DEST,@"(\d{3})(\d{3})(\d{4})","($1) $2-$3"), ToolTipIcon.Info);
                var cli = new WebClient();
                string data = cli.DownloadString(URL);
                //MessageBox.Show(data);
            }
        }
        private string getDID()
        {
            string selectedText = "null";
            var element = AutomationElement.FocusedElement;
            if (element != null)
            {
                object pattern;
                if(element.TryGetCurrentPattern(TextPattern.Pattern, out pattern))
                {
                    var tp = (TextPattern) pattern;
                    var sb = new StringBuilder();
                    foreach (var r in tp.GetSelection())
                    {
                        sb.AppendLine(r.GetText(-1));
                    }
                    selectedText = sb.ToString();
                }
            }
            if (selectedText != "null")
            {
                //System.Windows.MessageBox.Show("Automation:"+selectedText);
                return new string(selectedText.Where(char.IsDigit).ToArray());
            }

            //Using CTRL C with clipboard, doesn't always work.
            //Sleep so that the user releases the hotkey before calling the copy function.
            Thread.Sleep(1000);
            Keyboard.SimulateKeyStroke('c', ctrl:true,alt:false,shift:false);
            //SendKeys.Send("^c");
            Thread.Sleep(100);
            if (System.Windows.Clipboard.ContainsText())
            {
                selectedText = System.Windows.Clipboard.GetText();
                if (selectedText != "null")
                {
                    //System.Windows.MessageBox.Show("Copy:" + selectedText);
                    return new string(selectedText.Where(char.IsDigit).ToArray());
                }
            }

            return "NULL";
        }



    
    }
}
