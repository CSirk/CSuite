using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyApplicationContext : ApplicationContext
        {
            NotifyIcon notifyIcon;

            public MyApplicationContext()
            {
                MenuItem cTime = new MenuItem("CTime", new EventHandler(LaunchCTime));
                MenuItem cTimeAlarm = new MenuItem("Alarm", new EventHandler(LaunchCTimeAlarm));
                MenuItem cTimeCountDown = new MenuItem("Countdown", new EventHandler(LaunchCTimeCountdown));
                MenuItem cTimeStopWatch = new MenuItem("Stopwatch", new EventHandler(LaunchStopwatch));
                MenuItem cTimeTimer = new MenuItem("Timer", new EventHandler(LaunchCTimeTimer));

                cTime.MenuItems.AddRange(new MenuItem[] { cTimeStopWatch, cTimeTimer, cTimeCountDown, cTimeAlarm });


                MenuItem cCalc = new MenuItem("CCalc", new EventHandler(LaunchCCalc));
                MenuItem cCalcCalculator = new MenuItem("Calculator", new EventHandler(LaunchCCalc));

                cCalc.MenuItems.AddRange(new MenuItem[] { cCalcCalculator });

                MenuItem cMoney = new MenuItem("CMoney", new EventHandler(LaunchCMoney));

                MenuItem cMail = new MenuItem("CMail", new EventHandler(LaunchCMail));
                MenuItem cMailInbox = new MenuItem("Inbox", new EventHandler(LaunchCMailInbox));
                MenuItem cMailNewEmail = new MenuItem("New Email", new EventHandler(LaunchCMailNewEmail));


                cMail.MenuItems.AddRange(new MenuItem[] { cMailNewEmail, cMailInbox });

                MenuItem cAssist = new MenuItem("CAssist", new EventHandler(LaunchCAssist));
                MenuItem cAssistReminder = new MenuItem("Reminder", new EventHandler(LaunchCAssistReminder));
                MenuItem cAssistAddressBook = new MenuItem("Address Book", new EventHandler(LaunchCAssistAddressBook));
                MenuItem cAssistSchedule = new MenuItem("Schedule", new EventHandler(LaunchCAssistSchedule));
                MenuItem cAssistCalendar = new MenuItem("Calendar", new EventHandler(LaunchCAssistCalendar));
                MenuItem cAssistCalculator = new MenuItem("Calculator", new EventHandler(LaunchCAssistCalculator));

                cAssist.MenuItems.AddRange(new MenuItem[] { cAssistReminder, cAssistAddressBook, cAssistSchedule, cAssistCalendar, cAssistCalculator });


                MenuItem cNote = new MenuItem("CNote", new EventHandler(LaunchCNote));
                MenuItem cNoteTextPad = new MenuItem("Text Pad", new EventHandler(LaunchCNoteTextPad));
                MenuItem cNoteNote = new MenuItem("Note", new EventHandler(LaunchCNoteNote));

                cNote.MenuItems.AddRange(new MenuItem[] { cNoteNote, cNoteTextPad });

                MenuItem cBase = new MenuItem("CBase", new EventHandler(LaunchCBase));
                MenuItem cBaseNewDatabase = new MenuItem("New Database", new EventHandler(LaunchCBaseNewDatabase));
                MenuItem cBaseOpenDatabase = new MenuItem("Open Database", new EventHandler(LaunchCBaseOpenDatabase));

                cBase.MenuItems.AddRange(new MenuItem[] { cBaseNewDatabase, cBaseOpenDatabase });

                MenuItem crypt10n = new MenuItem("Crypt10n", new EventHandler(LaunchCryp10n));
                MenuItem cryptext = new MenuItem("Cryptext", new EventHandler(LaunchCryptext));

                crypt10n.MenuItems.AddRange(new MenuItem[] { cryptext });

                MenuItem cMote = new MenuItem("CMote", new EventHandler(LaunchCMote));

                MenuItem exit = new MenuItem("Exit", new EventHandler(ExitProgram));


                notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new Icon(@"csuite.ico");

                notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { cAssist, cCalc, cBase, cMail,
                    cMoney, cMote, cTime, crypt10n, exit });

                notifyIcon.Visible = true;

            }

            private void LaunchCAssistCalculator(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void ExitProgram(object sender, EventArgs e)
            {
                if (MessageBox.Show("Exit CSuite?",
                        "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    notifyIcon.Dispose();
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }

            private void LaunchCMote(object sender, EventArgs e)
            {
                //var cMote = new CMote.Form1();
                //cMote.Show();
            }

            private void LaunchCryp10n(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCryptext(object sender, EventArgs e)
            {
                //var cryptext = new Crypt10n.Cryptext();
                //cryptext.Show();
            }

            private void LaunchCBaseOpenDatabase(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCBaseNewDatabase(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCBase(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCNoteNote(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCNoteTextPad(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCNote(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCAssistCalendar(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCAssistSchedule(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCAssistAddressBook(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCAssistReminder(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCAssist(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCMailInbox(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCMailNewEmail(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCMail(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCCalc(object sender, EventArgs e)
            {
                var calculator = new CCal.Calculator();
                calculator.Show();
            }

            private void LaunchCMoney(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void LaunchCTimeAlarm(object sender, EventArgs e)
            {
                var alarm = new CTime.Alarm();
                alarm.Show();
            }

            private void LaunchCTimeCountdown(object sender, EventArgs e)
            {
                var countdown = new CTime.Countdown();
                countdown.Show();
            }

            private void LaunchCTimeTimer(object sender, EventArgs e)
            {
                var timer = new CTime.Timer();
                timer.Show();
            }

            private void LaunchStopwatch(object sender, EventArgs e)
            {
                var stopwatch = new CTime.Stopwatch();
                stopwatch.Show();
            }

            private void LaunchCTime(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }
        }
    }
}
