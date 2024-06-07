using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBot.Pokemon.WinForms
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("Info über {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0} Beta", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assemblyattributaccessoren

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
        // OK-Button Clickaction
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();    // Close Form
        }
        // Button Linktree clickaction
        private void btn_linktree_Click(object sender, EventArgs e)
        {
            try
            {
                // URL der Webseite angeben
                string urllinktree = "https://www.linktr.ee/furby87";

                // Befehl für die Ausführung von 'start' über 'cmd.exe'
                string command = $"/c start {urllinktree}";

                // Prozess starten
                Process.Start("cmd.exe", command);
            }
            catch (Exception ex)
            {   // Show Messagebox for Error
                MessageBox.Show("Fehler beim Öffnen der Webseite: " + ex.Message);
                Close();    // Close Form
                return;
            }
        }
        // Button Twitch Clickaction
        private void btn_Twitch_Click(object sender, EventArgs e)
        {
            /* ERROR-Method

            try
            {
                // URL der Webseite angeben
                string urltwitch = "https://www.twitch.tv/furby1987";
                // Starte Prozess (URL)
                Process.Start(urltwitch);
            }
            // catch exeptions
            catch (Exception ex)
            {
                // Show Messagebox for Erroroi
                MessageBox.Show("Fehler beim Öffnen der Webseite: " + ex.Message);
                // Close Form
                Close();
                return;
            }
            */

            try
            {
                // URL der Webseite angeben
                string urltwitch = "https://www.twitch.tv/furby1987";

                // Befehl für die Ausführung von 'start' über 'cmd.exe'
                string command = $"/c start {urltwitch}";

                // Prozess starten
                Process.Start("cmd.exe", command);
            }
            catch (Exception ex)
            {   // Show Messagebox for Error
                MessageBox.Show("Fehler beim Öffnen der Webseite: " + ex.Message);
                Close();    // Close Form
                return;
            }

        }
        // Button Discord Clickaction
        private void btn_discord_Click(object sender, EventArgs e)
        {
            // URL der Webseite angeben
            string urldiscord = "https://www.discord.gg/MzVM8DVM9w#";
            try
                /*  ERROR Method
            {
                Process.Start(urldiscord);
            }   // catch exceptions
            catch (Exception ex)
            {   // Show Messagebox for Error
                MessageBox.Show("Fehler beim Öffnen der Webseite: " + ex.Message);
            }
            // close form
            Close();
            */

            {
                // Befehl für die Ausführung von 'start' über 'cmd.exe'
                string command = $"/c start {urldiscord}";

                // Prozess starten
                Process.Start("cmd.exe", command);
            }
            catch (Exception ex)
            {   // Show Messagebox for Error
                MessageBox.Show("Fehler beim Öffnen der Webseite: " + ex.Message);
                Close();    // Close Form
                return;
            }
        }
    }
}
