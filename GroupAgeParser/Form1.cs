using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using System.IO;

namespace GroupAgeParser
{
    public partial class MainForm : Form
    {
        VkApi api;
        ulong Offset = 0;
        int ActualYear = DateTime.Now.Year;
        DateTime StartTime;
        List<long> SkippedUsersId = new List<long>();
        int ParsedUsers = 0, SkippedUsers = 0, ParsedFriends = 0, FriendsYears = 0, UsersYears = 0;
        public MainForm()
        {
            InitializeComponent();
            consoleTextBox.AppendText("-> Welcome to GroupAgeParser.\n");
            SetRadioButtonPosition(fastMode);
            SetRadioButtonPosition(detailedMode);
            SetTextBoxPosition(consoleTextBox);
            SetButtonPosition(parseButton);
            SetButtonPosition(configButton);
            SetButtonPosition(helpButton);
            CreateFolders();
        }

        public void ParseFunction(string parseMode)
        {
            Random timeout = new Random();
            char[] sep = ".".ToCharArray();
            StartTime = DateTime.Now;
            while (true)
            {
                VkCollection<User> GroupMembers = GetMembersV(Offset);
                foreach (var uid in GroupMembers)
                {
                    if (uid.BirthDate != null)
                    {
                        string bDate = uid.BirthDate;
                        if (Regex.Match(bDate, "\\b\\d{1,2}\\.\\d{1,2}\\.\\d{4}\\b").Success)
                        {
                            string[] bDateSplit = bDate.Split(sep);
                            int thisUserYears = ActualYear - int.Parse(bDateSplit[2]);
                            if (thisUserYears < 60)
                            {
                                UsersYears += thisUserYears;
                                ParsedUsers += 1;
                            }
                            else
                            {
                                SkippedUsers += 1;
                            }
                        }
                        else
                        {
                            SkippedUsers += 1;
                            if (uid.IsClosed.HasValue && uid.IsClosed.Value == false)
                            {
                                SkippedUsersId.Add(uid.Id);
                            }
                        }
                    }
                }
                Offset += (ulong)GroupMembers.Count;
                if (ParsedUsers > 0)
                {
                    string EndTime = (DateTime.Now - StartTime).ToString();
                    consoleTextBox.Invoke((MethodInvoker)delegate
                    {
                        consoleTextBox.Clear();
                        consoleTextBox.AppendText($"[InProcess]\nGroupID: {Properties.Settings.Default["groupId"]}\nMiddleYears: {UsersYears / ParsedUsers}\nTime: {EndTime.Substring(0, EndTime.Length - 8)}\nUsersOffset: {Offset}\nParsedUsers: {ParsedUsers}\nSkippedUsers: {SkippedUsers}\n");
                    });
                    if (Offset >= GroupMembers.TotalCount)
                    {
                        break;
                    }
                }
                Thread.Sleep(GetRandomTimeoutSeconds(timeout));
            }

            if (parseMode == "detailed")
            {
                consoleTextBox.Invoke((MethodInvoker)delegate
                {
                    consoleTextBox.Clear();
                    consoleTextBox.AppendText("-> The detailed mode was selected: start of additional data processing");
                });
                if (SkippedUsersId.Count > 0)
                {
                    foreach (var uid in SkippedUsersId)
                    {
                        Thread.Sleep(GetRandomTimeoutSeconds(timeout));
                        GetUserFriendsMiddleAge(uid);
                    }
                }
            }
            SaveResult();
            ResetVars();
            consoleTextBox.Invoke((MethodInvoker)delegate
            {
                consoleTextBox.Clear();
                consoleTextBox.AppendText($"-> the result was saved to a file {Properties.Settings.Default["groupId"]}.txt");
            });
        }

