using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        //TASK-1

        //int[] numbers = { 1, 2, 3, 4 };
        //Console.WriteLine("ilk array: ");

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i] + " ");
        //}

        //Console.WriteLine();

        //Console.WriteLine("2-ci array");
        //InsertArray(ref numbers, 5, 6, 7, 8);
        //for (int i = 0;i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i] + " ");
        //}        

        //TASK-2 (SEARCH VE KOMEKLIK YAZDIM AMMA BASHA DUSHUB YAZDIM.)
        //while (true)
        //{
        //    Console.WriteLine("\nATM:");
        //    Console.WriteLine("1 - Balansı göster");
        //    Console.WriteLine("2 - Pul çıxar");
        //    Console.WriteLine("0 - Çıxış");

        //    Console.Write("Emeliyyatı seçin: ");
        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            ShowBalance();
        //            break;
        //        case "2":
        //            Console.Write("Çıxarmaq istədiyiniz məbləği daxil edin: ");
        //            double withdrawAmount;
        //            if (double.TryParse(Console.ReadLine(), out withdrawAmount))
        //            {
        //                Withdraw(withdrawAmount);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Düzgün bir mebleğ daxil edin.");
        //            }
        //            break;
        //        case "0":
        //            Console.WriteLine("Çıxıldi");
        //            return;
        //        default:
        //            Console.WriteLine("Yanlış seçim. Yenidən seçin.");
        //            break;
        //    }
        //}
    }

    //TASK-1
    //public static int[] InsertArray(ref int[] num, params int[] nums)
    //{
    //    int newLength = num.Length + nums.Length;
    //    int[] newArray= new int[newLength];

    //    for (int i = 0; i < num.Length; i++)
    //    {
    //        newArray[i] = num[i];
    //    }

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        newArray[num.Length+i] = nums[i];
    //    }

    //    num= newArray;
    //    return newArray;
    //}

    //TASK-2
    //static double balance = 4000;

    //public static void ShowBalance()
    //{
    //    Console.WriteLine("Balansınız: " + balance + "-AZN");
    //}

    //public static void Withdraw(double amount)
    //{
    //    if (amount <= 0)
    //    {
    //        Console.WriteLine("Sıfırdan böyük məbləği daxil edin.");
    //    }
    //    else if (amount > balance)
    //    {
    //        Console.WriteLine("Balansınızda kifayət qədər pul yoxdur.");
    //    }
    //    else
    //    {
    //        balance -= amount;
    //        Console.WriteLine(amount + "AZN çıxarıldı. Yeni balans:" + balance + "AZN");
    //    }
    //}
}