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
    public partial class Form1 : Form
    {
        private NewHotelDataEF.hotelEntities ctx;
        public Form1()
        {
            InitializeComponent();
            ctx = new NewHotelDataEF.hotelEntities();

            ctx.Employees.Load();
            this.employeeBindingSource.DataSource = ctx.Employees.Local.ToBindingList();

            ctx.Positions.Load();
            this.positionBindingSource.DataSource = ctx.Positions.Local.ToBindingList();

            ctx.Clients.Load();
            this.clientBindingSource.DataSource = ctx.Clients.Local.ToBindingList();

            ctx.Fines.Load();
            this.fineBindingSource.DataSource = ctx.Fines.Local.ToBindingList();

            ctx.Additional_services.Load();
            this.additionalservicesBindingSource.DataSource = ctx.Additional_services.Local.ToBindingList();

            ctx.Rooms.Load();
            this.roomBindingSource.DataSource = ctx.Rooms.Local.ToBindingList();
            
            ctx.Categories.Load();
            this.categoryBindingSource.DataSource = ctx.Categories.Local.ToBindingList();

            ctx.Orders.Load();
            this.orderBindingSource.DataSource = ctx.Orders.Local.ToBindingList();
        }

        private void button_save_Employee_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_Employee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = (Employee)dataGridView1.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Orders where (c.id_employee == emp.id_employee) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! Співробітник ще не закінчив свої обов'язки.", "Помилка видалення співробітника!");
                else
                {
                    employeeBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс...Щось пішло не так ( ", "Помилка видалення інформації!");
                throw;
            }
        }

        private void button_save_Client_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_Client_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)dataGridView2.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Orders where (c.id_client == client.Id_Client ) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! Клієнт має активне замовлення.", "Помилка видалення клієнта!");
                else
                {
                    clientBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс...Щось пішло не так ( ", "Помилка видалення інформації!");
                throw;
            }
        }

        private void button_save_fine_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_fine_Click(object sender, EventArgs e)
        {
            fineBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void button_save_addserv_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_addserv_Click(object sender, EventArgs e)
        {
            additionalservicesBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void button_save_Room_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_Room_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = (Room)dataGridView5.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Orders where (c.id_room == room.id_room) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! В даній кімнаті наразі живуть люди.", "Помилка видалення кімнати!");
                else
                {
                    roomBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс...Щось пішло не так ( ", "Помилка видалення інформації!");
                throw;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            FormSearch forms = new FormSearch();
            forms.ShowDialog();
        }

        private void button_save_ord_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_delete_ord_Click(object sender, EventArgs e)
        {
            try
            {
                Order room = (Order)dataGridView6.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Orders where (c.checkout_date >= DateTime.Today) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! Клієнти ще не розрахувались.", "Помилка видалення замовлення!");
                else
                {
                    orderBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Упс...Щось пішло не так ( ", "Помилка видалення інформації!");
                throw;
            }
        }

        private void button_show_paids_Click(object sender, EventArgs e)
        {
            FormPaids formp = new FormPaids();
            formp.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                DialogResult result = MessageBox.Show(
                "Ви впевнені що хочете закрити програму ?",
                "Увага!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            
        }
    }
}
