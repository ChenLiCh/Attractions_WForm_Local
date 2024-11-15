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
    public partial class FormAttractionMain : Form {
        public FormAttractionMain() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FormAttractionList f = new FormAttractionList();
            f.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e) {
            FormCategoryList f = new FormCategoryList();
            f.ShowDialog();
        }

        private void btnTag_Click(object sender, EventArgs e) {
            FormTagList f = new FormTagList();
            f.ShowDialog();
        }

        private void btnRecommendation_Click(object sender, EventArgs e) {
            FormRecommendationList f = new FormRecommendationList();
            f.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e) {
            FormImageList f = new FormImageList();
            f.ShowDialog();
        }

        private void btnComment_Click(object sender, EventArgs e) {
            FormCommentList f = new FormCommentList();
            f.ShowDialog();
        }

        private void btnTicket_Click(object sender, EventArgs e) {
            FormTicketList f = new FormTicketList();
            f.ShowDialog();
        }
    }
}
