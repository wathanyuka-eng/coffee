using System;

namespace ConsoleApp_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //แก้ตัวโค้ดไม่อ่านภาษาไทย
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //สร้าง Object เเละกำหนดวัตถุดิบเริ่มต้น
            VendingMachine machine = new VendingMachine(1000, 200, 100, 100);
            string input = "";

            //ทำซ้ำจนกว่าจะกด 0
            while (input != "0")
            {
                Console.WriteLine("\n****เมนูเครื่องชงกาแฟ****");
                Console.WriteLine("1: กาแฟดำ(น้ำ300g, กาแฟ20g)");
                Console.WriteLine("2: มอคค่า(น้ำ300g,กาแฟ20g, ช็อกโกแลต10g)");
                Console.WriteLine("3: ลาเต้(น้ำ300g, กาแฟ20g, นม10g)");
                Console.WriteLine("4: ช็อกโกแลต (น้ำ300g, ช็อกโกแลต20g)");
                Console.WriteLine("5: ดูสต็อกสินค้า");
                Console.WriteLine("6: เติมวัตถุดิบ");
                Console.WriteLine("0: ออกจากโปรแกรม");
                Console.WriteLine("*************************************");
                Console.Write("เลือกเมนูที่ต้องการ: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        machine.MakeDrink("กาแฟดำ", 300, 20, 0, 0);
                        break;
                    case "2":
                        machine.MakeDrink("มอคค่า", 300, 20, 10, 0);
                        break;
                    case "3":
                        machine.MakeDrink("ลาเต้", 300, 20, 0, 10);
                        break;
                    case "4":
                        machine.MakeDrink("ช็อกโกแลต", 300, 0, 20, 0);
                        break;
                    case "5":
                        machine.ShowStock();
                        break;
                    case "6":
                        machine.IncreaseStock(500, 100, 100, 100);
                        break;
                    case "0":
                        Console.WriteLine("ไม่ต้องการสั่งต่อเเล้วใช่ไหม?? ok ขอบคุณครับ");
                        break;
                    default:
                        Console.WriteLine("เลือกเมนูไม่ถูกต้อง ลองใหม่");
                        break;
                }
            }
        }
    }
}