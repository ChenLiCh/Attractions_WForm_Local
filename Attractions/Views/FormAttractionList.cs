using Attractions.Models;
using Attractions.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Attractions {
    public partial class FormAttractionList : Form {
        private int _lastfAttractionId = 0;

        public string pipe = "np:\\\\.\\pipe\\LOCALDB#7C99B448\\tsql\\query;";
        public SqlDataAdapter _da;
        public SqlCommandBuilder _builder;
        public int _position = -1;
        DataSet _ds = null;

        public FormAttractionList() {
            InitializeComponent();
        }

        private void FormAttractionList_Load(object sender, EventArgs e) {
            string sql = "";
            sql += "SELECT ";
            sql += "fAttractionId,";
            sql += "fAttractionName,";
            sql += "fDescription,";
            sql += "fAddress,";
            sql += "fPhoneNumber,";
            sql += "fOpeningTime,";
            sql += "fClosingTime,";
            sql += "fWebsiteURL,";
            sql += "fLongitude,";
            sql += "fLatitude,";
            sql += "fRegion,";
            sql += "fCategoryId,";
            sql += "fCreatedDate,";
            sql += "fUpdatedDate,";
            sql += "fStatus,";
            sql += "fTransformInformation ";
            sql += "FROM tAttractions;";
            displayAttractionsBySql(sql, false);
        }

        // 顯示所有欄位
        private void displayAttractionsBySql(string sql, bool isKeyword) {

            // 連線
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + pipe + "Initial Catalog=TravelJournal;Integrated Security=True;"; ;
            con.Open();

            _da = new SqlDataAdapter(sql, con);

            // sql injection
            if (isKeyword) {
                //_da.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + (object)toolStripTextBox1.Text + "%"));
            }

            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;

            _ds = new DataSet();
            _da.Fill(_ds);

            con.Close();

            dataGridView1.DataSource = _ds.Tables[0];
        }

        // 按下"新增景點"按鈕
        private void tsbInsert_Click(object sender, EventArgs e) {
            FormAttractionEditor f = new FormAttractionEditor();
            _lastfAttractionId = getLastfAttractionId();

            f.ShowDialog();
            if (f.isOk == DialogResult.OK) {
                DataTable dt = dataGridView1.DataSource as DataTable;

                DataRow row = dt.NewRow();
                // attraction 的 get{}
                // row["fAttractionId"] = f.attraction.fAttractionId;
                row["fAttractionName"] = f.attraction.fAttractionName;
                row["fDescription"] = f.attraction.fDescription;
                row["fAddress"] = f.attraction.fAddress;
                row["fPhoneNumber"] = f.attraction.fPhoneNumber;
                row["fOpeningTime"] = f.attraction.fOpeningTime;
                row["fClosingTime"] = f.attraction.fClosingTime;
                row["fWebsiteURL"] = f.attraction.fWebsiteURL;
                row["fLongitude"] = f.attraction.fLongitude;
                row["fLatitude"] = f.attraction.fLatitude;
                row["fRegion"] = f.attraction.fRegion;
                row["fCategoryId"] = f.attraction.fCategoryId;
                row["fCreatedDate"] = f.attraction.fCreatedDate;
                row["fUpdatedDate"] = f.attraction.fUpdatedDate;
                row["fStatus"] = f.attraction.fStatus;
                row["fTransformInformation"] = f.attraction.fTransformInformation;

                dt.Rows.Add(row);

                // 把 CAttrationImage 的圖片資料放到新的 Datable
                saveImageFromCAttrationImageToDataTable(f);
            }
        }

        // 把 CAttrationImage 的照片存到 DataTable
        private void saveImageFromCAttrationImageToDataTable(FormAttractionEditor f) {
            _da.Update(dataGridView1.DataSource as DataTable);
            // 新建一個 image 的 table
            DataTable imagetable = new DataTable();

            // 定義 imagetable 的資料欄位
            imagetable.Columns.Add("fAttractionId", typeof(int));
            imagetable.Columns.Add("fImage", typeof(byte[]));

            DataRow row = imagetable.NewRow();
            if(f.attraction.fAttractionId>0)
                row["fAttractionId"] = f.attraction.fAttractionId;
            else row["fAttractionId"] = _lastfAttractionId + 1;
            row["fImage"] = f.attractionImage.fImage[f.attractionImage.fImage.Count - 1];

            imagetable.Rows.Add(row);

            // 連線
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + pipe + "Initial Catalog=TravelJournal;Integrated Security=True;"; ;
            con.Open();

            string sql = "SELECT fAttractionId, fImage FROM tAttractionImages;";
            SqlDataAdapter imageDataAdapter = new SqlDataAdapter(sql, con);

            imageDataAdapter.InsertCommand = new SqlCommand(
                "INSERT INTO tAttractionImages (fAttractionId, fImage) VALUES (@fAttractionId, @fImage)",
                con
                );

            // 定義參數
            imageDataAdapter.InsertCommand.Parameters.Add("@fAttractionId", SqlDbType.Int, 0, "fAttractionId");
            imageDataAdapter.InsertCommand.Parameters.Add("@fImage", SqlDbType.VarBinary, -1, "fImage");

            // 將 DataTable 的變更應用到資料庫
            imageDataAdapter.Update(imagetable);

            con.Close();
        }

        // 從 dataGridView1 取得最後一個 AttractionId
        private int getLastfAttractionId() {
            // dataGridView1 沒資料直接回傳
            if (dataGridView1.Rows.Count <= 0) return 0;

            int lastIndex = dataGridView1.Rows.Count - 1;
            // 檢查最後一列是否是新的輸入列（如果允許新增列）
            if (dataGridView1.Rows[lastIndex].IsNewRow) lastIndex--;

            DataGridViewRow lastRow = dataGridView1.Rows[lastIndex];
            try {
                return (int)lastRow.Cells[0].Value;
            }
            catch (Exception e) { return 0; }
        }

        // 按下"刪除景點"按鈕
        private void tsbDelete_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) {
                dataGridView1.Rows.Remove(row);
            }
            //if (_position < 0) return;
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //DataRow row = dt.Rows[_position];
            //row.Delete();

            _da.Update(dataGridView1.DataSource as DataTable);
        }

        // 按下"修改景點"按鈕
        private void tsbEdit_Click(object sender, EventArgs e) {
            showEditView();
        }

        // 表單關閉後，把資料存進 Database
        private void FormAttractionList_FormClosed(object sender, FormClosedEventArgs e) {
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        // 按下"重新整理"按鈕
        private void tsbReload_Click(object sender, EventArgs e) {
            _da.Update(dataGridView1.DataSource as DataTable);
            //_da.Update(imagetable)
            string sql = "";
            sql += "SELECT ";
            sql += "fAttractionId,";
            sql += "fAttractionName,";
            sql += "fDescription,";
            sql += "fAddress,";
            sql += "fPhoneNumber,";
            sql += "fOpeningTime,";
            sql += "fClosingTime,";
            sql += "fWebsiteURL,";
            sql += "fLongitude,";
            sql += "fLatitude,";
            sql += "fRegion,";
            sql += "fCategoryId,";
            sql += "fCreatedDate,";
            sql += "fUpdatedDate,";
            sql += "fStatus,";
            sql += "fTransformInformation ";
            sql += "FROM tAttractions;";
            displayAttractionsBySql(sql, false);
        }

        // 點擊 GridView，取得滑鼠點到的 row 位置
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _position = e.RowIndex; // 在 GridView 中點到的位置
        }

        private void tsbSearch_Click(object sender, EventArgs e) {
            string sql = "SELECT * FROM tAttractions WHERE fAttractionName = ";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            showEditView();
        }

        private void showEditView() {
            if (_position < 0) return;
            
            // 選取指定的 row
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            
            FormAttractionEditor f = new FormAttractionEditor();
            CAttraction x = new CAttraction();

            // FormAttractionList 的 DataGridView 的資料傳到 CAttraction 物件 x 上
            try {
                x.fAttractionId = (int)row["fAttractionId"];
            }
            catch {
                x.fAttractionId = 0;
            }
            x.fAttractionName = (string)row["fAttractionName"];
            x.fDescription = (string)row["fDescription"];
            x.fPhoneNumber = (string)row["fPhoneNumber"];
            x.fOpeningTime = (TimeSpan)row["fOpeningTime"];
            x.fClosingTime = (TimeSpan)row["fClosingTime"];
            x.fWebsiteURL = (string)row["fWebsiteURL"];
            x.fLongitude = (string)row["fLongitude"];
            x.fLatitude = (string)row["fLatitude"];
            x.fRegion = (string)row["fRegion"];
            x.fCategoryId = (int)row["fCategoryId"];
            x.fCreatedDate = (DateTime)row["fCreatedDate"];
            x.fUpdatedDate = (DateTime)row["fUpdatedDate"];
            x.fStatus = (string)row["fStatus"];
            x.fTransformInformation = (string)row["fTransformInformation"];

            // 把剛剛傳到 CAttraction 物件 x 上的資料，再傳到 FormAttractionEditor
            f.attraction = x;
            f.showSavedImage((int)row["fAttractionId"], 0);
            f.ShowDialog();
            
            if (f.isOk == DialogResult.OK) {
                row["fAttractionName"] = f.attraction.fAttractionName;
                row["fDescription"] = f.attraction.fDescription;
                row["fAddress"] = f.attraction.fAddress;
                row["fPhoneNumber"] = f.attraction.fPhoneNumber;
                row["fOpeningTime"] = f.attraction.fOpeningTime;
                row["fClosingTime"] = f.attraction.fClosingTime;
                row["fWebsiteURL"] = f.attraction.fWebsiteURL;
                row["fLongitude"] = f.attraction.fLongitude;
                row["fLatitude"] = f.attraction.fLatitude;
                row["fRegion"] = f.attraction.fRegion;
                row["fCategoryId"] = f.attraction.fCategoryId;
                row["fCreatedDate"] = f.attraction.fCreatedDate;
                row["fUpdatedDate"] = f.attraction.fUpdatedDate;
                row["fStatus"] = f.attraction.fStatus;
                row["fTransformInformation"] = f.attraction.fTransformInformation;
                saveImageFromCAttrationImageToDataTable(f);
            }  
        } 
    }
}
