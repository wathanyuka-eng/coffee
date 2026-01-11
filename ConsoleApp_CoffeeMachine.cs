using System;

namespace ConsoleApp_VendingMachine
{
    public class VendingMachine
    {
        //ตัวแปรเก็บวัตถุดิบ
        private int water, coffee, chocolate, milk;

        //Constructor ตั้งค่าเริ่มต้น
        public VendingMachine(int w, int c, int ch, int m)
        {
            this.water = w;
            this.coffee = c;
            this.chocolate = ch;
            this.milk = m;
        }

        //สำหรับชงเครื่องดื่มและตรวจสอบวัตถุดิบ
        public void MakeDrink(string name, int reqW, int reqC, int reqCh, int reqM)
        {
            // ตรวจสอบว่าวัตถุดิบทุกอย่างพอหรือไม่
            if (this.water >= reqW && this.coffee >= reqC && this.chocolate >= reqCh && this.milk >= reqM)
            {
                this.water -= reqW;
                this.coffee -= reqC;
                this.chocolate -= reqCh;
                this.milk -= reqM;
                Console.WriteLine($"\n000000 กำลังชง: {name} 000000");
                Console.WriteLine("000000 เสร็จเรียบร้อย เชิญรับเครื่องดื่มเลยยย 000000");
            }
            else
            {
                Console.WriteLine($"\n!!ขอโทดเด้อ วัตถุดิบสำหรับ {name} บ่พอ!!");
            }
        }

        // แสดงจำนวนวัตถุดิบที่เหลือ
        public void ShowStock()
        {
            Console.WriteLine("\nจำนวนวัตถุดิบคงเหลือ");
            Console.WriteLine($"น้ำ: {water}g | กาแฟ: {coffee}g | ช็อกโกแลต: {chocolate}g | นม: {milk}g");
            Console.WriteLine("**********************************");
        }

        //เติมวัตถุดิบ
        public void IncreaseStock(int w, int c, int ch, int m)
        {
            this.water += w;
            this.coffee += c;
            this.chocolate += ch;
            this.milk += m;
            Console.WriteLine("\nเติมวัตถุดิบเรียบร้อย");
        }
    }
}
