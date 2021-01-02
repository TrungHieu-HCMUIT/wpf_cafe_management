using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe_management.Model;

namespace cafe_management.ViewModel
{
    class MenuViewModel : BaseViewModel
    {
        private ObservableCollection<MON> _List;
        public ObservableCollection<MON> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private MON _SelectedItem;
        public MON SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaM = SelectedItem.MaM;
                    TenMon = SelectedItem.TenMon;
                    DonGia = SelectedItem.DonGia;
                    MaLoai = SelectedItem.MaLoai;
                }
            }
        }
        public void LoadMenuList()
        {
            List = new ObservableCollection<MON>();

            var objectList = DataProvider.Ins.DB.MONs;
            foreach (var iteam in objectList)
            {
                if (iteam.MaLoai == 1)
                    List.Add(iteam);
            }
        }
        private string _MaM;
        public string MaM { get => _MaM; set { _MaM = value; OnPropertyChanged(); } }

        private string _TenMon;
        public string TenMon { get => _TenMon; set { _TenMon = value; OnPropertyChanged(); } }

        private Nullable<decimal> _DonGia;
        public Nullable<decimal> DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }

        private Nullable<int> _MaLoai;
        public Nullable<int> MaLoai { get => _MaLoai; set { _MaLoai = value; OnPropertyChanged(); } }
    }
}
