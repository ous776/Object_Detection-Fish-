using GamRent.Model;
using GamRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.FieldOptions.Types;
using System.Xml.Linq;

namespace GamRent
{
    public partial class Rentals : Form
    {
        private readonly IDataService<Rental> dataService;
        private readonly IDataService<Asset> assetService;
        private readonly CrudContextFactory crudContextFactory = new CrudContextFactory();
        public Rentals()
        {
            InitializeComponent();
            dataService = new DataService<Rental>(crudContextFactory);
            assetService = new DataService<Asset>(crudContextFactory);
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxcolumn;
        int inc = 0;
        int maxrow;
        private void select_navigation(string sql)
        {
            config.singleResult(sql);
            maxrow = config.dt.Rows.Count;
        }
        public void navigate_records(int inc)
        {
            config.singleResult("SELECT * FROM `Rentals`");
            rentaltype.Text = config.dt.Rows[inc].Field<string>("Name");
            rentaltype.Text = config.dt.Rows[inc].Field<string>("Type");
            txtdescription.Text = config.dt.Rows[inc].Field<string>("Description");
            asset_comboBox.Text = config.dt.Rows[inc].Field<string>("AssetNo");
            //txtqty.Text = config.dt.Rows[inc].Field<string>("RentNo");
            txt_deposit.Text = config.dt.Rows[inc].Field<int>("AdvanceDeposit").ToString();
            startDatedateTimePicker.Text = config.dt.Rows[inc].Field<DateTime>("ContractStartDate").ToShortDateString();
            endDate_dateTimePicker.Text = config.dt.Rows[inc].Field<DateTime>("ContractEndDate").ToShortDateString();
            renewal_dateTimePicker.Text = config.dt.Rows[inc].Field<DateTime>("LastContractRenewDate").ToShortDateString();
            //LastPaymentAmount
            txt_amuntPaid.Text = config.dt.Rows[inc].Field<double>("LastPaymentAmount").ToString();
            txt_pendingAmount.Text = config.dt.Rows[inc].Field<double>("PendingBalance").ToString();

            txt_deposit.Text = config.dt.Rows[inc].Field<double>("AdvanceDeposit").ToString();


        }
        private void btnnew_Click(object sender, EventArgs e)
        {

            inc = 0;
            var data = dataService.GetAll().Result.ToList();
            txt_deposit.Text = data.Count.ToString();
            dtglist.DataSource = data;
            funct.ResponsiveDtg(dtglist);
            dtglist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtglist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            maxcolumn = dtglist.Columns.Count - 1;
            dtglist.Columns[0].Visible = false;
            dtglist.Columns[maxcolumn].Visible = false;
            dtglist.Columns["AssetId"].Visible = false;
            dtglist.Columns["Description"].Visible = false;
            dtglist.Columns["Name"].Visible = false;
            dtglist.Columns["AssetNo"].Visible = false;
            dtglist.Columns["Type"].Visible = false;
            btnadd.Visible = false;

            select_navigation("SELECT AssetNo FROM assets");
            lblmax.Text = maxrow.ToString();
            lblinc.Text = inc.ToString();

            sql = "SELECT Name FROM `Assets`";
            config.fiil_CBO(sql, asset_comboBox);

            sql = "SELECT Name FROM `RentalCategories`";
            config.fiil_CBO(sql, rentaltype);
            funct.clearTxt(pnl_stockmaster);
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + cbotype.Text + "'";
            //config.autonumber(sql, txtitemid);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + cbotype.Text + "'";
            // config.autonumber(sql, txtitemid);
            //txt_deposit.Text = (dataService.GetAll().Result.ToList().Count + 1).ToString();
            foreach (Control obj in pnl_stockmaster.Controls)
            {

                if (obj is TextBox)
                {
                    if (obj.Text == "")
                    {
                        MessageBox.Show("Action connot be perform. All fields are required to be fill up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            var asset = assetService.SearchForAnEntity(e => e.Name == asset_comboBox.Text).Result;
            double cnt = Convert.ToDouble(txt_pendingAmount.Text) +
                Convert.ToDouble(txt_amuntPaid.Text);
            Random random = new Random();
            string rtNo = random.Next(0, 1000).ToString();
            Rental rental = new Rental()
            {
                AssetId = (asset != null) ? asset.Id : Guid.Empty,
                RentNo = rtNo,
                AssetNo = (asset != null) ? asset.AssetNo : asset_comboBox.Text,
                AdvanceDeposit = Convert.ToDouble(txt_deposit.Text),
                LastPaymentAmount = Convert.ToDouble(txt_amuntPaid.Text),
                LastContractRenewDate = Convert.ToDateTime(renewal_dateTimePicker.Text),
                LastPaymentDate = Convert.ToDateTime(lastPayment_dateTimePicker.Text),
                ContractEndDate = Convert.ToDateTime(endDate_dateTimePicker.Text),
                ContractStartDate = Convert.ToDateTime(startDatedateTimePicker.Text),
                Description = txtdescription.Text,
                Type = rentaltype.Text,
                PendingBalance = Convert.ToDouble(txt_pendingAmount.Text),
                NextPaymentDate = Convert.ToDateTime(endDate_dateTimePicker.Text),
                Name = rentaltype.Text,
                IsOccupaid = false,
                Cost = cnt
            };
            rental = dataService.Create(rental).Result;

            btnnew_Click(sender, e);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            double cnt = Convert.ToDouble(txt_pendingAmount.Text) +
                Convert.ToDouble(txt_amuntPaid.Text);
            var asset = assetService.SearchForAnEntity(e => e.AssetNo == txt_deposit.Text).Result;
            var rent = dataService.SearchForAnEntity(e => e.Id == Guid.Parse(dtglist.CurrentRow.Cells[0].Value.ToString())).Result;
            rent.AssetId = (asset != null) ? asset.Id : Guid.Empty;
            rent.RentNo = rentaltype.Text;
            rent.AssetNo = (asset != null) ? asset.AssetNo : asset_comboBox.Text;
            rent.AdvanceDeposit = Convert.ToDouble(txt_deposit.Text);
            rent.LastPaymentAmount = Convert.ToDouble(txt_amuntPaid.Text);
            rent.LastContractRenewDate = Convert.ToDateTime(renewal_dateTimePicker.Text);
            rent.LastPaymentDate = Convert.ToDateTime(lastPayment_dateTimePicker.Text);
            rent.ContractEndDate = Convert.ToDateTime(endDate_dateTimePicker.Text);
            rent.ContractStartDate = Convert.ToDateTime(startDatedateTimePicker.Text);
            rent.Description = txtdescription.Text;
            rent.Type = rentaltype.Text;
            rent.PendingBalance = Convert.ToDouble(txt_pendingAmount.Text);
            rent.NextPaymentDate = Convert.ToDateTime(endDate_dateTimePicker.Text);
            rent.Name = rentaltype.Text;
            rent.IsOccupaid = false;
            rent.Cost = cnt;

            rent = dataService.Update(rent).Result;
            //sql = "UPDATE assets SET `NAME`='" + txtname.Text + "', `DESCRIPTION`='" + txtdescription.Text + "', `TYPE`='" + cbotype.Text + "', `PRICE`='" + txtprice.Text + "'" +
            //",`UNIT`='" + cbounit.Text + "' WHERE ITEMID='" + txtitemid.Text + "'";
            //config.Execute_CUD(sql, "Error to update:" + sql.ToString(), "Data has been updated in the database");
            btnnew_Click(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            //sql = "DELETE FROM assets WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value + "'";
            try
            {

                var asset = dataService.SearchForAnEntity(e => e.Id == Guid.Parse(dtglist.CurrentRow.Cells[0].Value.ToString())).Result;

                if (asset != null)
                {
                    var flg = dataService.Delete(asset).Result;
                    if (flg) MessageBox.Show("Data has been deleted");
                    else MessageBox.Show("Failed to delete.Data has NOT been deleted");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to delete. Data has NOT been deleted");
            }
            //config.Execute_CUD(sql, "error to delete", "Data has been deleted.");
            btnnew_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtitemid_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtglist_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(dtglist.CurrentRow.Cells[0].Value.ToString());
            var rent = dataService.SearchForAnEntity(e => e.Id == id).Result;
            if (rent != null)
            {
                var asset = assetService.SearchForAnEntity(e => e.Id == rent.AssetId).Result;
                rent.AssetId = (asset != null) ? asset.Id : Guid.Empty;
                rentaltype.Text = rent.RentNo;
                asset_comboBox.Text = asset.Name;
                txt_deposit.Text = rent.AdvanceDeposit.ToString();
                txt_amuntPaid.Text = rent.LastPaymentAmount.ToString();
                renewal_dateTimePicker.Text = rent.LastContractRenewDate.ToShortDateString();
                lastPayment_dateTimePicker.Text = rent.LastPaymentDate.ToShortDateString();
                endDate_dateTimePicker.Text = rent.ContractEndDate.ToShortDateString();
                startDatedateTimePicker.Text = rent.ContractStartDate.ToShortDateString();
                txtdescription.Text = rent.Description;
                rentaltype.Text = rent.Type;
                txt_pendingAmount.Text = rent.PendingBalance.ToString();
                endDate_dateTimePicker.Text = rent.NextPaymentDate.ToShortDateString();
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            inc = 1;
            lblinc.Text = inc.ToString();
            inc = 0;
            navigate_records(inc);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            select_navigation("SELECT AssetNo FROM rentals");
            if (inc != maxrow)
            {
                inc = maxrow;
                lblinc.Text = inc.ToString();
                inc = maxrow - 1;
                navigate_records(inc);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            int lbl_inc = 0;

            if (inc > 0)
            {
                inc = inc - 1;
                navigate_records(inc);


                lbl_inc = int.Parse(lblinc.Text) - 1;

                lblinc.Text = lbl_inc.ToString();
            }
            else if (inc == 0)
            {
                navigate_records(inc);
                lbl_inc = 1;
                lblinc.Text = lbl_inc.ToString();
                MessageBox.Show("First Records", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int lbl_inc;

            select_navigation("SELECT AssetNo FROM rentals");
            if (inc == maxrow - 1)
            {
                MessageBox.Show("no more rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (inc != maxrow - 1)
                {
                    inc = inc + 1;
                    navigate_records(inc);
                }

                lbl_inc = int.Parse(lblinc.Text) + 1;
                lblinc.Text = lbl_inc.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM rentals WHERE AssetNo LIKE '%" + txtsearch.Text + "%' OR NAME LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtglist);


            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void renewal_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
