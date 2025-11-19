using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("โปรแกรมตรวจอุณหภูมิร่างกาย");
        Console.Write("ป้อนอุณหภูมิ (°C) : ");

        string input = Console.ReadLine();

        // พยายามแปลงเป็นตัวเลข (รองรับจุดทศนิยม)
        if (!double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double temp))
        {
            // ถ้าแปลงไม่ผ่าน ให้ลองแปลงโดยใช้ culture ปัจจุบัน (รองรับเครื่องหมายคอมม่า)
            if (!double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out temp))
            {
                Console.WriteLine("รูปแบบค่าไม่ถูกต้อง กรุณาป้อนตัวเลข เช่น 36.5 หรือ 37.8");
                return;
            }
        }

        // ตรวจเงื่อนไข > 37.5
        if (temp > 37.5)
        {
            Console.WriteLine($"อุณหภูมิ {temp}°C : มากกว่า 37.5 → แสดงว่า: มีไข้ (หรือผิดปกติ)");
        }
        else
        {
            Console.WriteLine($"อุณหภูมิ {temp}°C : ไม่เกิน 37.5 → แสดงว่า: ปกติ");
        }
    }
}

