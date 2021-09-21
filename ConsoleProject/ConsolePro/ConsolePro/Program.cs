using ConsolePro.Enums;
using ConsolePro.Models;
using ConsolePro.Service;
using System;

namespace ConsolePro
{
    class Program
    {
        static void Main(string[] args)
        {
            Marketable marketable = new Marketable();
            do
            {
                Console.WriteLine("1.Mehsullar uzerinde emeliyyatlar:");
                Console.WriteLine("2.Satiwlar uzerinde emeliyyatlar:");
                Console.WriteLine("3.Cixiw:");
                string ans = Console.ReadLine();
                int chooseNum;
                int.TryParse(ans, out chooseNum);
                while (!int.TryParse(ans,out chooseNum))
                {
                    Console.WriteLine("Zehmet olmazsa reqem daxil edin");
                    ans = Console.ReadLine();
                }
                switch (chooseNum)
                {
                    case 1:
                        Mehsullar(marketable);
                        break;
                    case 2:
                        Sells(marketable);
                        break;
                    case 3:
                        Exit(marketable);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
        static void Mehsullar (Marketable marketable)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Mehsul elave etmek");
            Console.WriteLine("2.Mehsul uzerinde duzelis et");
            Console.WriteLine("3. Mehsulu sil");
            Console.WriteLine("4.Butun mehsullari goster");
            Console.WriteLine("5.Categoriyasina gore mehsullari goster");
            Console.WriteLine("6.Qiymet araligina gore mehsullari goster");
            Console.WriteLine("7.Mehsullar arasinda ada gore axtaris et");
            Console.WriteLine("--------------------------");
            string cavab = Console.ReadLine();
            int choosecavab;
            int.TryParse(cavab, out choosecavab);
            while (!int.TryParse(cavab, out choosecavab))
            {
                Console.WriteLine("Reqem sec");
                cavab = Console.ReadLine();
            }
            switch (choosecavab)
            {
                case 1:
                    AddMehsul(marketable);
                    break;
                case 2:
                    EditMehsul(marketable);
                    break;
                case 3:
                    RemoveMehsul(marketable);
                    break;
                case 4:
                    GetMehsuls(marketable);
                    break;
                case 5:
                    GetMehsulforCategory(marketable);
                    break;
                case 6:
                    GetMehsulforPricearaliqi(marketable);
                    break;
                case 7:
                    SearchforName(marketable);
                    break;
                default:
                    break;
            }


        }
        static void AddMehsul(Marketable marketable)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ad elave et");
            Console.WriteLine("--------------------------");
            string name = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Qiymet elave et");
            string price = Console.ReadLine();
            double intprice;
            double.TryParse(price, out intprice);
            while (!double.TryParse(price,out intprice))
            {
                Console.WriteLine("reqem daxil et");
                price = Console.ReadLine();
            }
            Console.WriteLine("Say elave et");
            string count = Console.ReadLine();
            int intcount;
            
            while (!int.TryParse(count, out intcount))
            {
                Console.WriteLine("reqem daxil et");
                count = Console.ReadLine();
            }
            Console.WriteLine("Kod elave et");
            string code = Console.ReadLine();
            int intcode;
            
            while (!int.TryParse(code, out intcode))
            {
                Console.WriteLine("reqem daxil et");
                code = Console.ReadLine();
            }
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            Console.WriteLine("Kateqoriya sec");
            string ans = Console.ReadLine();
            int intcategory;

            while (!int.TryParse(ans, out intcategory))
            {
                Console.WriteLine("Categorinin nomresono duzgun daxil et");
                ans = Console.ReadLine();
            }
            Categories categories = (Categories)intcategory;
            marketable.AddnewMehsul(name, intprice, categories, intcount, intcode);

        }
        static void GetMehsuls(Marketable marketable)
        {
            marketable.GetMehsuls();
        }
        static void EditMehsul(Marketable marketable)
        {
            Console.WriteLine("Deyiwmek istediyin mehsulun codunu daxil et");
            foreach (var item in marketable.Mehsullar)
            {
                Console.WriteLine(item.Code);
                
            }
            

            string code = Console.ReadLine();
            int intcode;

            while (!int.TryParse(code, out intcode))
            {
                Console.WriteLine("reqem daxil et");
                code = Console.ReadLine();
            }
            foreach (var item in marketable.Mehsullar)
            {
                while (item.Code != int.Parse(code))
                {
                    Console.WriteLine("Duzgun kod yaz");
                    code = Console.ReadLine();
                    
                }
                
            }
            Console.WriteLine("Yeni ad daxil et");
            string newname = Console.ReadLine();
            Console.WriteLine("Yeni categoriya daxil et");
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            Console.WriteLine("Kateqoriya sec");
            string ans = Console.ReadLine();
            int intnewcategory;

            while (!int.TryParse(ans, out intnewcategory))
            {
                Console.WriteLine("Categorinin nomresono duzgun daxil et");
                ans = Console.ReadLine();
            }
            Categories newcategories = (Categories)intnewcategory;

            Console.WriteLine("Yeni qiymet daxil et");
            string newprice = Console.ReadLine();
            double intnewprice;
            double.TryParse(newprice, out intnewprice);
            while (!double.TryParse(newprice, out intnewprice))
            {
                Console.WriteLine("reqem daxil et");
                newprice = Console.ReadLine();
            }
            Console.WriteLine("Yeni say elave et");
            string newcount = Console.ReadLine();
            int intnewcount;

            while (!int.TryParse(newcount, out intnewcount))
            {
                Console.WriteLine("reqem daxil et");
                newcount = Console.ReadLine();
            }
            marketable.EditMehsul(newname,newcategories,intnewprice, intnewcount);

        }
        static void RemoveMehsul(Marketable marketable)
        {
            Console.WriteLine("Silmek istediyin mehsulun nomresini daxil et");
            string mehsulcode = Console.ReadLine();
            int code;
            int.TryParse(mehsulcode, out code);
            while (!int.TryParse(mehsulcode, out code))
            {
                Console.WriteLine("Zehmet olmazsa reqem daxil edin");
                mehsulcode = Console.ReadLine();
            }
            Mehsul mehsul = null;
            foreach (Mehsul item in marketable.Mehsullar)
            {
                if (item.Code == code)
                {
                    mehsul = item;
                }
            }
            int index = Array.IndexOf(marketable.Mehsullar, mehsul);
            Array.Clear(marketable.Mehsullar, index, 1);
            Console.WriteLine("Mehsul silindi");
        }
        static void SearchforName (Marketable marketable)
        {
            Console.WriteLine("Istediyiniz mehsulun adini daxil edin");
            string text = Console.ReadLine();
            marketable.GetMehsulfortext(text);
        }
        static void GetMehsulforCategory(Marketable marketable)
        {
            Console.WriteLine("Kateqoriyani secin :");
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine(item);
            }
            string category = Console.ReadLine();
            int categorie;
            int.TryParse(category, out categorie);
            while (!int.TryParse(category, out categorie))
            {
                Console.WriteLine("Reqem sec");
                category = Console.ReadLine();
            }

            Categories categories = (Categories)categorie;
            marketable.GetMehsulforCategory(categories);
        }
        static void GetMehsulforPricearaliqi(Marketable marketable)
        {
            Console.WriteLine("Minimum qiymet daxil edin");
            string min = Console.ReadLine();
            int intmin;
            while (!int.TryParse(min, out intmin))
            {
                Console.WriteLine("Reqem yaz");
                min = Console.ReadLine();
            }
            Console.WriteLine("Maximum qiymeti daxil edin");
            string max = Console.ReadLine();
            int intmax;
            while (!int.TryParse(max, out intmax))
            {
                Console.WriteLine("Reqem yaz");
                max = Console.ReadLine();
            }
            marketable.GetMehsulforPrice(intmin, intmax);
        }
        static void Sells(Marketable marketable)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Satiw elave etmek");
            Console.WriteLine("2.Satisdaki hansisa mehsulun geri qaytarilmasi( satisdan cixarilmasi)");
            Console.WriteLine("3.Satisin silinmesi");
            Console.WriteLine("4.Butun satiwlari goster");
            Console.WriteLine("5.Verilen tarix araligina gore satislarin gosterilmesi ");
            Console.WriteLine("6.Verilen mebleg araligina gore satislarin gosterilmesi");
            Console.WriteLine("7.Verilmis bir tarixde olan satislarin gosterilmesi");
            Console.WriteLine("8.Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi");
            Console.WriteLine("--------------------------");
            string cavab = Console.ReadLine();
            int choosecavab;
            int.TryParse(cavab, out choosecavab);
            while (!int.TryParse(cavab, out choosecavab))
            {
                Console.WriteLine("Reqem sec");
                cavab = Console.ReadLine();
            }
            switch (choosecavab)
            {
                case 1:
                    AddnewSell(marketable);
                    break;
                case 2:
                    Qaytarma(marketable);
                    break;
                case 3:
                    RemoveSell(marketable);
                    break;
                case 4:
                    GetSells(marketable);
                    break;
                case 5:
                    DateAverage(marketable);
                    break;
                case 6:
                    GetSellforPricearaliqi(marketable);
                    break;
                case 7:
                    
                    break;
                case 8:
                    GetSellforNo(marketable);
                    break;
                default:
                    break;
            }
        }
        static void AddnewSell(Marketable marketable)
        {
            Console.WriteLine("Satiwin nomresini qeyd edin");
            string strno = Console.ReadLine();
            int no;
            while (!int.TryParse(strno,out no))
            {
                Console.WriteLine("Reqem daxil et");
                strno = Console.ReadLine();
            }
            Console.WriteLine("Qiymet daxil edin");
            string strprice = Console.ReadLine();
            double price;
            while (!double.TryParse(strprice,out price))
            {
                Console.WriteLine("Reqem daxil et");
                strprice = Console.ReadLine();
            }
            Console.WriteLine("Mehsulun sayini daxil edin");
            string strcount = Console.ReadLine();
            int count;
            while (!int.TryParse(strcount,out count))
            {
                Console.WriteLine("Reqem daxil et");
                strcount = Console.ReadLine();
            }
            
            Console.WriteLine("Mehsulun codunu daxil edin");
            string code = Console.ReadLine();
            int codeint;
            while (!int.TryParse(code,out codeint))
            {
                Console.WriteLine("Reqem daxil et");
                code = Console.ReadLine();
            }
            foreach (Mehsul item in marketable.Mehsullar)
            {
                if (item.Code == codeint)
                {
                    if (count <= item.Count)
                    {
                        Console.WriteLine("Satiw yaradildi");
                    }
                    else
                    {
                        Console.WriteLine("bu Sayda mehsul yoxdur");
                        return;
                    }
                }
            }

            Mehsul mehsullar = null;
            foreach (Mehsul item in marketable.Mehsullar)
            {
                mehsullar = item;
            }
            marketable.AddSell(no, price, count,codeint ,mehsullar);

        }
        static void GetSells(Marketable marketable)
        {
            marketable.GetAllSell();
        }
        static void GetSellforPricearaliqi(Marketable marketable)
        {
            Console.WriteLine("Minimum qiymet daxil edin");
            string min = Console.ReadLine();
            double intmin;
            while (!double.TryParse(min, out intmin))
            {
                Console.WriteLine("Reqem yaz");
                min = Console.ReadLine();
            }
            Console.WriteLine("Maximum qiymeti daxil edin");
            string max = Console.ReadLine();
            double intmax;
            while (!double.TryParse(max, out intmax))
            {
                Console.WriteLine("Reqem yaz");
                max = Console.ReadLine();
            }
            marketable.GetSellforPrice(intmin, intmax);
        }
        static void GetSellforNo(Marketable marketable)
        {
            Console.WriteLine("Satiwin nomresini qeyd edin");
            string strno = Console.ReadLine();
            int no;
            while (!int.TryParse(strno,out no))
            {
                Console.WriteLine("Reqem daxil edin");
                strno = Console.ReadLine();
            }
            marketable.GetSellforNo(no);
        }
        static void RemoveSell(Marketable marketable)
        {
            Console.WriteLine("Silmek istediyin mehsulun nomresini daxil et");
            string sellno = Console.ReadLine();
            int no;
            int.TryParse(sellno, out no);
            while (!int.TryParse(sellno, out no))
            {
                Console.WriteLine("Zehmet olmazsa reqem daxil edin");
                sellno = Console.ReadLine();
            }
            Sell sell = null;
            foreach (Sell item in marketable.Sells)
            {
                if (item.No == no)
                {
                    sell = item;
                }
            }
            int index = Array.IndexOf(marketable.Sells, sell);
            Array.Clear(marketable.Sells, index, 1);
            Console.WriteLine("Satiw silindi");
        }
        static void DateAverage(Marketable marketable)
        {
            
            Console.WriteLine("Bawlanqic tarixi qeyd edin");
            string dt= Console.ReadLine();
            DateTime date1;
            while (!DateTime.TryParse(dt, out date1))
            {
                Console.WriteLine("zehmet olmazsa tarixi bu ardicilliqla qeyd edin(dd mm yy");
                dt = Console.ReadLine();
            }
            Console.WriteLine("Son tarixi qeyd edin");
            string dt2 = Console.ReadLine();
            DateTime date2;
            while (!DateTime.TryParse(dt2,out date2))
            {
                Console.WriteLine("zehmet olmazsa tarixi reqemle daxil edin ve bu ardicilliqda olsun(gun ay il)");
                dt2 = Console.ReadLine();
            }
            marketable.GetSellforDataaraliqi(date1, date2);
        }
        static void SellforDate(Marketable marketable)
        {
            Console.WriteLine("Tarixi qeyd edin");
            string dt = Console.ReadLine();
            DateTime date;
            while (!DateTime.TryParse(dt, out date))
            {
                Console.WriteLine("zehmet olmazsa tarixi reqemle daxil edin ve bu ardicilliqda olsun(gun ay il)");
                dt = Console.ReadLine();
            }
            marketable.GetSellforDate(date);
        }
        static void Qaytarma(Marketable marketable)
        {

            foreach (Mehsul item in marketable.Mehsullar)
            {
                Console.WriteLine(item.Price);
            }
            Console.WriteLine("Qaytarmaq istediyiniz Satiwin kodunu daxil edin");
            foreach (Sell item in marketable.Sells)
            {
                Console.WriteLine(item.No);
            }
            string no = Console.ReadLine();

            foreach (Sell item in marketable.Sells)
            {
                while (item.No != int.Parse(no))
                {
                    Console.WriteLine("Duzgun daxil edin");
                    no = Console.ReadLine();
                }

            }
            Console.WriteLine("Mehsulun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Sayini daxil edin");
            string count = Console.ReadLine();
            int intcount;
            while (!int.TryParse(count, out intcount))
            {
                Console.WriteLine("zehmet olmazsa reqem daxil edin");
                count = Console.ReadLine();
            }
            marketable.ReturnProduct(no, intcount, name);
        }
        static void Exit(Marketable marketable)
        {
            Console.WriteLine();
            Console.Clear();
            Console.ReadKey(true);
            
        }
    }
}
