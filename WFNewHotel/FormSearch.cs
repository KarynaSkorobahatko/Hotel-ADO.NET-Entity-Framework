using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using NewHotelDataEF;

namespace WFNewHotel
{
    public partial class FormSearch : Form
    {
        private NewHotelDataEF.hotelEntities ctx_client;
        

        public FormSearch()
        {
            InitializeComponent();
            ctx_client = new NewHotelDataEF.hotelEntities();

            ctx_client.Clients.Load();
            this.clientBindingSource.DataSource = ctx_client.Clients.Local.ToBindingList();

            ctx_client.Orders.Load();
            this.orderBindingSource.DataSource = ctx_client.Orders.Local.ToBindingList();
        }

        private void FindOrder()
        {
            var chE = ctx_client.ChangeTracker.Entries<Form1>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0) MessageBox.Show("Необхідно зберегти зміни!", "Перегляд замовлень");
            else
            {
                ctx_client.Dispose();
                ctx_client = new NewHotelDataEF.hotelEntities();

                var query = (from c in ctx_client.Clients
                             select c);

                if (!String.IsNullOrWhiteSpace(tBName.Text))
                {
                    query = query.Where(c => c.name.Contains(tBName.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBSurN.Text))
                {
                    query = query.Where(c => c.surname.Contains(tBSurN.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBMidN.Text))
                {
                    query = query.Where(c => c.midname.Contains(tBMidN.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBPass.Text))
                {
                    query = query.Where(c => c.passport.Contains(tBPass.Text));
                }

                clientBindingSource.DataSource = query.ToList();
            }
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            FindOrder();
        }
    }
}
