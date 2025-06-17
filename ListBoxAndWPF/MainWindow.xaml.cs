using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxAndWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<int> dsDuLieu = new List<int>();

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }

        void HienThiDanhSach()
        {
            listDuLieu.Items.Clear();
            for(int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                listDuLieu.Items.Add(x);
            }
        }

        private void btnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int viTri = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(viTri, x);
            HienThiDanhSach();
            txtGiaTriChen.Text = "";
            txtViTriChen.Text = "";
        }

        private void btnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();
        }

        private void btnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach();
        }

        private void btnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if(listDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa", "Thong bao loi", MessageBoxButton.OK);
                return;
            }

            dsDuLieu.RemoveAt(listDuLieu.SelectedIndex);
            HienThiDanhSach();
        }

        private void btnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if(listDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa", "Thong bao loi", MessageBoxButton.OK);
                return;
            }

            while(listDuLieu.SelectedItems.Count > 0)
            {
                int data = (int)listDuLieu.SelectedItems[0];
                dsDuLieu.Remove(data);
                listDuLieu.Items.Remove(data);
            }
        }

        private void btnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhSach();
        }
    }
}