using CengApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Messaging;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CengApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PeoplePage : ContentPage
	{
        public ObservableCollection<Lecturer<ImageButton, Label>> lecturersCall { get; set; }
        public ObservableCollection<Lecturer<ImageButton, Label>> lecturersMail { get; set; }

        public PeoplePage ()
		{
			InitializeComponent ();

            lecturersCall = new ObservableCollection<Lecturer<ImageButton, Label>>();
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn1,
                lblContact = phone1
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn2,
                lblContact = phone2
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn3,
                lblContact = phone3
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn4,
                lblContact = phone4
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn5,
                lblContact = phone5
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn6,
                lblContact = phone6
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn7,
                lblContact = phone7
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn8,
                lblContact = phone8
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn9,
                lblContact = phone9
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn10,
                lblContact = phone10
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn11,
                lblContact = phone11
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn12,
                lblContact = phone12
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn13,
                lblContact = phone13
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn14,
                lblContact = phone14
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn15,
                lblContact = phone15
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn16,
                lblContact = phone16
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn17,
                lblContact = phone17
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn18,
                lblContact = phone18
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn19,
                lblContact = phone19
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn20,
                lblContact = phone20
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn21,
                lblContact = phone21
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn22,
                lblContact = phone22
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn23,
                lblContact = phone23
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn24,
                lblContact = phone24
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn25,
                lblContact = phone25
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn26,
                lblContact = phone26
            });
            lecturersCall.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn27,
                lblContact = phone27
            });


            lecturersMail = new ObservableCollection<Lecturer<ImageButton, Label>>();
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn1_2,
                lblContact = mail1
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn2_2,
                lblContact = mail2
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn3_2,
                lblContact = mail3
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn4_2,
                lblContact = mail4
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn5_2,
                lblContact = mail5
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn6_2,
                lblContact = mail6
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn7_2,
                lblContact = mail7
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn8_2,
                lblContact = mail8
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn9_2,
                lblContact = mail9
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn10_2,
                lblContact = mail10
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn11_2,
                lblContact = mail11
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn12_2,
                lblContact = mail12
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn13_2,
                lblContact = mail13
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn14_2,
                lblContact = mail14
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn15_2,
                lblContact = mail15
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn16_2,
                lblContact = mail16
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn17_2,
                lblContact = mail17
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn18_2,
                lblContact = mail18
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn19_2,
                lblContact = mail19
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn20_2,
                lblContact = mail20
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn21_2,
                lblContact = mail21
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn22_2,
                lblContact = mail22
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn23_2,
                lblContact = mail23
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn24_2,
                lblContact = mail24
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn25_2,
                lblContact = mail25
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn26_2,
                lblContact = mail26
            });
            lecturersMail.Add(new Lecturer<ImageButton, Label>
            {
                btnName = btn27_2,
                lblContact = mail27
            });

        }

        void Call(object sender, EventArgs e)
        {
            string callNum = "";

            foreach (Lecturer<ImageButton, Label> item in lecturersCall)
            {
                if(sender.GetHashCode().ToString() == item.btnName.GetHashCode().ToString())
                {
                    callNum = item.lblContact.Text;
                }
            }
            
            // Make Phone Call
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(transformPhoneNumber(callNum));
        }

        string transformPhoneNumber(string lblContactNum)
        {
            return "+90" + lblContactNum.Substring(5, 3) + lblContactNum.Substring(9, 3) + lblContactNum.Substring(13, 4);
        }

        async void sendMail(object sender, EventArgs e)
        {
            string mailAddress = "";

            foreach (Lecturer<ImageButton, Label> item in lecturersMail)
            {
                if (sender.GetHashCode().ToString() == item.btnName.GetHashCode().ToString())
                {
                    mailAddress = item.lblContact.Text;
                }
            }

            string mail_to = transformMailAddress(mailAddress);
            
            var action = await DisplayActionSheet("Mailinizin konusunu seçin:", "Çıkış", null, "Mentor", "Sınav Hakkında", "Proje/Staj Hakkında", "Ödev Teslimi", "İtiraz", "Diğer");
            string mail_subject = action;

            if(action == "Çıkış" || action == null)
            {
                
            }
            else
            {
                await Navigation.PushModalAsync(new MailContentPage(mail_to, mail_subject));
            }


        }

        string transformMailAddress(string lblMailNum)
        {
            return lblMailNum.Substring(6);
        }
    }
}