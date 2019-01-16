using CengApp.Models;
using CengApp.AppSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CengApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        void SignInFunction(object sender, EventArgs e)
        {
            User user = new User(entry_email.Text, entry_password.Text);
            
            if (user.CheckInfo())
            {
                DisplayAlert("Giriş Başarılı!","E-mail ve şifre onaylandı.","TAMAM");
                Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Giriş Başarısız!", "E-mail ve şifre eşleşmedi.", "ÇIKIŞ");
            }
        }

        void SignUpFunction(object sender, EventArgs e)
        {
            LocalStorageSettings.MailKey = entry_email.Text;
            LocalStorageSettings.PasswordKey = entry_password.Text;

            DisplayAlert("Tebrikler!", "Kaydınız başarıyla tamamlandı.", "TAMAM");
        }
        
        void ForgotPasswordFunction(object sender, EventArgs e)
        {
            if(!validateMail(entry_email.Text))
                DisplayAlert("Uyarı!", "Lütfen geçerli bir mail adresi girin.", "TAMAM");
            else
            {
                string newPassword = "";

                for (int i = 0; i < 6; i++)
                {
                    Random rnd = new Random();
                    newPassword = newPassword + rnd.Next(0, 9);
                }

                // Send e-mail
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("cdc.estu@gmail.com", "Çağıl Doğa Çakır - ESTÜ");
                    mail.To.Add(entry_email.Text);
                    mail.Subject = "ESTÜ - Yeni Şifreniz!";
                    mail.Body = "Bilgi güvenliği nedeniyle lütfen şifrenizi kimseyle paylaşmayın. Eskişehir Teknik Üniversitesi Bilgisayar Mühendisliği Bölümü uygulamasına giriş için yeni şifreniz: " + newPassword;
                    mail.IsBodyHtml = true;

                    SmtpClient smtpServer = new SmtpClient();
                    smtpServer.Host = "smtp.gmail.com";
                    smtpServer.Port = 587;
                    smtpServer.Credentials = new System.Net.NetworkCredential("cdc.estu@gmail.com", "password2018ESTU");
                    smtpServer.EnableSsl = true;
                    smtpServer.Send(mail);

                    LocalStorageSettings.MailKey = entry_email.Text;
                    LocalStorageSettings.PasswordKey = newPassword;

                    DisplayAlert("Şifreniz yenilendi!", "Artık mail adresinize gelen yeni şifreyi kullanabilirsiniz.", "TAMAM");
                }
                catch(Exception ex)
                {
                    DisplayAlert("Yeni şifre mail olarak göderilemedi!", ex.Message, "İPTAL");
                }
            }
        }

        bool validateMail(string email)
        {
            bool validation = false;

            //emailregex.com
            var mailPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(email, mailPattern) && entry_email != null) validation = true;

            return validation;
        }
    }
}