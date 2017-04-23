using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Reflection;

namespace Blackjack.Vistas
{
    public partial class Form1 : Form
    {
        private const string AppId = "1467256803348585";
        private readonly Uri _loginUrl;
        public FacebookOAuthResult _FacebookOAuthResult { get; private set; }
        private const string _ExtendedPermissions = "user_about_me,publish_stream,offline_access";

        public Form1()
        {
            if (string.IsNullOrEmpty(AppId))
                throw new ArgumentNullException("appId");
            var _oauthClient = new FacebookOAuthClient { AppId = AppId };

            IDictionary<string, object> _loginParameters = new Dictionary<string, object>();
            _loginParameters["response_type"] = "token";
            _loginParameters["display"] = "popup";
            if (!string.IsNullOrEmpty(_ExtendedPermissions))
            {
                _loginParameters["scope"] = _ExtendedPermissions;
            }
            _loginUrl = _oauthClient.GetLoginUrl(_loginParameters);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(_loginUrl.AbsoluteUri);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult _oauthResult=null;

            if (FacebookOAuthResult.TryParse(e.Url, out _oauthResult))
            {
                this._FacebookOAuthResult = _oauthResult;
                this.DialogResult = _FacebookOAuthResult.IsSuccess ? DialogResult.OK : DialogResult.No;
                try
                {
                    var fb = new FacebookClient(_FacebookOAuthResult.AccessToken);
                    var result = (IDictionary<string, object>)fb.Get("me");
                    var id = (string)result["id"];
                  //  string profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}", id, "square");
                    MDIParent1 frmmdi;
                    frmmdi = (MDIParent1)this.MdiParent;
                    // frmmdi.pictureBox1.LoadAsync(profilePictureUrl);
                    try
                    {
                        Type tresult = result.GetType();
                        var objname = (string)result["name"];
                        var firstName = (string)result["first_name"];
                        var lastName = (string)result["last_name"];

                        //   frmmdi.textBox1.Text = id;
                        //  frmmdi.textBox2.Text = firstName;
                        // frmmdi.textBox3.Text = lastName;
                        //   frmmdi.label2.Text = "Successfully connected";
                    }
                    catch (FacebookApiException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                catch (FacebookApiException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
