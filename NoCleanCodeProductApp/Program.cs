using System;
using System.Collections.Generic;

class Program
{
    static List<string[]> productList = new List<string[]>();
    static string input, id, name, category;
    static bool exitFlag = false;

    static void Main(string[] args)
    {
        while (!exitFlag)
        {
            Console.WriteLine("1-ürün Ekle, 2-Ürün Listele, 3-Ürün Sil, 4-Güncelle, 5-Çıkış");
            input = Console.ReadLine();
            if (input == "1")
            {
                AddProduct();
            }
            else if (input == "2")
            {
                ListProducts();
            }
            else if (input == "3")
            {
                DelProduct();
            }
            else if (input == "4")
            {
                UpdProduct();
            }
            else if (input == "5")
            {
                exitFlag = true;
                Console.WriteLine("Çıkış");
            }
            else
            {
                Console.WriteLine("Geçersiz");
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("ID: "); id = Console.ReadLine();
        for (int i = 0; i < productList.Count; i++)
        {
            if (productList[i][0] == id)
            {
                Console.WriteLine("ID var");
                return;
            }
        }
        Console.Write("İsim: "); name = Console.ReadLine();
        Console.Write("Kategori: "); category = Console.ReadLine();
        productList.Add(new string[] { id, name, category });
        Console.WriteLine("Ürün ekle");
    }

    static void ListProducts()
    {
        if (productList.Count == 0) { Console.WriteLine("Ürün Yok"); }
        else
        {
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"ID: {productList[i][0]}, İsim: {productList[i][1]}, Kategori: {productList[i][2]}");
            }
        }
    }

    static void DelProduct()
    {
        Console.Write("ID: "); id = Console.ReadLine();
        int i = 0;
        while (i < productList.Count)
        {
            if (productList[i][0] == id)
            {
                productList.RemoveAt(i);
                Console.WriteLine("Silindi");
                return;
            }
            i++;
        }
        Console.WriteLine("Bulunamadı");
    }

    static void UpdProduct()
    {
        Console.Write("ID: "); id = Console.ReadLine();
        int i = 0;
        bool found = false;
        while (i < productList.Count)
        {
            if (productList[i][0] == id)
            {
                Console.Write("Yeni İsim: "); name = Console.ReadLine();
                Console.Write("Yeni Kategori: "); category = Console.ReadLine();
                productList[i] = new string[] { id, name, category };
                found = true;
                Console.WriteLine("Güncellendi");
                break;
            }
            i++;
        }
        if (!found) { Console.WriteLine("Bulunamadı"); }
    }
}
