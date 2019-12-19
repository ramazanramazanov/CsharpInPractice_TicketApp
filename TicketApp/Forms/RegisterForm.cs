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
    public partial class RegisterForm : Form
    {
        EntityValidator entityValidator = null;
        public RegisterForm()
        {
             entityValidator = new EntityValidator();
            InitializeComponent();
            Session.MForm = this;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            //model formalasdirilir+
            //model validasiya olunur-yoxlanilmasi
            //ugurludursa model bazaya yerlesdirilir

            //1)fill model
          //  User user = this.MapToDataModel<User>();
            User registerUser = new User
            {
                Name = txt_Name.Text,
                Surname = txt_Surname.Text,
                Email = txt_Email.Text,
                Password = txt_Password.Text,
                RoleType = RoleType.User,
                IsActive = true,
                InvalideTry = 0,
                RegisterDate = DateTime.Now

            };

            // try to validate

            //IEnumerable<ValidationResult> errorRusult= entityValidator.Validate(registerUser);
            // //if hass errors...
            // if (errorRusult.Count()>0)
            // {
            //     //foreach (var item in errorRusult)
            //     //{
            //     //    lbl_error.Text += item.ErrorMessage + "\n";--kohne usul
            //     //}
            //       this.DisplayError(errorRusult, lbl_error); 
            // }
           if (this.IsValid(registerUser, lbl_error))
            {
                using (TicketsDbContext tdc = new TicketsDbContext())
                {
                    tdc.Users.Add(registerUser);
                    tdc.SaveChanges();

                }
            }

            //else
            //{//else.. add db
            //    using (TicketsDbContext tdc = new TicketsDbContext())
            //    {
            //        tdc.Users.Add(registerUser);
            //        tdc.SaveChanges();
                    
            //    }

            //}

        }
      

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
             new LoginForm().ShowDialog(); ;
            
        }
    }
}
