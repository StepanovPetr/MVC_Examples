using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.IO;

namespace _3_FileDownload.Controllers
{
    public class FileExampleController : Controller
    {
        // GET: FileExample
        public ActionResult Index()
        {
            return View();
        }

        //Скачивание файла по пути 
        public ActionResult Download1()
        {
            return File("/Download/1.mp3", "audio/*", "1.mp3");
        }

        //Скачивание массива байт
        public ActionResult Download2()
        {
            //Переменная содержашая путь к файлы 
            string pathToOpen;
            if (Server != null)
            {
                pathToOpen = Server.MapPath("/Download/1.mp3");
            }
            else
            {
                pathToOpen = System.Reflection.Assembly.GetAssembly(typeof(FileExampleController)).Location;
                pathToOpen = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(pathToOpen)).ToString()).ToString()).ToString();
                pathToOpen += "\\3)FileDownload\\Download\\1.mp3";
            }
         

            // массив байт
            byte[] data;
            // Заполнение массива байт данными из файла 
            data = System.IO.File.ReadAllBytes(pathToOpen);
            return File(data, "audio/*", "1.mp3");
        }

        // Создание файла из потока
        public ActionResult Download3()
        {
            //Переменная содержашая путь к файлы 
            string pathToOpen;

            if (Server != null)
            {
                pathToOpen = Server.MapPath("/Download/1.mp3");
            }
            else
            {
                pathToOpen = System.Reflection.Assembly.GetAssembly(typeof(FileExampleController)).Location;
                pathToOpen = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(pathToOpen)).ToString()).ToString()).ToString();
                pathToOpen += "\\3)FileDownload\\Download\\1.mp3";
            }

            // создание потока streamForDownload и открытие файла /Download/1.mp3 на чтение 
            FileStream streamForDownload = new FileStream(pathToOpen,FileMode.Open);

            // Поток и MIME
            return File(streamForDownload, "audio/*", "1.mp3");
        }

        public ActionResult DownloadFileByName(string fileName)
        {
            //Переменная содержашая путь к файлы 
            string pathToOpen;
            if (Server != null)
            {
                pathToOpen = Server.MapPath(string.Format("/Download/{0}",fileName));
            }
            else
            {
                pathToOpen = System.Reflection.Assembly.GetAssembly(typeof(FileExampleController)).Location;
                pathToOpen = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(pathToOpen)).ToString()).ToString()).ToString();
                pathToOpen += string.Format("\\3)FileDownload\\Download\\{0}", fileName);
            }


            // массив байт
            byte[] data;
            if (System.IO.File.Exists(pathToOpen))
            {
                // Заполнение массива байт данными из файла 
                data = System.IO.File.ReadAllBytes(pathToOpen);
                return File(data, "audio/*", fileName);
            }
            else
            {
                return Content("File not found");
            }
        }

    }
}