using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_V5.BL;
using RMS_V5.DL;

namespace RMS_V5.Forms.CustomerForms
{
    public partial class FrmMyTickets : Form
    {
        public FrmMyTickets()
        {
            InitializeComponent();
        }

        private void FrmMyTickets_Load(object sender, EventArgs e)
        {
            BindData(TrainTicketDL.TicketList);
        }

        private void BindData(List<TrainTicket> ticketList)
        {
            gvTickets.DataSource = null;
            gvTickets.DataSource = ticketList;
            gvTickets.Columns["Date"].Visible = false;
            gvTickets.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserMenu frm = new FrmUserMenu();
            frm.Show();
        }

        private void gvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TrainTicket ticket = (TrainTicket)gvTickets.CurrentRow.DataBoundItem;

            if (gvTickets.Columns["Delete"].Index == e.ColumnIndex)
            {
                TrainTicketDL.TicketList.Remove(ticket);
                TrainTicketDL.storeDataIntoFile(Utility.TicketPath);
                BindData(TrainTicketDL.TicketList);
            }

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSort.Text == "Price")
            {
                List<TrainTicket> t = TrainTicketDL.TicketList.OrderBy(o => o.Price).ToList();
                BindData(t);
            }
            else if(cbSort.Text == "Booking No")
            {
                List<TrainTicket> t = TrainTicketDL.TicketList.OrderBy(o => o.Booking_no).ToList();
                BindData(t);
            }
            else if(cbSort.Text == "Date")
            {
                List<TrainTicket> t = TrainTicketDL.TicketList.OrderBy(o => o.Date).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Quantity")
            {
                List<TrainTicket> t = TrainTicketDL.TicketList.OrderBy(o => o.Quantity).ToList();
                BindData(t);
            }
            else if (cbSort.Text == "Train Name")
            {
                List<TrainTicket> t = TrainTicketDL.TicketList.OrderBy(o => o.TrainName).ToList();
                BindData(t);
            }
        }
    }
}
