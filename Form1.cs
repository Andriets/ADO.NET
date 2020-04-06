using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_1
{
    public partial class MainForm : Form
    {
        private DBRequest UserReq;
        private DataTable RequestTab;
        private DataTable StructTab;    
        private string LastTabName;
        public MainForm()
        {
            InitializeComponent();
            tbDatSource.Text = "SQLEXPRESS01";
            tbDatSource.ForeColor = Color.Green;
            tbInitCat.Text = "SQL4";
            tbInitCat.ForeColor = Color.Green;

            tbRequest.ForeColor = Color.Green;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserReq = new DBRequest();
            StructTab = new DataTable("TabFields");
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            datGridDBTables.DataSource = StructTab;

            datGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;

            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);
        }

        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
                datGridDBTables.Columns[1].Width = 1100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                datGridSQLResult.DataSource = UserReq.SQLRequest(tbRequest.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}
