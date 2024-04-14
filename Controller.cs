using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHCalculator
{
    internal class Controller : ApplicationContext
    {
        public Controller(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "-firstrun")
                {
                    File.Delete(ClassData.ApplicationFolder + "\\" + "changelog.txt");
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://raw.githubusercontent.com/Rovok/HHCalculator/main/changelog.txt", ClassData.ApplicationFolder + "\\" + "changelog.txt");
                    webClient.Dispose();
                    Process.Start("notepad.exe", ClassData.ApplicationFolder + "\\" + "changelog.txt");
                }
            }
            UpdateCheck();
            ClassFunctions.UpdateQualitiesDict(ClassFunctions.ReadUserQualities(ClassData.FilePath));
            Form main = new MainForm();
            main.Show();
        }

        private void UpdateCheck()
        {
            try
            {
                WebClient wc = new WebClient();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                Stream FirstStream = wc.OpenRead(ClassData.UpdateInfoLink);
                StreamReader FirstSR = new StreamReader(FirstStream);
                string[] InfoLines = new string[0];
                string TempLine = string.Empty;
                string NewVersion = string.Empty;
                while ((TempLine = FirstSR.ReadLine()) != null)
                {
                    Array.Resize(ref InfoLines, InfoLines.Length + 1);
                    InfoLines[InfoLines.Length - 1] = TempLine;
                    if (InfoLines[InfoLines.Length - 1].Contains("Version"))
                    {
                        FirstStream.Close();
                        NewVersion = InfoLines[InfoLines.Length - 1].Split('=')[1];
                        break;
                    }
                }
                FirstStream.Close();
                if (NewVersion == string.Empty) MessageBox.Show("Отсутствует упоминание версии");
                string[] LocalVersionArray = ClassData.Version.Split('.').ToArray();
                string[] NewVersionArray = NewVersion.Split('.').ToArray();
                bool NeedToUpdate = false;
                if (Int32.Parse(LocalVersionArray[0]) < Int32.Parse(NewVersionArray[0]))
                {
                    NeedToUpdate = true;
                }
                else if (Int32.Parse(LocalVersionArray[0]) == Int32.Parse(NewVersionArray[0]))
                {
                    if (Int32.Parse(LocalVersionArray[1]) < Int32.Parse(NewVersionArray[1])) NeedToUpdate = true;
                }
                if (NeedToUpdate)
                {
                    if (!File.Exists(ClassData.ApplicationFolder + "\\" + "Updater.exe")) wc.DownloadFile(ClassData.UpdaterLink, ClassData.ApplicationFolder + "\\" + "Updater.exe");
                    ProcessStartInfo StartInfo = new ProcessStartInfo(ClassData.ApplicationFolder + "\\" + "Updater.exe");
                    StartInfo.Arguments = ClassData.UpdateDownloadLink + " " + ClassData.UpdateInfoLink + " " + Application.ExecutablePath;
                    Process Updater = new Process();
                    Updater.StartInfo = StartInfo;
                    Updater.Start();
                    Environment.Exit(0);
                }
                wc.Dispose();
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.Message, "Не удалось произвести обновление");
                Environment.Exit(0);
            }
        }
    }
}
