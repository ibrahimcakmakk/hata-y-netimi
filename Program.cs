using System;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("girmiş olduğunuz sayı : " + sayi);
        }
        catch (Exception ex)
        {

            Console.WriteLine("hata: " + ex.Message.ToString());
        }
        finally
        {
            Console.Write("işlem tamamlandı");

        }

        try
        {
            int a = int.Parse("null");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("boş değer girdiniz");

        }
        catch (FormatException ex)
        {
            Console.WriteLine("veri tipi uygun değil");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("çok büyük veya çok küçük sayı girdiniz");
        }
        finally
        {
            Console.WriteLine("işlem başarılı");
        }
    }
}