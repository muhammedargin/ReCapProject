using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class AdminMenuManager :IMenuService
    {

        public void MenuForAdmin()
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(inMemoryCarDal);
            do
            {
                Console.Clear();
                string title = "ANA MENU";
                int choice;
                MainMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {

                    case 1:
                        int insideChoice;
                        AddVehicleMenu();
                        insideChoice = Convert.ToInt32(Console.ReadLine());
                        switch (insideChoice)
                        {
                            case 1:
                                CarToAdd();
                                break;
                            case 2:
                                Console.WriteLine("Henüz motorsiklet ekleme seçeneğimiz yoktur,başa dönüyorsunuz.");
                                Thread.Sleep(1250);
                                break;
                            default:
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Taşıt silme yapım aşamasındadır.");
                        Thread.Sleep(1250);

                        break;
                    case 3:
                        Console.WriteLine("Taşıt güncelleme yapım aşamasındadır.");
                        Thread.Sleep(1250);
                        break;
                    case 4:
                        int i = 1;
                        foreach (var car in carManager.GetAll())
                        {
                            Console.WriteLine("{0}.Araç:{1} , Açıklaması: {2}", i, car.Id, car.Description);
                            i++;
                        }


                        Thread.Sleep(2500);
                        break;

                    default:
                        break;
                }

                void MainMenu()
                {
                    Console.WriteLine("╔═════════════════════" + title + "═════════════════════╗");
                    Console.WriteLine("    1-)Taşıt Ekle\n" +
                        "    2-)Taşıt Sil \n" +
                        "    3-)Taşıt Güncelle\n" +
                        "    4-)Taşıtları Listele ");
                    Console.WriteLine("╚══════════════════════════════════════════════════╝");
                    Console.WriteLine("Seçiminizi giriniz :");

                }
                void AddVehicleMenu()
                {


                    title = "Araç Ekleme Menüsü";
                    Console.WriteLine("╔════════════════════" + title + "═══════════════════╗");
                    Console.WriteLine("    1-)Otomobil\n" +
                        "    2-)Motorsiklet");
                    Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
                    Console.WriteLine("Seçiminizi giriniz :");


                }

                void CarToAdd()
                {
                    Car carToAdd = new Car();
                    Console.WriteLine("Araç Id'sini giriniz:");
                    carToAdd.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Araç Marka Id'sini giriniz:");
                    carToAdd.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Araç Renk Id'sini giriniz:");
                    carToAdd.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Araç Model Yılını giriniz:");
                    carToAdd.ModelYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Araç günlük kiralama fiyatını giriniz:");
                    carToAdd.DailyPrice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Araç açıklamasını giriniz:");
                    carToAdd.Description = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hangi Veri Tabanı?\n");
                    Console.WriteLine("Seçenekler: 1)Memory 2)Entity Framework ");
                    int db = Convert.ToInt32(Console.ReadLine());
                    switch (db)
                    {
                        case 1:

                            inMemoryCarDal.Add(carToAdd);

                            Thread.Sleep(1250);
                            break;
                        case 2:
                            Console.WriteLine("Henüz Entity Framework desteğimiz yoktur.");
                            Thread.Sleep(1250);
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim yaptınız,başa dönüyorsunuz.");
                            Thread.Sleep(1250);
                            break;
                    }



                }
            }
            while (true);
        }
    }
}

