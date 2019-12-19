using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp.Core;
using TicketSystemApp.Models;

namespace TicketSystemApp.Forms
{
    public partial class LoginForm : Form
    {
        User user = null;
        User CurrentUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginModel lg = new LoginModel
            {
                Email = txt_email.Text,
                Password = txt_password.Text,
                ConfirPassword = txt_confirmPassword.Text
            };
           if(this.IsValid(lg, lbl_error))
            {
                using(TicketsDbContext tdc=new TicketsDbContext())
                {
                    user = tdc.Users.Where(x => x.Email.Equals(lg.Email, StringComparison.OrdinalIgnoreCase)
                            && x.Password.Equals(lg.Password, StringComparison.OrdinalIgnoreCase))
                            .FirstOrDefault();

                }
                if (user != null)
                {
                    using (TicketsDbContext tdc = new TicketsDbContext())
                    {
                        CurrentUser = tdc.Users.Where(x => x.Email.Equals(lg.Email, StringComparison.OrdinalIgnoreCase)
                                && x.Password.Equals(lg.Password, StringComparison.OrdinalIgnoreCase))
                                .FirstOrDefault();
                        Session.User = CurrentUser;
                    }

                    this.ReDirectTo<MainForm1>();

                }
                else
                {
                    MessageBox.Show("Login Faild");
                }
            }

            //ValidationContext con = new ValidationContext(loginModel);
            //List<ValidationResult> validationResults = new List<ValidationResult>();
            //if(!Validator.TryValidateObject(loginModel, con, validationResults,true))
            //{
            //    foreach (var item in validationResults)
            //    {
            //        lbl_error.Text = item.ErrorMessage;
            //    }
            //}
            //else
            //{
            //    using (TicketsDbContext tdc = new TicketsDbContext())
            //    {
            //        user = tdc.Users
            //            .Where(x => x.Email.Equals(loginModel.Email, StringComparison.OrdinalIgnoreCase)
            //              && x.Password.Equals(loginModel.Password, StringComparison.OrdinalIgnoreCase))
            //              .FirstOrDefault();
            //    }
               
            //    if (user != null)
            //    {
            //         this.ReDirectTo<MainForm1>();
            //        //new MainForm().ShowDialog();--yuxardia yazdigimiz numune asagidaki numunaye eyidir
            //        //this.Close();
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("Login Faild");
            //    }
                
            //}
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MForm.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
