using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Security.Cryptography;
using System.Threading;
using Google.Apis.Plus.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using Google.Apis.Oauth2.v2;

namespace Blackjack.Vistas
{
    public partial class FrmLogin : MetroForm
    {

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json

        private static string[] Scopes = { PlusService.Scope.UserinfoEmail, PlusService.Scope.UserinfoProfile };

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           Sesion se = new Sesion();
           se.ShowDialog();
        }


        private void CargarSesion()
        {

            string user = "user";
            UserCredential credential = null;
            Boolean insert = true;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/data");

                DirectoryInfo di = new DirectoryInfo(credPath);

                int size = di.GetFiles().Length;


                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets/*new ClientSecrets { ClientId= "107089363064538587085"}/*/,
                    Scopes, user,
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                //credential.


            }

            // Create Gmail API service.
            if (credential != null)
            {
                var oauthSerivce =
                    new Oauth2Service(new BaseClientService.Initializer { HttpClientInitializer = credential });
                var use = oauthSerivce.Userinfo.Get().ExecuteAsync();

                Console.WriteLine("Credential file saved to: " + use.Result.GivenName + use.Result.FamilyName);
                //if (insert)
                   // osuariocontrol.Insertar(user, use.Result.GivenName, use.Result.FamilyName);


            }
        }








    }
}
