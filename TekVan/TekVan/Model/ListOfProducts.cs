using System.Collections.ObjectModel;

namespace TekVan.Model
{
    public class ListOfProducts
    {
        public static ObservableCollection<Product> ProductsList;

        public ListOfProducts()
        {
            ProductsList = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 0,
                    Avatar = "http://dlcdnimgs.asus.com/websites/global/products/spbWNHiduk5uSRfu/img/00/fg05.png",
                    Brand = "ASUS",
                    Price = 1630,
                    Name = "ASUS ROG GL502VS",
                    SettingDetails = "CPU:  Intel Core i7-7700HQ Processor \n" +
                                     "RAM: 16GB DDR4 DRAM \n" +
                                     "Hard Disk: 128GB SSD + 1TB HDD \n" +
                                     "Graphic: GeForce GTX 1070 8GB Core i7-7700HQ \n",
                },
                new Product
                        {
                            Id = 1,
                            Avatar = "http://www.nbplaza.com.my/4410/asus-rog-gaming-series-gl552v-xdm409t-156-laptop-i7-7700hq-4gb-1tb-gtx-950m-4gb-w10h.jpg",
                            Brand = "ASUS",
                            Price = 1197,
                            Name = "ASUS ROG GL552VW",
                            SettingDetails = "CPU: Intel® Core™ i7 6700HQ Processor \n" +
                                             "RAM: DDR4 MHz SDRAM, 16 GB \n" +
                                             "Hard Disk: 1TB HDD 7200 RPM + 128GB SSD  \n" +
                                             "Graphic: NVIDIA® GeForce® GTX 960M with 4GB GDDR5 VRAM \n",
                        },
                new Product
                {
                    Id = 2,
                    Avatar = "http://cdn.fptshop.com.vn/Uploads/Originals/2017/3/31/636265183842411933_asus-gl553vd-fy175-2.jpg",
                    Brand = "ASUS",
                    Price = 1526,
                    Name = "ASUS ROG GL553VD-FY175",
                    SettingDetails = "CPU: Intel Core i5 7300HQ 2.5GHz up to 3.5GHz 6MB \n" +
                                     "RAM: 8GB DDR4 2400MHz \n" +
                                     "Hard Disk: HDD 1TB 7200rpm, x1 slot SSD  \n" +
                                     "Graphic: NVIDIA GeForce GTX 1050 4GB GDDR5 + Intel Graphics 630 \n",
                },
                new Product
                {
                    Id = 3,
                    Avatar = "http://laptopnew.vn/htdocs/images/products/laptop-asus-fx503.jpg",
                    Brand = "ASUS",
                    Price = 1700,
                    Name = "ASUS ROG FX503VD-E4119T",
                    SettingDetails = "CPU: Intel Core i7 7700HQ 2.8GHz up to 3.8GHz 6MB \n" +
                                     "RAM: 8GB DDR4 2400MHz \n" +
                                     "Hard Disk: NVIDIA GeForce GTX 1050 4GB GDDR5 + Intel Graphics 630  \n" +
                                     "Graphic: NVIDIA GeForce GTX 1050 4GB GDDR5 + Intel Graphics 630 \n",
                },
                new Product
                {
                    Id = 4,
                    Avatar = "http://support.apple.com/library/APPLE/APPLECARE_ALLGEOS/SP749/SP749-mbp15touch-gray.jpg",
                    Brand = "APPLE",
                    Price = 2589,
                    Name = "Apple Macbook Pro 2016",
                    SettingDetails = "CPU:  Intel Core i5 (2.9Ghz - Up to 3.3Ghz) \n" +
                                     "RAM: LPDDR3 8 GB 2133 MHz \n" +
                                     "Hard Disk: SSD 512GB  \n" +
                                     "Graphic: Intel Iris Graphics 550 \n",
                },
                new Product
                {
                    Id = 5,
                    Avatar = "http://cdn.nguyenkimmall.com/images/companies/_1/Content/tin-hoc/laptop/dell/may-tinh-xach-tay-dell-vostro-15-5568-70087068-core-i5-win10-2.jpg",
                    Brand = "DELL",
                    Price = 898,
                    Name = "Dell Vostro 15 5568 70087068",
                    SettingDetails = "CPU:  Intel Core i5-7200U 2.5 GHz \n" +
                                     "RAM: 4GB \n" +
                                     "Hard Disk: HDD 500GB  \n" +
                                     "Graphic: Intel HD Graphics \n",
                },
            };
        }
    }
}