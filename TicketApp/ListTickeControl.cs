using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp.Models;

namespace TicketSystemApp
{
    public partial class ListTickeControl : UserControl
    {
        int indexRow;
        public ListTickeControl()
        {
            InitializeComponent();
        }

        private void ListTickeControl_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = null;
            using (TicketsDbContext db = new TicketsDbContext())
            {
                tickets = db.Tickets.ToList();
                db.SaveChanges();
            }
            ticketListGrid.DataSource = tickets;

        }

        private void ticketListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ticketListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = ticketListGrid.Rows[indexRow];
            txbx_Title.Text = row.Cells[4].Value.ToString();
            txbx_Description.Text = row.Cells[5].Value.ToString();
        }

        private void btn_UpdateTicket_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = ticketListGrid.Rows[indexRow];
            newDataRow.Cells[4].Value = txbx_Title.Text;
            newDataRow.Cells[5].Value = txbx_Description.Text;
            using(TicketsDbContext db=new TicketsDbContext())
            {
              Ticket ticket=  db.Tickets.Where(x => x.Id == indexRow+1).FirstOrDefault();
                ticket.Title = txbx_Title.Text;
                ticket.Description = txbx_Description.Text;
                db.SaveChanges();
                MessageBox.Show("Update Syccessfully");
            }
        }
    }
}
