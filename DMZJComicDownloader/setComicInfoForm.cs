using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZJComicDownloader
{
    public partial class setComicInfoForm : Form
    {
        ComicInfo info;
        public setComicInfoForm(ComicInfo Info)
        {
            info = Info;
            InitializeComponent();
        }
        private void setComicInfoForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = info.name;
            aliasTextBox.Text = info.alias;
            originalNameTextBox.Text = info.originalName;
            regionTextBox.Text = info.region;
            statusTextBox.Text = info.status;
            popularityTextBox.Text = info.popularity;
            classificationTextBox.Text = info.classification;
            cartoonDescTextBox.Text = info.cartoonDesc;
        }

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            info.name = nameTextBox.Text;
            info.alias = aliasTextBox.Text;
            info.originalName = originalNameTextBox.Text;
            info.region = regionTextBox.Text;
            info.status = statusTextBox.Text;
            info.popularity = popularityTextBox.Text;
            info.classification = classificationTextBox.Text;
            info.cartoonDesc = cartoonDescTextBox.Text;
            this.Close();
        }

        private void cancelInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
