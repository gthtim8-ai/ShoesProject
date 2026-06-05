using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesProject
{
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewImageColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
