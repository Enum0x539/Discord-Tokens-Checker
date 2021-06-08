using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Utils
{
    public class Movers
    {
        private static Point downPoint = Point.Empty;
        private Form form = null;

        public Movers(Form frm)
        {
            this.form = frm;
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                form.Location = new Point(form.Left + e.X - downPoint.X, form.Top + e.Y - downPoint.Y);
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

    }

    public class Location
    {
        public int x;
        public int y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class DiscordUser
    {
        private int Version = 9;

        public DateTimeOffset CreationTime = new DateTimeOffset();
        public string Token;
        public ulong Id;
        public string Username;
        public string Discriminator;
        public string Email;
        public string PhoneNumber;
        public string Locale;
        public string AvatarURL;
        public bool Nitro;
        public bool Nsfw;
        public bool Mfa;
        public bool Verified;
        public bool PaymentConnected;
        public int GuildsCount;
        public int GuildsOwnershipCount;

        public DiscordUser(string Token)
        {
            this.Token = Token;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v{this.Version}/users/@me");
            request.Headers.Set("Authorization", Token);
            string responseStr = "";

            try
            {
                responseStr = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream()).ReadToEnd().Replace("}", "").Replace("{", " ");
                string[] fields = responseStr.Split(',');

                foreach (string field in fields)
                {
                    int fieldLength = field.IndexOf('"', 2) - 2;
                    string fieldValue = field.Substring(field.IndexOf(':') + 2).Replace("\"", "");
                    switch (field.Substring(2, fieldLength))
                    {
                        case "id":
                            this.Id = ulong.Parse(fieldValue);
                            this.CreationTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((this.Id >> 22) + 1420070400000UL));
                            break;
                        case "username":
                            this.Username = fieldValue;
                            break;
                        case "avatar":
                            this.AvatarURL = string.Format("https://cdn.discordapp.com/avatars/{0}/{1}", this.Id, fieldValue);
                            break;
                        case "discriminator":
                            this.Discriminator = fieldValue;
                            break;
                        case "locale":
                            this.Locale = fieldValue;
                            break;
                        case "nsfw_allowed":
                            fieldValue = Char.ToUpper(fieldValue[0]).ToString() + fieldValue.Substring(1);
                            this.Nsfw = bool.Parse(fieldValue);
                            break;
                        case "mfa_enabled":
                            fieldValue = Char.ToUpper(fieldValue[0]).ToString() + fieldValue.Substring(1);
                            this.Mfa = bool.Parse(fieldValue);
                            break;
                        case "email":
                            this.Email = fieldValue;
                            break;
                        case "verified":
                            fieldValue = Char.ToUpper(fieldValue[0]).ToString() + fieldValue.Substring(1);
                            this.Verified = bool.Parse(fieldValue);
                            break;
                        case "phone":
                            this.PhoneNumber = fieldValue == "null" ? "None" : fieldValue;
                            break;
                        case "premium_type":
                            this.Nitro = fieldValue != "null";
                            break;
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            request = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v{this.Version}/users/@me/guilds");
            request.Headers.Set("Authorization", Token);

            try
            {
                responseStr = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream()).ReadToEnd().Replace("}", "").Replace("{", " ").Replace("[", "").Replace("]", "");
                string[] fields = responseStr.Replace(" ", "").Split(',');

                for (int i = 0; i < fields.Length; ++i)
                {
                    if (!fields[i].Contains(":"))
                        continue;

                    string field = fields[i].Replace("\"", "").Split(':')[0];
                    string fieldValue = fields[i].Replace("\"", "").Split(':')[1];

                    switch (field)
                    {
                        case "id":
                            this.GuildsCount++;
                            break;
                        case "owner":
                            this.GuildsOwnershipCount = fieldValue == "true" ? this.GuildsOwnershipCount + 1:this.GuildsOwnershipCount;
                            break;
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            request = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v{this.Version}/users/@me/billing/payment-sources");
            request.Headers.Set("Authorization", Token);

            try
            {
                responseStr = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream()).ReadToEnd().Replace("}", "").Replace("{", " ").Replace("[", "").Replace("]", "");
                if (responseStr != "")
                    this.PaymentConnected = true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }

    public class Functions
    {
        public static bool IsValidToken(string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/users/@me");
            try
            {
                request.Headers.Set("Authorization", token);
                return !String.IsNullOrEmpty(new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream()).ReadToEnd());
            }
            catch { return false; }
        }

        public static bool IsTokenUsable(string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/users/0");
            request.Headers.Set("Authorization", token);

            try
            {
                using (HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse())
                { }
            }
            catch (WebException ex)
            {
                return ex.Message.Contains("404");
            }

            return false;
        }
    }
}
