using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Utils;

namespace Discord_Tokens_Checker
{
    public partial class Form1 : Form
    {
        public static List<string> Tokens = new List<string>();
        private List<string> WorkingTokens = new List<string>();
        private List<string> WorkingTokensData = new List<string>();
        private List<string> NotWorkingTokens = new List<string>();
        private List<string> UnverifiedToknes = new List<string>();

        private string OutPutPath = Application.StartupPath + "\\CheckedTokens";
        public static Location FormLocation = null;
        private Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            Movers movers = new Movers(this);

            panel1.MouseDown += movers.MouseDown;
            panel1.MouseUp += movers.MouseUp;
            panel1.MouseMove += movers.MouseMove;

            RainbowLabel.MouseDown += movers.MouseDown;
            RainbowLabel.MouseUp += movers.MouseUp;
            RainbowLabel.MouseMove += movers.MouseMove;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    if (!frm2.Visible)
                        Thread.Sleep(500);
                    else
                        Thread.Sleep(10);

                    MethodInvoker invoker = delegate
                    {
                        string text = $"Loaded: {Tokens.Count} " +
                                      $"Working: {WorkingTokens.Count}; " +
                                      $"Unverified: {UnverifiedToknes.Count}; " +
                                      $"Invaild: {NotWorkingTokens.Count}";
                        if (RainbowLabel.Text != text) RainbowLabel.Text = text;

                        Point frm2Point = new Point(this.Location.X + this.Width + 10, this.Location.Y);
                        if (frm2.Location != frm2Point) frm2.Location = frm2Point;

                        Point rainbowLabelPoint = new Point((panel1.Size.Width - RainbowLabel.Size.Width) / 2, label1.Location.Y);
                        if (RainbowLabel.Location != rainbowLabelPoint) RainbowLabel.Location = rainbowLabelPoint;

                        this.Text = $"Remaining: {Tokens.Count - WorkingTokens.Count - NotWorkingTokens.Count - UnverifiedToknes.Count}";
                    };
                    this.Invoke(invoker);
                }
            });
            thread.Start();

            if (!Directory.Exists(OutPutPath))
            {
                try { Directory.CreateDirectory(OutPutPath); }
                catch (Exception ex) { this.Invoke((MethodInvoker)delegate { MessageBox.Show(ex.Message); Environment.Exit(0); }); }
            }

            OutputFilePath.Text = OutPutPath;
        }

        private void InputTokensButton_Click(object sender, EventArgs e)
        {
            if (!frm2.Visible)
            {
                FormLocation = new Location(this.Location.X + this.Width - 90, this.Location.Y);
                frm2.ShowInTaskbar = false;

                frm2.FormClosed += Form2_FormClosed;
                frm2.Show();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = new Form2();
            WorkingTokens = new List<string>();
            NotWorkingTokens = new List<string>();
            UnverifiedToknes = new List<string>();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Tokens.Count <= 0)
            {
                MessageBox.Show("You need to load some token(s) in order to check them...");
                return;
            }

            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < Tokens.Count; ++i)
                {
                    if (!Functions.IsValidToken(Tokens[i]))
                    {
                        this.Invoke((MethodInvoker)delegate { OutPutTextBox.AppendText($"\n\n\n#{WorkingTokens.Count + UnverifiedToknes.Count + NotWorkingTokens.Count + 1}\nToken: {Tokens[i]}\nInvaild token."); });
                        NotWorkingTokens.Add(Tokens[i]);
                        continue;
                    }

                    if (!Functions.IsTokenUsable(Tokens[i]))
                    {
                        this.Invoke((MethodInvoker)delegate { OutPutTextBox.AppendText($"\n\n\n#{WorkingTokens.Count + UnverifiedToknes.Count + NotWorkingTokens.Count + 1}\nToken: {Tokens[i]}\nUnverified token."); });
                        UnverifiedToknes.Add(Tokens[i]);
                        continue;
                    }

                    DiscordUser data = new DiscordUser(Tokens[i]);

                    string message = $"\n\n\n#{WorkingTokens.Count + UnverifiedToknes.Count + NotWorkingTokens.Count + 1}\nToken: {data.Token}\n" +
                                     $"\n{data.Username}#{data.Discriminator}" +
                                     $"\nCreation Time: {data.CreationTime}" +
                                     $"\nEmail Verified: {data.Verified}" +
                                     $"\nEmail: {data.Email}" +
                                     $"\nPhone Number: {data.PhoneNumber}" +
                                     $"\nId: {data.Id}" +
                                     $"\nAvatar: {data.AvatarURL}" +
                                     $"\nGuilds: {data.GuildsCount}" +
                                     $"\nPremium: {data.Nitro}" +
                                     $"\nPayment Connected: {data.PaymentConnected}";

                    MethodInvoker invoker = delegate
                    {
                        OutPutTextBox.AppendText(message);
                        WorkingTokens.Add(message);
                        WorkingTokensData.Add(Tokens[i]);
                    };
                    this.Invoke(invoker);
                }

                try
                {
                    File.WriteAllText(OutPutPath, string.Join(Environment.NewLine, UnverifiedToknes));
                    File.WriteAllText(Application.StartupPath + "\\CheckedTokens\\Working.txt", string.Join(Environment.NewLine, WorkingTokensData));
                    File.WriteAllText(Application.StartupPath + "\\CheckedTokens\\Working-Data.txt", string.Join("", WorkingTokens));
                    File.WriteAllText(Application.StartupPath + "\\CheckedTokens\\NotWorking.txt", string.Join(Environment.NewLine, NotWorkingTokens));
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                Console.Beep(1200, 100);
            });
            thread.Start();
        }

        private void TimerRGB_Tick(object sender, EventArgs e)
        {
            float time = (float)((DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() % 62830) / 2000.0);
            Color rgb = Color.FromArgb(255,
                        (int)((Math.Sin(time) * .5f + .5f) * 255.0f),
                        (int)((Math.Sin(time + 2 * Math.PI / 3) * .5f + .5f) * 255.0f),
                        (int)((Math.Sin(time + 4 * Math.PI / 3) * .5f + .5f) * 255.0f));

            ExitButton.ForeColor = rgb;
            RainbowLabel.ForeColor = rgb;
        }

        private void OutPutTextBox_TextChanged(object sender, EventArgs e)
        {
            OutPutTextBox.ScrollToCaret();
        }

        private void ChangeOutputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OutPutPath = dialog.SelectedPath;
                OutputFilePath.Text = OutPutPath;
            }
        }
    }
}