using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan usia Anda: ");
        int usia = Convert.ToInt32(Console.ReadLine());

        string status;

        if (usia >= 0 && usia <= 5)
        {
            status = "Balita";
        }
        else if (usia >= 6 && usia <= 12)
        {
            status = "Anak-anak";
        }
        else if (usia >= 13 && usia <= 17)
        {
            status = "Remaja";
        }
        else if (usia >= 18 && usia <= 59)
        {
            status = "Dewasa";
        }
        else if (usia >= 60)
        {
            status = "Lansia";
        }
        else
        {
            status = "Usia tidak valid";
        }

        Console.WriteLine($"Status usia Anda: {status}");
    }
}