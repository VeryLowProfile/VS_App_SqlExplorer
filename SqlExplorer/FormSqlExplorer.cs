using System;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace SqlExplorer
{
    public partial class SqlExplorerForm : Form
    {

        #region Declarations

        string connString;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Constructor

        public SqlExplorerForm()
        {
            InitializeComponent();
            textBoxIP.Text = "192.168.10.33";
            textBoxServerName.Text = "SQLEXPRESS";
            textBoxDbName.Text = "Test";
            textBoxUserId.Text = "TestUser";
            textBoxUserPwd.Text = "12345";
        }

        #endregion

        #region Events

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            connString = buildConnString(textBoxIP.Text, textBoxServerName.Text, textBoxDbName.Text, textBoxUserId.Text, textBoxUserPwd.Text);
            connection.ConnectionString = connString;
            fillComboBoxTables(comboBoxSelectTable, connString);
        }

        private void buttonLoadRefresh_Click(object sender, EventArgs e)
        {
            fillTable(connection, dataGridView, comboBoxSelectTable.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearDataGrid(dataGridView);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            submitMod(connection, dataGridView, comboBoxSelectTable.Text);
        }

        private void buttonSelectExcelFile_Click(object sender, EventArgs e)
        {
            fillSheetComboBox(textBoxSelectedFile, comboBoxSheetName);
        }

        private void buttonLoadExcelTable_Click(object sender, EventArgs e)
        {
            fillTableExcel(textBoxSelectedFile, comboBoxSheetName, dataGridView);
        }

        private void buttonExportTableToExcel_Click(object sender, EventArgs e)
        {
            exportTabletoExcell(comboBoxSelectTable, dataGridView);
        }

        #endregion

        #region Moetods

        static string buildConnString(string IP, string serverName, string DbName, string userID, string userPwd)
        {
            StringBuilder connString = new StringBuilder();

            connString.Append("Server = ");
            connString.Append(IP);
            connString.Append(@"\");
            connString.Append(serverName);
            connString.Append("; Database = ");
            connString.Append(DbName);
            connString.Append("; UID = ");
            connString.Append(userID);
            connString.Append("; PWD = ");
            connString.Append(userPwd);

            return connString.ToString();
        }

        static void fillTable(SqlConnection connection, DataGridView dataGridView, string tableName)
        {

            try
            {

                //Create new select command.
                SqlCommand command = new SqlCommand("SELECT * FROM  " + tableName, connection);

                //Create data adapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                //Create DataTable
                DataTable dataTable = new DataTable();

                //Fill Data table 
                dataAdapter.Fill(dataTable);

                //Set Datasource For DataGridView
                dataGridView.DataSource = dataTable;

                //Show DatagridView With Updated Values
                dataGridView.Update();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void fillComboBoxTables(ComboBox comboBox, string connString)
        {

            //Build Qry
            string qry = @"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";

            //clear CombBox
            comboBox.Items.Clear();

            try
            {

                //sql connection object
                SqlConnection conn = new SqlConnection(connString);

                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(qry, conn);

                //Open Connection (ComboBox)
                conn.Open();

                //Execute Reader
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader["TABLE_NAME"].ToString()); //cbsb is the combobox name
                }

                //close connection
                reader.Close();

                //Set Default Text
                comboBox.Text = comboBox.Items[0].ToString();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        static void submitMod(SqlConnection connection, DataGridView dataGridView, string tableName)
        {
            //Ask Confirmation
            DialogResult dialogResult = MessageBox.Show("Do you really want to store on SQL table Modifications?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //Create new select command.
                SqlCommand command = new SqlCommand("SELECT * FROM  " + tableName, connection);

                //Create data adapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                //Create Command Builder
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                //Create DataTable
                DataTable dataTable = new DataTable();

                //Fill Data table 
                dataAdapter.Fill(dataTable);

                //Generate sql Command with command Builder
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetDeleteCommand();

                try
                {
                    //Update Data To sql 
                    dataAdapter.Update((DataTable)dataGridView.DataSource);
                }
                catch (Exception ex)
                {
                    //display error message
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        static void fillSheetComboBox(TextBox textBox, ComboBox comboBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Workbook|*.xls; *xlsx";
            openFileDialog.Title = "Select An Excel file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Clear ComboBox
                comboBox.Items.Clear();

                //Put File Name To Text Box
                textBox.Text = openFileDialog.FileName;

                try
                {

                    //Open New Xcel application
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Open(textBox.Text);

                    //Fill Combobox
                    foreach (Excel.Worksheet worksheet in excel.Worksheets)
                    {
                        comboBox.Items.Add(worksheet.Name);
                    }

                    //Set Default Text
                    comboBox.Text = comboBox.Items[0].ToString();

                    workbook.Close();
                    excel.Quit();

                    GC.WaitForPendingFinalizers();
                    GC.Collect();

                }
                catch (Exception ex)
                {
                    //display error message
                    MessageBox.Show("Exception: " + ex.Message);
                }

            }
            
        }

        static void fillTableExcel(TextBox textBox, ComboBox comboBox, DataGridView dataGridView)
        {
            try
            {
                //Open New Xcel application
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Open(textBox.Text);
                Excel.Worksheet worksheet = workbook.Sheets[comboBox.SelectedIndex + 1];
                Excel.Range range = worksheet.UsedRange;

                //Get Range
                int rowRange = range.Rows.Count;
                int colRange = range.Columns.Count;

                //New Data Table
                DataTable dataTable = new DataTable();
                dataTable = (DataTable)dataGridView.DataSource;

                //New Data Row
                DataRow row;

                //Delete Rows In Previous Datatable
                dataTable.Rows.Clear();

                //Fill Data Table With New Rows From Excel File
                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    row = dataTable.NewRow();
                    for (int j = 1; j <= range.Columns.Count; j++)
                    {
                        if (range.Cells[i , j] != null && range.Cells[i , j].Value2 != null)
                        {
                            row[j - 1] = range.Cells[i , j].Value2;

                        } else
                        {
                            row[j - 1] = " ";
                        }
                    }
                    dataTable.Rows.Add(row);
                }

                workbook.Close();
                excel.Quit();

                dataGridView.DataSource = dataTable;
                dataGridView.Update();

                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        static void exportTabletoExcell(ComboBox comboBox, DataGridView dataGridView)
        {
            //Prompt Savefiledialog
            SaveFileDialog saveFileDialog = new SaveFileDialog(); 
            saveFileDialog.Filter = "Excel Workbook|*xlsx";
            saveFileDialog.Title = "Create An Excel file";
            saveFileDialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            saveFileDialog.FileName = @"C:\Users\" + Environment.UserName + @"\Desktop\" + comboBox.Text;
            //saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Open Excel and create new sheet
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                    worksheet.Name = comboBox.Text;
                    excel.Visible = true;
                    excel.DisplayAlerts = false;

                    //Export Table To Sheet
                    //New DataTable
                    DataTable dataTable = new DataTable();
                    dataTable = (DataTable)dataGridView.DataSource;

                    //Set Coloumn Header
                    for (int i = 0; i <= dataTable.Columns.Count - 1; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName.ToString();
                    }

                    //Export Table
                    for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j <= dataTable.Columns.Count - 1; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                        }
                    }

                    workbook.SaveAs(saveFileDialog.FileName);

                    workbook.Close();
                    excel.Quit();

                    GC.WaitForPendingFinalizers();
                    GC.Collect();

                }
                catch (Exception ex)
                {
                    //display error message
                    MessageBox.Show("Exception: " + ex.Message);
                }


            }

        }

        static void clearDataGrid(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 1)
            {
                foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
                {
                    if (!dataGridViewRow.IsNewRow)
                    {
                        dataGridView.Rows.Remove(dataGridViewRow);
                        dataGridView.Update();
                    }
                }
            }
        }

        #endregion

    }
}
