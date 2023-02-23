using App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Net;
using System.Net.Mail;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string subject, string message)
        {

            message = $"İsim:{name}\r\n\r\nE-Posta:{email}\r\n\r\n{message}";
            MailMessage msg = new MailMessage(); //Mesaj gövdesini tanımlıyoruz...
            msg.Subject = subject;
            msg.From = new MailAddress("info@emekmak.com", "Emek Makina Site İletişim");
            msg.To.Add(new MailAddress("info@emekmak.com", "Emek Makina"));

            //Mesaj içeriğinde HTML karakterler yer alıyor ise aşağıdaki alan TRUE olarak gönderilmeli ki HTML olarak yorumlansın. Yoksa düz yazı olarak gönderilir...
            msg.IsBodyHtml = true;
            msg.Body = message;

            //SMTP/Gönderici bilgilerinin yer aldığı erişim/doğrulama bilgileri
            SmtpClient smtp = new SmtpClient("mail.kurumsaleposta.com", 587); //Bu alanda gönderim yapacak hizmetin smtp adresini ve size verilen portu girmelisiniz.
            NetworkCredential AccountInfo = new NetworkCredential("info@emekmak.com", "CNgz34346060!?");
            smtp.UseDefaultCredentials = false; //Standart doğrulama kullanılsın mı? -> Yalnızca gönderici özellikle istiyor ise TRUE işaretlenir.
            smtp.Credentials = AccountInfo;
            smtp.EnableSsl = false; //SSL kullanılarak mı gönderilsin...
            try
            {
                smtp.Send(msg);
                //Console.WriteLine("E-Posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(string.Format("Gönderim Hatası: {0}", ex.Message));
            }

            return View();
        }
        public IActionResult Category(int id)
        {
            Category category;
            switch (id)
            {
                case 1:
                    category = new Category
                    {
                        Id = 1,
                        Name = "FORKLİFTLER",
                        Products = new List<Product>
                        {
                            new Product()
                            {
                                Id = 1,
                                Name = "G series 1",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 1",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 2,
                                Name = "G series 2",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 2",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 3,
                                Name = "G series 3",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 3",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 4,
                                Name = "G series 4",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 4",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            }
                        }
                    };
                    break;
                case 2:
                    category = new Category
                    {
                        Id = 2,
                        Name = "TRANSPALETLER",
                        Products = new List<Product>
                        {
                            new Product()
                            {
                                Id = 5,
                                Name = "G series 5",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 5",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 6,
                                Name = "G series 6",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 6",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 7,
                                Name = "G series 7",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 7",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 8,
                                Name = "G series 8",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 8",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            }
                        }
                    };
                    break;
                case 3:
                    category = new Category
                    {
                        Id = 3,
                        Name = "İSTİF MAKİNALARI",
                        Products = new List<Product>
                        {
                            new Product()
                            {
                                Id = 9,
                                Name = "G series 9",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 9",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 10,
                                Name = "G series 10",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 10",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 11,
                                Name = "G series 11",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 11",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 12,
                                Name = "G series 12",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 12",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 13,
                                Name = "G series 13",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 13",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 14,
                                Name = "G series 14",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 14",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 15,
                                Name = "G series 15",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 15",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            },
                            new Product()
                            {
                                Id = 16,
                                Name = "G series 16",
                                Description = "En son teknik tasarımla üretilen bu yeni seri forkliftler, size mükemmel çalışma performansı sağlar. HELI forklift 16",
                                ImagePath1 = "category_product_1.png",
                                ImagePath2 = "category_product_2.png"
                            }
                        }
                    };
                    break;
                default:
                    category = new Category();
                    break;
            }

            return View(category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}