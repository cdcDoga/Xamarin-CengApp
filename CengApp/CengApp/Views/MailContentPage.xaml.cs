using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MailContentPage : ContentPage
	{
		public MailContentPage (string to, string subject)
		{
			InitializeComponent ();

            entry_to.Text = to;
            entry_subject.Text = subject;
        }

        void sendMailFunction(object sender, EventArgs e)
        {
            //Send E-mail
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // using EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc.
                var email = new EmailMessageBuilder()
                  .To("to." + entry_to.Text)
                  //.Cc("cc.plugins@xamarin.com")
                  //.Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                  .Subject(entry_subject.Text)
                  .Body(entry_body.Text)
                  .Build();

                emailMessenger.SendEmail(email);
            }
        }
	}
}