using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp.Core;
using TicketSystemApp.Models;

namespace TicketSystemApp
{
    public partial class MainForm1 : Form
    {
        int indexRow;
        private int InitialSize;

        public MainForm1()
        {
            InitializeComponent();
            InitialSize = this.Size.Height;
          
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ReDirectTo(Session.MForm);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
           UserControl c= this.Controls.OfType<UserControl>().Where(x => x.Tag == "ct").FirstOrDefault();
            if (c == null)
            {
                CreateTicketControl createTicketControl = new CreateTicketControl();
                createTicketControl.Location = new Point(60, 60);
                createTicketControl.Tag = "ct";
                createTicketControl.btn_createTicket.Click += Btn_createTicket;
                this.Controls.Add(createTicketControl);
            }
            else
            {
                this.Controls.Remove(c);
                this.Refresh();
                CreateTicketControl createTicketControl = new CreateTicketControl();
                createTicketControl.Location = new Point(60, 60);
                this.Size = new Size(this.Size.Width, InitialSize);
                createTicketControl.Tag = "ct";
                createTicketControl.btn_createTicket.Click += Btn_createTicket;
                this.Controls.Add(createTicketControl);
            }
            
        }

        private void Btn_createTicket(object sender, EventArgs e)
        {

            //Ticket ticket1 = new Ticket();
            //ticket1.Title = createTicketControl.Controls.GetType().Name;
            //ticket.Description = createTicketControl.txbx_Description.Text;
            //ticket.CraetedDate = DateTime.Now;
            //ticket.CreatedBy = Session.User.Id;

            //using(TicketsDbContext db=new TicketsDbContext())
            //{
            //    db.Tickets.Add(ticket);
            //    db.SaveChanges();
            //}

            Ticket ticket = this.MapToDataModell<Ticket>();
            ticket.CreatedBy = Session.User.Id;
            ticket.CraetedDate = DateTime.Now;

            using (TicketsDbContext td = new TicketsDbContext())
            {
                td.Tickets.Add(ticket);
                td.SaveChanges();
            }
                MessageBox.Show("Successfully added");
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            txt_Welcome.Text+= Session.User.Name;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl c = this.Controls.OfType<UserControl>().Where(x => x.Tag == "ct").FirstOrDefault();
            if (c == null)
            {
                ListTickeControl listTickeControl = new ListTickeControl();
                listTickeControl.Location= new Point(60, 60);
                listTickeControl.Tag = "ct";
                this.Controls.Add(listTickeControl);
            }
            else
            {
                this.Controls.Remove(c);
                this.Refresh();
                ListTickeControl listTickeControl = new ListTickeControl();
                listTickeControl.Location = new Point(60, 60);
                this.Size = new Size(this.Size.Width, InitialSize + 100);
                listTickeControl.Tag = "ct";
                listTickeControl.btn_UpdateTicket.Click += Btn_Update;
                this.Controls.Add(listTickeControl);
            }

        }

        private void Btn_Update(object sender, EventArgs e)
        {
            
            
        }

        private void MainForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  Session.MForm.Close();
        }
    }
}
