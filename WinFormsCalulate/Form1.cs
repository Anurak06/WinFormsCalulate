namespace WinFormsCalulate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input รับค่าจาก Textbox (แปลงค่าข้อมูลเป็น Double)
            double Redius = 0;
            //Redius = Convert.ToDouble(txtRedius.Text);
            if (double.TryParse(txtRedius.Text, out Redius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error!!");
                txtRedius.Focus();//ให้มี Cursor ที่ Textbox
                txtRedius.SelectAll();//ให้ Selected ข้อความใน Textbox
                return;
            }
            //process คำนวณพื้นที่ สูตร pi*r*r
            double CricleArea = Math.PI * Math.Pow(Redius, 2);
            //Math.PI ให้ค่า pi
            //Math.pow(x,y) x ยกกำลัง y
            //output นำไปแสดงผลที่ lblResult
            lblResult.Text = CricleArea.ToString("0.00");

            txtRedius.Focus();
            txtRedius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            double w = 0, h = 0, sum = 0;
            //แปลงค่า ข้อความเป็นตัวเลข
            w = Convert.ToInt32(txtWidth.Text);
            h = Convert.ToInt32(txtHeight.Text);
            sum = 0.5 * w * h;
            // นำไปแสดงผลที่ lblResult
            lblResult.Text = sum.ToString();

            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexahonWidth = 0;
            if (double.TryParse(txtPolygonWidth.Text, out HexahonWidth) == false)
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", " Error!!!");
                txtPolygonWidth.Focus();
                txtPolygonWidth.SelectAll();
                return;
            }

            // คำนวณ รากที่3หารด้วย4 * ด้าน กำลัง2 * 6
            double HexagonArea = Math.Sqrt(3) / 4 * Math.Pow(HexahonWidth, 2) * 6;

            //นำไปแสดงผลที่ lblResult
            lblResult.Text = HexagonArea.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
