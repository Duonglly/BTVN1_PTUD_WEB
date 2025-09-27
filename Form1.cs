using System;
using System.Windows.Forms;

namespace GiaiPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Đặt nội dung tiêu đề và label cho rõ ràng
            lblTieude.Text = "Giải phương trình bậc 2: ax² + bx + c = 0";
            lblA.Text = "Hệ số a:";
            lblB.Text = "Hệ số b:";
            lblC.Text = "Hệ số c:";
            lblResult.Text = "";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                if (a == 0)
                {
                    // Trường hợp phương trình bậc 1: bx + c = 0
                    if (b == 0)
                    {
                        lblResult.Text = (c == 0) ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.";
                    }
                    else
                    {
                        double x = -c / b;
                        lblResult.Text = $"Phương trình bậc nhất có nghiệm: x = {x}";
                    }
                    return;
                }

                // Tính delta
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    lblResult.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    lblResult.Text = $"Phương trình có nghiệm kép: x = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblResult.Text = $"Phương trình có 2 nghiệm:\n x₁ = {x1}\n x₂ = {x2}";
                }
            }
            catch (FormatException)
            {
                lblResult.Text = "⚠️ Vui lòng nhập đầy đủ và đúng định dạng số!";
            }
        }
    }
}
