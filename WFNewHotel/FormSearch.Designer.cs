namespace WFNewHotel
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBSurN = new System.Windows.Forms.TextBox();
            this.tBMidN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dGVSearch = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CChack = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CBegin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CAnd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CPay = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contactphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonfind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ім\'я";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(163, 54);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(202, 26);
            this.tBName.TabIndex = 3;
            // 
            // tBSurN
            // 
            this.tBSurN.Location = new System.Drawing.Point(163, 86);
            this.tBSurN.Name = "tBSurN";
            this.tBSurN.Size = new System.Drawing.Size(202, 26);
            this.tBSurN.TabIndex = 4;
            // 
            // tBMidN
            // 
            this.tBMidN.Location = new System.Drawing.Point(163, 118);
            this.tBMidN.Name = "tBMidN";
            this.tBMidN.Size = new System.Drawing.Size(202, 26);
            this.tBMidN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Прізвище";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "По-батькові";
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(163, 150);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(202, 26);
            this.tBPass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер паспорту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Знайдені замовлення:";
            // 
            // dGVSearch
            // 
            this.dGVSearch.AllowUserToAddRows = false;
            this.dGVSearch.AllowUserToDeleteRows = false;
            this.dGVSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSearch.AutoGenerateColumns = false;
            this.dGVSearch.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midnameDataGridViewTextBoxColumn,
            this.CNumber,
            this.CChack,
            this.CBegin,
            this.CAnd,
            this.CPay,
            this.contactphoneDataGridViewTextBoxColumn,
            this.additionalphoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.client1DataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn});
            this.dGVSearch.DataSource = this.clientBindingSource;
            this.dGVSearch.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dGVSearch.Location = new System.Drawing.Point(385, 32);
            this.dGVSearch.Name = "dGVSearch";
            this.dGVSearch.ReadOnly = true;
            this.dGVSearch.RowTemplate.Height = 28;
            this.dGVSearch.Size = new System.Drawing.Size(414, 418);
            this.dGVSearch.TabIndex = 13;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midnameDataGridViewTextBoxColumn
            // 
            this.midnameDataGridViewTextBoxColumn.DataPropertyName = "midname";
            this.midnameDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            this.midnameDataGridViewTextBoxColumn.Name = "midnameDataGridViewTextBoxColumn";
            this.midnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CNumber
            // 
            this.CNumber.DataPropertyName = "Id_Client";
            this.CNumber.DataSource = this.orderBindingSource;
            this.CNumber.DisplayMember = "id_order";
            this.CNumber.HeaderText = "Номер замовлення";
            this.CNumber.Name = "CNumber";
            this.CNumber.ReadOnly = true;
            this.CNumber.ValueMember = "id_client";
            this.CNumber.Visible = false;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(NewHotelDataEF.Order);
            // 
            // CChack
            // 
            this.CChack.DataPropertyName = "Id_Client";
            this.CChack.DataSource = this.orderBindingSource;
            this.CChack.DisplayMember = "order_date";
            this.CChack.HeaderText = "Дата замовлення";
            this.CChack.Name = "CChack";
            this.CChack.ReadOnly = true;
            this.CChack.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CChack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CChack.ValueMember = "id_client";
            this.CChack.Visible = false;
            // 
            // CBegin
            // 
            this.CBegin.DataPropertyName = "Id_Client";
            this.CBegin.DataSource = this.orderBindingSource;
            this.CBegin.DisplayMember = "checkin_date";
            this.CBegin.HeaderText = "Дата заїзду";
            this.CBegin.Name = "CBegin";
            this.CBegin.ReadOnly = true;
            this.CBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CBegin.ValueMember = "id_client";
            this.CBegin.Visible = false;
            // 
            // CAnd
            // 
            this.CAnd.DataPropertyName = "Id_Client";
            this.CAnd.DataSource = this.orderBindingSource;
            this.CAnd.DisplayMember = "checkout_date";
            this.CAnd.HeaderText = "Дата виїзду";
            this.CAnd.Name = "CAnd";
            this.CAnd.ReadOnly = true;
            this.CAnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAnd.ValueMember = "id_client";
            this.CAnd.Visible = false;
            // 
            // CPay
            // 
            this.CPay.DataPropertyName = "Id_Client";
            this.CPay.DataSource = this.orderBindingSource;
            this.CPay.DisplayMember = "amount";
            this.CPay.HeaderText = "Рахунок";
            this.CPay.Name = "CPay";
            this.CPay.ReadOnly = true;
            this.CPay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CPay.ValueMember = "id_client";
            this.CPay.Visible = false;
            // 
            // contactphoneDataGridViewTextBoxColumn
            // 
            this.contactphoneDataGridViewTextBoxColumn.DataPropertyName = "contact_phone";
            this.contactphoneDataGridViewTextBoxColumn.HeaderText = "Контактний телефон";
            this.contactphoneDataGridViewTextBoxColumn.Name = "contactphoneDataGridViewTextBoxColumn";
            this.contactphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionalphoneDataGridViewTextBoxColumn
            // 
            this.additionalphoneDataGridViewTextBoxColumn.DataPropertyName = "additional_phone";
            this.additionalphoneDataGridViewTextBoxColumn.HeaderText = "Додатковий телефон";
            this.additionalphoneDataGridViewTextBoxColumn.Name = "additionalphoneDataGridViewTextBoxColumn";
            this.additionalphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Електронна пошта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Номер паспорту";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // client1DataGridViewTextBoxColumn
            // 
            this.client1DataGridViewTextBoxColumn.DataPropertyName = "client1";
            this.client1DataGridViewTextBoxColumn.HeaderText = "client1";
            this.client1DataGridViewTextBoxColumn.Name = "client1DataGridViewTextBoxColumn";
            this.client1DataGridViewTextBoxColumn.ReadOnly = true;
            this.client1DataGridViewTextBoxColumn.Visible = false;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordersDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(NewHotelDataEF.Client);
            // 
            // buttonfind
            // 
            this.buttonfind.ForeColor = System.Drawing.Color.Navy;
            this.buttonfind.Location = new System.Drawing.Point(17, 212);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(348, 30);
            this.buttonfind.TabIndex = 14;
            this.buttonfind.Text = "Пошук";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Почніть вводити та натисніть \"Пошук\":";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(NewHotelDataEF.Room);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(NewHotelDataEF.Employee);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonfind);
            this.Controls.Add(this.dGVSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBMidN);
            this.Controls.Add(this.tBSurN);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormSearch";
            this.Text = "Пошук клієнта";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBSurN;
        private System.Windows.Forms.TextBox tBMidN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dGVSearch;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn CChack;
        private System.Windows.Forms.DataGridViewComboBoxColumn CBegin;
        private System.Windows.Forms.DataGridViewComboBoxColumn CAnd;
        private System.Windows.Forms.DataGridViewComboBoxColumn CPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn client1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}