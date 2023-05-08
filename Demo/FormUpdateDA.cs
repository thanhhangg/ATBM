using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FormUpdateDA : Form
    {
        string mada, tenda, ngaybd, phongtxt;
        public FormUpdateDA(string mada, string tenda, string ngaybd, string phong)
        {
            this.mada = mada;
            this.tenda = tenda;
            this.ngaybd = ngaybd;
            this.phongtxt = phong;
            InitializeComponent();
        }

        private void FormUpdateDA_Load(object sender, EventArgs e)
        {
            DateTime ngay = DateTime.Parse(ngaybd);
            maDA.Text = mada;
            tenDA.Text = tenda;
            ngayBD.Text = ngay.ToString("dd-MMMM-yyyy");
            phong.Text = phongtxt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = DateTime.Parse(ngayBD.Text);
            var data = new
            {
                username = Auth.GetInstance().Username,
                TENDA = tenDA.Text.ToString(),
                NGAYBD = ngaybd.ToString("dd-MMMM-yyyy"),
                PHONG = phong.Text.ToString(),
                MADA = mada,
            };
            Console.WriteLine(data);
            string jsonBody = JsonSerializer.Serialize(data);
            var result = ApiRequest.Post<object>("/users/trgda/dean/update", jsonBody);
            this.Close();
        }
    }
}
