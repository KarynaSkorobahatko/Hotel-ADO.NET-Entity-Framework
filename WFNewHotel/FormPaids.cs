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
    public partial class FormPaids : Form
    {
        private NewHotelDataEF.hotelEntities ctx_paid;
        public FormPaids()
        {
            InitializeComponent();
            ctx_paid = new NewHotelDataEF.hotelEntities();

            ctx_paid.Paids.Load();
            this.paidBindingSource.DataSource = ctx_paid.Paids.Local.ToBindingList();

            ctx_paid.Orders.Load();
            this.orderBindingSource.DataSource = ctx_paid.Orders.Local.ToBindingList();

        }

    }
}
