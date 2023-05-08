using System.Text.Json;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class FormAddDA : Form
    {
        public FormAddDA()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            DateTime ngaybd = DateTime.Parse(ngayBD.Text);
            var data = new
            {
                username = Auth.GetInstance().Username,
                TENDA = tenDA.Text.ToString(),
                NGAYBD = ngaybd.ToString("dd-MMMM-yyyy"),
                PHONG = phong.Text.ToString(),
            };
            string jsonBody = JsonSerializer.Serialize(data);
            var result = ApiRequest.Post<object>("/users/trgda/dean/insert", jsonBody);
            this.Close();

        }
    }
}
