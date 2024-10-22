namespace Week_7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            intMyArray = new int[MAX_SIZE];
        }

        const int MAX_SIZE = 10;
        int[] intMyArray;

        private void NhapMang()
        {
            Random random = new Random();
            for (int i = 0; i < intMyArray.Length; i++)
            {
                intMyArray[i] = random.Next(1, 101);
            }
        }

        private void XuatMang(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                TxtArray.Text += "  " + array[i].ToString();
            }
        }
        private int TongMang(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        private int DemPhanTuLe(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        private int TongPhanTuLe(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        private int PhanTuNhoNhat(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        private int[] TangPhanTuLen2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
            return array;
        }

        private int[] SapMangGiam(int[] array)
        {
            int[] newArray = array;
            Array.Sort(newArray, (x, y) => y.CompareTo(x));
            return newArray;
        }
        private int[] SapMangTang(int[] array)
        {
            int[] newArray = array;
            Array.Sort(newArray);
            return newArray;
        }
        private void BtnXuatMang_Click(object sender, EventArgs e)
        {
            TxtArray.Text = "";
            this.NhapMang();
            this.XuatMang(intMyArray);
        }

        private void BtnTongGiaTri_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Tổng Mảng: {TongMang(intMyArray)}";
        }

        private void BtnDemPhanTuLe_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Số Phần Tử Lẻ: {DemPhanTuLe(intMyArray)}";
        }

        private void BtnTongLe_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Tổng Phần Tử Lẻ: {TongPhanTuLe(intMyArray)}";
        }
        private void BtnPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Phần tử nhỏ nhất: {PhanTuNhoNhat(intMyArray)}";
        }

        private void BtnTang2_Click(object sender, EventArgs e)
        {
            //TxtResult.Text = $"Tăng 2: {TangPhanTuLen2(intMyArray).ToString()}";
            TxtResult.Text = $"Sắp mảng giảm: {string.Join(", ", TangPhanTuLen2(intMyArray))}";
        }

        private void BtnSapXepTang_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Sắp mảng giảm: {string.Join(", ", SapMangTang(intMyArray))}";
        }

        private void BtnSapXepGiam_Click(object sender, EventArgs e)
        {
            TxtResult.Text = $"Sắp mảng giảm: {string.Join(", ", SapMangGiam(intMyArray))}";
        }
    }
}