        public void GetUserFriendsMiddleAge(long uid)
        {
            VkCollection<User> UserFriends = api.Friends.Get(new FriendsGetParams()
            {
                UserId = uid,
                Order = VkNet.Enums.SafetyEnums.FriendsOrder.Random,
                Count = 1000,
                Fields = ProfileFields.BirthDate
            });
            char[] sep = ".".ToCharArray();
            foreach (var fid in UserFriends)
            {
                if (fid.BirthDate != null)
                {
                    string bDate = fid.BirthDate;
                    if (Regex.Match(bDate, "\\b\\d{1,2}\\.\\d{1,2}\\.\\d{4}\\b").Success)
                    {
                        string[] bDateSplit = bDate.Split(sep);
                        int thisFriendYears = ActualYear - int.Parse(bDateSplit[2]);
                        if (thisFriendYears < 60)
                        {
                            ParsedFriends += 1;
                            FriendsYears += thisFriendYears;
                            string EndTime = (DateTime.Now - StartTime).ToString();
                            consoleTextBox.Invoke((MethodInvoker)delegate
                            {
                                consoleTextBox.Clear();
                                consoleTextBox.AppendText($"[UserFriends]\nUserID: {uid}\nParsedFriends: {ParsedFriends}\nFriendsMiddleAge: {FriendsYears / ParsedFriends}\n[InProcess]\nGroupID: {Properties.Settings.Default["groupId"]}\nMiddleYears: {UsersYears / ParsedUsers}\nTime: {EndTime.Substring(0, EndTime.Length - 8)}\nUsersOffset: {Offset}\nParsedUsers: {ParsedUsers}\nSkippedUsers: {SkippedUsers}\n");
                            });
                        }
                    }
                }
            }
            if (ParsedFriends > 10)
            {
                SkippedUsers -= 1;
                ParsedUsers += 1;
                UsersYears += FriendsYears / ParsedFriends;
            }
            ParsedFriends = 0;
            FriendsYears = 0;
        }

        public int GetRandomTimeoutSeconds(Random timeout)
        {
            int aTimeoutMillis = (int)Properties.Settings.Default["aTimeout"] * 1000;
            int bTimeoutMillis = (int)Properties.Settings.Default["bTimeout"] * 1000;
            return timeout.Next(aTimeoutMillis, bTimeoutMillis + 1000);
        }

        public VkCollection<User> GetMembersV(ulong newOffset)
        {
            VkCollection<User> result = api.Groups.GetMembers(new GroupsGetMembersParams
            {
                GroupId = Properties.Settings.Default["groupId"].ToString(),
                Fields = UsersFields.BirthDate,
                Offset = (long)newOffset,
                Count = 1000
            });
            return result;
        }

        public void SaveResult()
        {
            string path = Directory.GetCurrentDirectory() + $"\\Results\\{Properties.Settings.Default["groupId"]}.txt";
            StreamWriter FileWriter = new StreamWriter(path, false);
            FileWriter.Write($"MiddleYears: {UsersYears / ParsedUsers}\nAllUsers: {Offset}\nParsedUsers: {ParsedUsers}\nSkippedUsers: {SkippedUsers}\n");
            FileWriter.Close();
        }

        public void ResetVars()
        {
            Offset = 0;
            ParsedUsers = 0;
            SkippedUsers = 0;
            UsersYears = 0;
            SkippedUsersId.Clear();
        }

        public bool AuthFunction()
        {
            api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                AccessToken = Properties.Settings.Default["token"].ToString()
            });
            try
            {
                IEnumerable<long> testId = new List<long> { 1 };
                var result = api.Users.Get(userIds: testId);
                consoleTextBox.AppendText($"-> API: available; VkApiVersion: {api.VkApiVersion.Version}\n");
                return true;
            }
            catch(VkApiException)
            {
                consoleTextBox.AppendText("-> invalid access token passed\n");
                return false;
            }
        }

        public void CreateFolders()
        {
            if (!Directory.Exists("Results"))
            {
                Directory.CreateDirectory("Results");
            }
        }

        public void SetRadioButtonPosition(RadioButton actualRadioButton)
        {
            int x = (ClientSize.Width - actualRadioButton.Width) / 2;
            actualRadioButton.Location = new Point(x, actualRadioButton.Location.Y);
        }

        public void SetTextBoxPosition(RichTextBox actualRichTextBox)
        {
            int x = (ClientSize.Width - actualRichTextBox.Width) / 2;
            actualRichTextBox.Location = new Point(x, actualRichTextBox.Location.Y);
        }

        public void SetButtonPosition(System.Windows.Forms.Button actualButton)
        {
            int x = (ClientSize.Width - actualButton.Width) / 2;
            actualButton.Location = new Point(x, actualButton.Location.Y);
        }

        private void fastMode_CheckedChanged(object sender, EventArgs e)
        {
            if (fastMode.Checked)
            {
                Properties.Settings.Default["parseMode"] = "fast";
                Properties.Settings.Default.Save();
                consoleTextBox.AppendText("-> mode changed to fast\n");
            }
        }

        private void detailedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (detailedMode.Checked)
            {
                Properties.Settings.Default["parseMode"] = "detailed";
                Properties.Settings.Default.Save();
                consoleTextBox.AppendText("-> mode changed to detailed\n");
            }
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            if(AuthFunction())
            {
                try
                {
                    Thread SecondThread = new Thread(() => ParseFunction(Properties.Settings.Default["parseMode"].ToString()));
                    SecondThread.Start();
                }
                catch (InvalidParameterException)
                {
                    MessageBox.Show("Error: invalid parameter specified when calling the API function", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
