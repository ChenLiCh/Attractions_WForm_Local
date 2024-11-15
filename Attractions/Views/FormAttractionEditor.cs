using Attractions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Attractions.Views {
    public partial class FormAttractionEditor : Form {
        private string pipe = "np:\\\\.\\pipe\\LOCALDB#7C99B448\\tsql\\query;";
        private CAttraction _attraction;
        
        // 圖片
        private int _imageIndex = 0;
        private CAttrationImage _attractionImage=new CAttrationImage();
        //private 

        public DialogResult isOk { get; set; }
        public CAttraction attraction {
            // 表格上資料填進這個物件
            get {
                if (_attraction == null) {
                    _attraction = new CAttraction();
                }
                //_attraction.fAttractionId = lbId.Text != null ? Convert.ToInt32(lbId.Text) : 0;
                _attraction.fAttractionName = fbAttractionName.fieldValue != null ? fbAttractionName.fieldValue : "";
                _attraction.fDescription = tbDescription.Text != null ? tbDescription.Text : "";
                _attraction.fAddress = fbAddress.fieldValue != null ? fbAddress.fieldValue : "";
                _attraction.fPhoneNumber = fbPhoneNumber.fieldValue != null ? fbPhoneNumber.fieldValue : "";
                _attraction.fOpeningTime = new TimeSpan(dtpOpeningTime.Value.TimeOfDay.Hours, dtpOpeningTime.Value.TimeOfDay.Minutes, 0);
                _attraction.fClosingTime = new TimeSpan(dtpClosingTime.Value.TimeOfDay.Hours, dtpClosingTime.Value.TimeOfDay.Minutes, 0);
                _attraction.fWebsiteURL = fbWebsiteURL.fieldValue != null ? fbWebsiteURL.fieldValue : "";
                _attraction.fLongitude = fbLongitude.fieldValue != null ? fbLongitude.fieldValue : "";
                _attraction.fLatitude = fbLatitude.fieldValue != null ? fbLatitude.fieldValue : "";
                _attraction.fRegion = fbRegion.fieldValue != null ? fbRegion.fieldValue : "";

                // 設定 _attraction.fCategoryId
                if (int.TryParse(cbCategoryName.SelectedValue.ToString(), out int value)) _attraction.fCategoryId = value;
                else cbCategoryName.SelectedValue = null;
                // 設定 _attraction.fCategoryName
                //_attraction.fCategoryName = cbCategoryName.Text != null ? cbCategoryName.Text : ""; // ComboBox

                if (DateTime.TryParse(lbfCreatedDate.Text, out DateTime createdDate)) _attraction.fCreatedDate = createdDate;
                else _attraction.fCreatedDate = DateTime.Now;

                _attraction.fUpdatedDate = DateTime.Now;

                _attraction.fTransformInformation = tbTransformInformation.Text != null ? tbTransformInformation.Text : "";
                _attraction.fStatus = cbStatus.Text != null ? cbStatus.Text : ""; // ComboBox

                return _attraction;
            }
            // 物件上資料填進這個表格
            set {
                _attraction = value;
                lbId.Text = _attraction.fAttractionId.ToString() != null ? _attraction.fAttractionId.ToString() : "0".ToString();
                fbAttractionName.fieldValue = _attraction.fAttractionName != null ? _attraction.fAttractionName : "";
                tbDescription.Text = _attraction.fDescription != null ? _attraction.fDescription : "";
                fbAddress.fieldValue = _attraction.fAddress != null ? _attraction.fAddress : "";
                fbPhoneNumber.fieldValue = _attraction.fPhoneNumber != null ? _attraction.fPhoneNumber : "";
                dtpOpeningTime.Value = _attraction.fOpeningTime != null ? DateTime.Today + _attraction.fOpeningTime : DateTime.Today + TimeSpan.Zero;
                dtpClosingTime.Value = _attraction.fClosingTime != null ? DateTime.Today + _attraction.fClosingTime : DateTime.Today + TimeSpan.Zero;

                fbWebsiteURL.fieldValue = _attraction.fWebsiteURL != null ? _attraction.fWebsiteURL : "";
                fbLongitude.fieldValue = _attraction.fLongitude != null ? _attraction.fLongitude : "";
                fbLatitude.fieldValue = _attraction.fLatitude != null ? _attraction.fLatitude : "";
                fbRegion.fieldValue = _attraction.fRegion != null ? _attraction.fRegion : "";
                lbfCreatedDate.Text = _attraction.fCreatedDate.ToString() != null ? _attraction.fCreatedDate.ToString() : "";
                lbUpdatedDate.Text = _attraction.fUpdatedDate.ToString() != null ? _attraction.fUpdatedDate.ToString() : "";
                tbTransformInformation.Text = _attraction.fTransformInformation != null ? _attraction.fTransformInformation : "";
                cbStatus.Text = _attraction.fStatus != null ? _attraction.fStatus : ""; // ComboBox fStatus
            }
        }

        public CAttrationImage attractionImage {
            get {
                return _attractionImage;
            }
            set {
                _attractionImage = value;
                if (_attractionImage.fImage != null) {
                    try {
                        Stream streamImage = new MemoryStream(_attractionImage.fImage[0]);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }
            }
        }

        public FormAttractionEditor() {
            InitializeComponent();
        }

        // 點擊 Edit 按鈕
        private void btnEdit_Click(object sender, EventArgs e) {

            if (isCorrectInput()) {
                this.isOk = DialogResult.OK;
                Close();
            }
        }

        private bool isCorrectInput() {
            string errorMessage = "";

            if (string.IsNullOrEmpty(fbAttractionName.fieldValue)) {
                errorMessage += "景點名稱不可為空\n";
            }

            // 台灣電話號碼模式
            // 比對以 02、03、037、039、04、049、05、06、07、08 或 089 開頭的 NN-NNNN-NNNN 或 NNN-NNNN-NNNN 格式的 10-11 位數字。
            string phoneNumberPattern1 = @"(?i:\b(?:\(?(?:02|03|037|039|04|049|05|06|07|08|089)\)?-?)?\d{4}-?\d{4}\b)";

            // 比對以 +886 開頭的 +886NNNNNNNNN 格式的 12 位行動電話號碼。
            string phoneNumberPattern2 = @"(?i:^(\+886)\d{9}$)";

            // 09XX-XXX-XXX or 09XXXXXXXX
            string phoneNumberPattern3 = @"^09\d{2}-\d{3}-\d{3}$|^09\d{8}$";
            if (!Regex.IsMatch(fbPhoneNumber.fieldValue, phoneNumberPattern1) && !Regex.IsMatch(fbPhoneNumber.fieldValue, phoneNumberPattern2) && !Regex.IsMatch(fbPhoneNumber.fieldValue, phoneNumberPattern3)) {
                errorMessage += "電話號碼須符合格式\n";
            }

            //string timePattern = @"^(?:[01]\d|2[0-3]):[0-5]\d$";
            //if (!Regex.IsMatch(fbOpeningTime.fieldValue, timePattern)) {
            //    errorMessage += "開放時間須符合格式 00:00~23:59\n";
            //}

            //if (!Regex.IsMatch(fbClosingTime.fieldValue, timePattern)) {
            //    errorMessage += "關閉時間須符合格式 00:00~23:59\n";
            //}

            bool isValidUrl = Uri.TryCreate(fbWebsiteURL.fieldValue, UriKind.Absolute, out Uri uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps); ;
            if (!isValidUrl) errorMessage += "網址無效\n";

            bool isValidLongitude = double.TryParse(fbLongitude.fieldValue, out double longitude) && longitude >= -180 && longitude <= 180;
            if (!isValidLongitude) errorMessage += "經度輸入錯誤\n";

            bool isValidLatitude = double.TryParse(fbLatitude.fieldValue, out double latitude) && latitude >= -90 && latitude <= 90;
            if (!isValidLatitude) errorMessage += "緯度輸入錯誤\n";

            if (errorMessage == "") return true;
            else {
                MessageBox.Show(errorMessage);
                return false;
            }
        }

        // 按下"取消"按鈕
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void FormAttractionEditor_Load(object sender, EventArgs e) {
            getfAttractionCategory();
            if (_attraction == null) {
                _attraction = new CAttraction();
            }
            if (_attraction.fAttractionId != 0) {
                getfAttractionCategory(_attraction.fCategoryId);
            }
        }

        // 取得最初的 Category ComboBox
        private void getfAttractionCategory() {
            string sql = "";
            sql += "SELECT ";
            sql += "fAttractionCategoryId,";
            sql += "fAttractionCategoryName ";
            sql += "FROM tAttractionCategories;";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + pipe + "Initial Catalog=TravelJournal;Integrated Security=True;"; ;
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            SqlCommandBuilder builder = new SqlCommandBuilder();
            builder.DataAdapter = da;

            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("fAttractionCategoryId", typeof(int));
            dataTable.Columns.Add("fAttractionCategoryName", typeof(string));

            cbCategoryName.DataSource = ds.Tables[0]; // 指定 DataTable
            cbCategoryName.DisplayMember = "fAttractionCategoryName"; // 用於顯示的欄位
            cbCategoryName.ValueMember = "fAttractionCategoryId";
        }

        // 根據 id 取得 Category
        private void getfAttractionCategory(int id) {
            string sql = "";
            sql += "SELECT ";
            sql += "fAttractionCategoryName ";
            sql += "FROM tAttractionCategories ";
            sql += "WHERE fAttractionCategoryId = @Id;";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=" + pipe + "Initial Catalog=TravelJournal;Integrated Security=True;"; ;
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.Add(new SqlParameter("Id", (object)id));

            SqlCommandBuilder builder = new SqlCommandBuilder();
            builder.DataAdapter = da;

            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Close();

            cbCategoryName.Text = ds.Tables[0].Rows[0]["fAttractionCategoryName"].ToString();
        }

        // 前一張圖片
        private void btnPreviousImage_Click(object sender, EventArgs e) {
            this._imageIndex--;
            if(this._imageIndex<0)this._imageIndex = 0;
            showSavedImage(this._attraction.fAttractionId, this._imageIndex);
        }

        // 下一張圖片
        private void btnNextImage_Click(object sender, EventArgs e) {
            this._imageIndex++;
            if (this._imageIndex >= this._attractionImage.fImage.Count) this._imageIndex -= 1;
            showSavedImage(this._attraction.fAttractionId, this._imageIndex); 
        }

        // 雙擊加入圖片
        private void pictureBox1_DoubleClick(object sender, EventArgs e) {
            // 只有 *.png 或 *.jpg 的檔案可以被使用者看到並選取
            openFileDialog1.Filter = "景點照片(*.png)|*.png|景點照片(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            // 串流
            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            if (this._attractionImage.fImage == null) this._attractionImage.fImage = new List<byte[]>();
            this._attractionImage.fImage.Add(reader.ReadBytes((int)imgStream.Length));
            reader.Close();
            imgStream.Close();
        }

        public void showSavedImage(int id, int index) {
            if(this._attractionImage.fImage!=null) this._attractionImage.fImage.Clear();
            // 連線
            string connectionString = @"Data Source=" + pipe + "Initial Catalog=TravelJournal;Integrated Security=True;";

            // SQL 查詢語句
            string query = "SELECT fImage FROM tAttractionImages WHERE fAttractionId = @id";

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader()) {
                        // List<byte[]> imageData = new List<byte[]>();
                        while (reader.Read()) {
                            // 取得圖片資料 
                            if(this._attractionImage.fImage==null)
                                this._attractionImage.fImage = new List<byte[]>();
                            this._attractionImage.fImage.Add(reader["fImage"] as byte[]);
                        }
                        if (this._attractionImage.fImage.Count > 0) {
                            // 將二進制資料轉換成圖片
                            using (MemoryStream ms = new MemoryStream(this._attractionImage.fImage[index])) {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }
    }
}
