using cafe_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cafe_management
{
    /// <summary>
    /// Interaction logic for SpendingWindow.xaml
    /// </summary>
    public partial class SpendingWindow : Window
    {
        public string name_input;
        public int quantity_input;
        public string unit_input;
        public int price_input;

        private List<Ingredient> ingredients_list = new List<Ingredient>();
        public SpendingWindow()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            int totalPrice = 0;
            dgIngredient.ItemsSource = null;
            dgIngredient.ItemsSource = ingredients_list;

            for (int i = 0; i <ingredients_list.Count;i++)
            {
                totalPrice += ingredients_list[i].Price * ingredients_list[i].Quantity;
            }
            TotalPrice.Text = totalPrice.ToString() + " đ";            
        }

        private void ResetInputTextBox()
        {
            tbName.Text = null;
            tbQuantity.Text = null;
            tbUnit.Text = null;
            tbPrice.Text = null;
        }

        private int CheckInput()
        {
            if ((tbName.Text == "") || (tbQuantity.Text == "") || (tbUnit.Text == "") || (tbPrice.Text == ""))
                return -1;
            else if (!Int32.TryParse(tbQuantity.Text, out int quantity))
                return -2;
            else if (!Int32.TryParse(tbPrice.Text, out int price))
                return -3;
            return 1;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            name_input = tbName.Text.Trim();
            quantity_input = Convert.ToInt32(tbQuantity.Text.Trim());
            unit_input = tbUnit.Text.Trim();
            price_input = Convert.ToInt32(tbPrice.Text.Trim());

            if (CheckInput() == -1)
            {
                NotificationWindow notice = new NotificationWindow("Dữ liệu thiếu", "Vui lòng nhập lại");
                notice.ShowDialog();
            }
            else if (CheckInput() == -2)
            {
                NotificationWindow notice = new NotificationWindow("Số lượng sai định dạng", "Vui lòng nhập lại");
                notice.ShowDialog();
            }
            else if (CheckInput() == -3)
            {
                NotificationWindow notice = new NotificationWindow("Giá sai định dạng", "Vui lòng nhập lại");
                notice.ShowDialog();
            }
            else
            {
                for (int i = 0; i <ingredients_list.Count; i++)
                {
                    if (ingredients_list[i].Name == name_input && ingredients_list[i].Unit == unit_input && ingredients_list[i].Price == price_input)
                    {
                        ingredients_list[i].Quantity += quantity_input;
                        UpdateList();
                        ResetInputTextBox();

                        return;
                    }
                }

                Ingredient ingredient = new Ingredient(name_input, quantity_input, unit_input, price_input);
                ingredients_list.Add(ingredient);
                UpdateList();
                ResetInputTextBox();
            }
        }

        private void Garbage_Click(object sender, RoutedEventArgs e)
        {
            var index = dgIngredient.SelectedIndex;
            ingredients_list.RemoveAt(index);

            UpdateList();
        }

        private void MinusQuantity_Click(object sender, RoutedEventArgs e)
        {
            var index = dgIngredient.SelectedIndex;
            if (ingredients_list[index].Quantity <= 1)
                return;
            ingredients_list[index].Quantity--;

            UpdateList();
        }

        private void AddQuantity_Click(object sender, RoutedEventArgs e)
        {
            var index = dgIngredient.SelectedIndex;
            ingredients_list[index].Quantity++;

            UpdateList();
        }

        //private List<Revenue> GetRevenue()
        //{
        //    List<Revenue> list = new List<Revenue>();
        //    var objectList = DataProvider.Ins.DB.CTHDs;
        //    foreach (var item in objectList)
        //    {
        //        Revenue revenue = new Revenue(item.MaHD, item.MON.TenMon, item.SL, Convert.ToInt64(item.MON.DonGia * item.SL));
        //        list.Add(revenue);
        //    }
        //    return list;
        //}
        //private void CreateNGUYENLIEU(List<CTHD> list)
        //{
        //    //NGUYENLIEU hd = new NGUYENLIEU();
        //    if (list.Count == 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        using (QLCFEntities1 db = new QLCFEntities1())
        //        {
        //            NGUYENLIEU hd = new NGUYENLIEU()
        //            {

        //            }
        //            //var temp = db.NGUYENLIEUx.Add(new NGUYENLIEU()
        //            //{
        //            //    TenNgL=Name,
        //            //    DonGia= Convert.ToDecimal(Price),
        //            //    DonVi= Unit
        //            //});
        //            //db.SaveChanges();

        //            foreach (var item in ingredients_list)
        //            {

        //                TenNgl = item.Name;

        //            }
        //            db.SaveChanges();
        //        }
        //    }
        //}

        //private List<NGUYENLIEU> ConvertToNGUYENLIEU()
        //{
        //    List<NGUYENLIEU> list = new List<NGUYENLIEU>();
        //    foreach (var item in ingredients_list)
        //    {
        //        NGUYENLIEU ngl = new NGUYENLIEU()
        //        {
        //            TenNgL = item.Name,
        //            DonGia = Convert.ToDecimal(item.Price),
        //            DonVi = item.Unit,

        //        };
        //        list.Add(ngl);
        //    }
        //    return list;
        //}
        //private void CreateNGUYENLIEU(List<CTPC> list)
        //{
        //    NGUYENLIEU ngl = new NGUYENLIEU();
        //    using (QLCFEntities1 db = new QLCFEntities1())
        //    {
        //        foreach (var item in ingredients_list)
        //        {
        //            var x = db.NGUYENLIEUx.Add(new NGUYENLIEU()
        //            {
        //                TenNgL = item.Name,
        //                DonGia = Convert.ToDecimal(item.Price),
        //                DonVi = item.Unit,
        //                //CTPCs = list  

        //            }) ;
        //            // db.SaveChanges();
        //            //foreach (CTPC ctpc in ngl.CTPCs)
        //            //{

        //            //    ctpc.MaNgL = x.MaNgL;
        //            //    db.CTPCs.Add(ctpc);

        //            //}
        //            db.SaveChanges();
        //        }
        //        db.SaveChanges();
        //    }
        //}
        //private List<CTPC> ConvertToCTPC()
        //{
        //    List<CTPC> list = new List<CTPC>();
        //    foreach (var item in ingredients_list)
        //    {
        //        CTPC ctpc = new CTPC()
        //        {
        //           // MaNgL = item.id,                  
        //            SL = item.Quantity 

        //        };
        //        list.Add(ctpc);
        //    }
        //    return list;
        //}

        //private void CreatePHIEUCHI(List<CTPC> list)
        //{
        //    PHIEUCHI pc = new PHIEUCHI();
        //    string x = TotalPrice.Text.Replace("đ", "");
        //    if (list.Count == 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        using (QLCFEntities1 db = new QLCFEntities1())
        //        {
        //            var temp = db.PHIEUCHIs.Add(new PHIEUCHI()
        //            {
        //                NgNhap = DateTime.Now,
        //                TongGia = Convert.ToDecimal(x),
        //                CTPCs = list

        //            }) ;
        //            db.SaveChanges();
        //            foreach (CTPC ctpc in pc.CTPCs)
        //            {

        //                ctpc.MaPC = temp.MaPC;
        //                db.CTPCs.Add(ctpc);

        //            }
        //            db.SaveChanges();

        //        }
        //    }
        //}
        //private void Confirm_Click(object sender, RoutedEventArgs e)
        //{
        //    List<CTPC> ctpc = ConvertToCTPC();
        //    CreateNGUYENLIEU(ctpc);
        //    CreatePHIEUCHI(ctpc);


        //    StaffWindow staffWindow = new StaffWindow();
        //    staffWindow.Show();
        //    this.Close();

        //}
        private void CreateNGUYENLIEU(/*List<CTPC> list*/)
        {
            NGUYENLIEU ngl = new NGUYENLIEU();
            using (QLCFEntities1 db = new QLCFEntities1())
            {
                foreach (var item in ingredients_list)
                {
                    var x = db.NGUYENLIEUx.Add(new NGUYENLIEU()
                    {
                        TenNgL = item.Name,
                        DonGia = Convert.ToDecimal(item.Price),
                        DonVi = item.Unit,
                        //CTPCs = list

                    });
                    db.SaveChanges();
                    item.ID = x.MaNgL;
                    //db.SaveChanges();
                    //foreach (CTPC ctpc in ngl.CTPCs)
                    //{

                    //    ctpc.MaNgL = x.MaNgL;
                    //    db.CTPCs.Add(ctpc);

                    //}
                    //db.SaveChanges();
                }
               // db.SaveChanges();
            }
        }
        private List<CTPC> ConvertToCTPC()
        {
            List<CTPC> list = new List<CTPC>();
            foreach (var item in ingredients_list)
            {
                CTPC ctpc = new CTPC()
                {
                    MaNgL = item.ID,
                    SL = item.Quantity

                };
                list.Add(ctpc);
            }
            return list;
        }

        private void CreatePHIEUCHI(List<CTPC> list)
        {
            PHIEUCHI pc = new PHIEUCHI();
            string x = TotalPrice.Text.Replace("đ", "");
            if (list.Count == 0)
            {
                return;
            }
            else
            {
                using (QLCFEntities1 db = new QLCFEntities1())
                {
                    var temp = db.PHIEUCHIs.Add(new PHIEUCHI()
                    {
                        NgNhap = DateTime.Now,
                        TongGia = Convert.ToDecimal(x),
                        CTPCs = list

                    });
                    db.SaveChanges();
                    foreach (CTPC ctpc in pc.CTPCs)
                    {
                        ctpc.MaPC = temp.MaPC;
                        db.CTPCs.Add(ctpc);
                    }
                    db.SaveChanges();

                }
            }
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            CreateNGUYENLIEU(/*ctpc*/);
            List<CTPC> ctpc = ConvertToCTPC();

            
            
            CreatePHIEUCHI(ctpc);


            StaffWindow staffWindow = new StaffWindow();
            staffWindow.Show();
            this.Close();

        }

        private void Terminate_Click(object sender, RoutedEventArgs e)
        {
            StaffWindow staffWindow = new StaffWindow();
            staffWindow.Show();
            this.Close();
        }
    }

    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }

        public Ingredient(string name, int quantity, string unit, int price)
        {
            
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Price = price;
        }
    }
}


