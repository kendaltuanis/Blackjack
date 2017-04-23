using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Runtime.Serialization;
using System.IO;
using System.Threading;
using Google.Apis.Oauth2.v2;
using Google.Apis.Plus.v1;
using Blackjack.Controladores;
using System.Linq;
using System.Data;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Flows;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Net;

namespace Blackjack.Vistas
{
    public partial class Sesion : Form
    {

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json

        private static string[] Scopes = { PlusService.Scope.UserinfoEmail, PlusService.Scope.UserinfoProfile };
        int cont = 1;
        private UsuariosControl osuariocontrol;


        public Sesion()
        {
            InitializeComponent();
            this.osuariocontrol = new UsuariosControl();
        }

        private void CargarSesion() {

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


            }

            // Create Gmail API service.
            if (credential != null)
            {
                var oauthSerivce =
                    new Oauth2Service(new BaseClientService.Initializer { HttpClientInitializer = credential });
                var use = oauthSerivce.Userinfo.Get().ExecuteAsync();

                Console.WriteLine("Credential file saved to: " + use.Result.GivenName + use.Result.FamilyName);
                if (insert)
                    osuariocontrol.Insertar(user, use.Result.GivenName, use.Result.FamilyName);


            }
        }

        private void Sesion_Load(object sender, EventArgs e)
        {
            CargarSesion();
        }

        private void cargar() {

        }

        const string ClientId = "628014192471-imo47sdo5h3762d1og6lbvevnpqcintg.apps.googleusercontent.com";
        const string ClientSecret = "iBTDxE_-hxG6pxC_RiOyUyez";
        const string RedirectUriLocalhost = "http://localhost";
       static string code = "";

        static async Task<string> GetAuthorizationCode()
        {
            var startUri = new Uri
        (
            "https://accounts.google.com/o/oauth2/auth"
            + "?scope=" + "https://www.googleapis.com/auth/userinfo.profile"
            + "&redirect_uri=" + RedirectUriLocalhost
            + "&response_type=" + "code"
            + "&client_id=" + ClientId
        );



            Uri endUri = new Uri("http://localhost"); // returns the code in the ResponseData

            /*   WebAuthenticationResult result = await WebAuthenticationBroker.AuthenticateAsync
                    (
                        WebAuthenticationOptions.None,
                        startUri,
                        endUri
                    );
                    /*/

            string j= "XxBdHZ_WY8C0CCTDKITehuvSlxuoMaDa6qyNrwq6B3Q";
            return ExtractAuthorizationCode(j);

        }

        static string ExtractAuthorizationCode(string input)
        {
            int start = input.IndexOf("code=") + 5;
            int length = input.Length - start;
            string f = input.Substring(start, length);
            code = f;

            return f;
        }

        async Task<Token> GetAccessToken(string code)
        {
            var content = new StringContent
            (
                "code=" + code
                + "&client_id=" + ClientId
                + "&client_secret=" + ClientSecret
                + "&redirect_uri=" + RedirectUriLocalhost
                + "&grant_type=" + "authorization_code"
            );
            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var client = new HttpClient();

            var response = await client.PostAsync("https://accounts.google.com/o/oauth2/token", content);

            var result = await response.Content.ReadAsStringAsync(); // could also use ReadAsStreamAsync and avoid conversion to Stream
            Console.WriteLine(result);
            return ExtractAccessToken(result);
        }

        Token ExtractAccessToken(string input)
        {
            var stream = new MemoryStream(Encoding.Unicode.GetBytes(input));

            var serializer = new DataContractJsonSerializer(typeof(Token));
            Console.WriteLine((Token)serializer.ReadObject(stream));
            return (Token)serializer.ReadObject(stream);
        }

        [DataContract]
        public class Token
        {
            [DataMember(Name = "access_token")] public string AccessToken { get; set; }
            [DataMember(Name = "token_type")] public string TokenType { get; set; }
            [DataMember(Name = "expires_in")] public string ExpiresIn { get; set; }
            [DataMember(Name = "id_token")] public string IdToken { get; set; }
            [DataMember(Name = "refresh_token")] public string RefreshToken { get; set; }
        }

        async Task<User> GetUserInfo(Token token)
        {
            var query = "https://www.googleapis.com/oauth2/v1/userinfo?access_token=" + token.AccessToken;

            var client = new HttpClient();

            string user = await client.GetStringAsync(query); // could also use GetStreamAsync and avoid conversion to Stream

            return ExtractUser(user);
        }
        User ExtractUser(string input)
        {
            var stream = new MemoryStream(UnicodeEncoding.Unicode.GetBytes(input));

            var serializer = new DataContractJsonSerializer(typeof(User));

            return (User)serializer.ReadObject(stream);
        }

        [DataContract]
        public class User
        {
            [DataMember(Name = "id")] public string Id { get; set; }
            [DataMember(Name = "name")] public string Name { get; set; }
            [DataMember(Name = "given_name")] public string GivenName { get; set; }
            [DataMember(Name = "family_name")] public string FamilyName { get; set; }
            [DataMember(Name = "link")] public string Link { get; set; }
            [DataMember(Name = "picture")] public string PictureUri { get; set; }
            [DataMember(Name = "gender")] public string Gender { get; set; }
            [DataMember(Name = "locale")] public string Locale { get; set; }
        }
     


        }
    }

