using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attractions.Views {
    public partial class fieldBox : UserControl {
        public fieldBox() {
            InitializeComponent();
        }

        // 新增 fieldName 屬性
        public string fieldName {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        // 新增 fieldValue 屬性
        public string fieldValue {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
