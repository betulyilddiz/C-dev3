/*
//Soru 1 - Foreach Döngüsü ile Liste Elemanlarını Yazdırma
//Bir ArrayList oluşturun ve içerisine birkaç tamsayı ekleyin.
//foreach döngüsü kullanarak listedeki her bir sayıyı ekrana yazdıran bir program yazınız.
//Döngü tamamlandığında sayıların toplamını da ekrana yazdırınız.

using System.Collections;

ArrayList sayilar = new ArrayList();

sayilar.Add(3);
sayilar.Add(5);
sayilar.Add(-2);
sayilar.Add(1);
sayilar.Add(-9);

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);

}

int toplam = 0;
foreach (int sayi in sayilar)
{
    toplam += sayi;
  
}
Console.WriteLine("Toplam: " + toplam);
*/



/*
//Soru 2 - Hazır Metod Kullanımı 
//Kullanıcıdan bir cümle girmesini isteyin ve bu cümledeki kelime sayısını hesaplayıp ekrana yazdıran bir program yazınız.
//Kelime sayısını hesaplamak için Split() metodunu kullanabilirsiniz.

Console.Write("Bir cümle girin: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');

Console.WriteLine("Cümledeki kelime sayısı: " + kelimeler.Length);
*/




/*
//Soru 3 - ArrayList ile Alfabetik Sıralama 
//Kullanıcıdan 5 adet isim alarak bir ArrayList içinde saklayın.
//Daha sonra bu isimleri alfabetik olarak sıralayarak ekrana yazdırın. (Not: ArrayList.Sort() metodunu kullanabilirsiniz.)

using System.Collections;

ArrayList isimler = new ArrayList();   

Console.WriteLine("Lütfen 5 tane isim  girin: ");

for (int i = 0; i<5; i++)
{
    Console.WriteLine("İsim girin: ");
    string isim = Console.ReadLine();   
    isimler.Add(isim);

}
isimler.Sort();
Console.WriteLine("Alfabeye göre sıralanmış isimler: ");

foreach (string isim in isimler)
{
    Console.WriteLine(isim);
}
*/



/*
//Soru 4 - For Döngüsü ile Fibonacci Serisi 
//Kullanıcıdan bir sayı girmesini isteyin.
//Bu sayı kadar Fibonacci serisindeki sayıları hesaplayıp ekrana yazdıran bir program yazınız.
//for döngüsü kullanarak seriyi oluşturun.
//Örnek: Eğer kullanıcı 5 girerse, ekranda "0 1 1 2 3" yazmalıdır.

Console.WriteLine("Sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
int c;
Console.Write("Fibonacci serisi: ");
for (int i = 0; i<sayi; i++)
{
    Console.Write(a + " ");
    c = a + b;
    a = b;
    b = c;
}
*/



/*

//Soru 5 - While Döngüsü ile Tahmin Oyunu 
//Kullanıcıdan bir sayı tahmin etmesini isteyen bir program yazınız.
//Program, doğru tahmin yapılana kadar kullanıcıdan yeni tahminler almaya devam etmelidir.
//Doğru tahmin yapıldığında ekrana bir tebrik mesajı yazdırılmalıdır.
//Not: Sabit bir sayı belirleyebilir veya Random sınıfı ile rastgele bir sayı oluşturabilirsiniz.


int dogru_sayi = 8;
int tahmin;
Console.WriteLine("Doğru sayıyı tahmin edin: ");
tahmin = Convert.ToInt32(Console.ReadLine());

while (tahmin != dogru_sayi)
{
    if (tahmin != dogru_sayi)
    {
        Console.WriteLine("Yanlış tahmin.. Yeniden tahmin edin: ");
        tahmin = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Tebrikler..Doğru tahmin!");
*/



/*
//Soru 6 - Do While Döngüsü ile Basit Hesap Makinesi
//Kullanıcıdan işlem türünü (+, -, *, /) ve iki sayı alarak işlemi gerçekleştiren bir program yazınız.
//Kullanıcı "çıkış" yazana kadar işlemleri tekrarlayan bir do while döngüsü kurunuz.
//Ekstra: Bölme işlemi sırasında sıfıra bölme hatasını kontrol ediniz
do
{
    Console.WriteLine("İşlem türü seçin(+, -, *, /) ya da çıkmak için 'çıkış'yazın: ");
    string islem = Console.ReadLine();

    if (islem == "çıkış")
    {
        break;
    }
    else
    {
        Console.Write("1. sayı: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sayı: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        switch (islem)
        {
            case "+":
                Console.WriteLine("Toplama işleminin sonucu: " + (sayi1 + sayi2));
                break;
            case "-":
                Console.WriteLine("Çıkarma işleminin sonucu:: " + (sayi1 - sayi2));
                break;
            case "*":
                Console.WriteLine("Çarpma işleminin sonucu:: " + (sayi1 * sayi2));
                break;
            case "/":
                if (sayi2 != 0)
                {
                    Console.WriteLine("Bölme işleminin sonucu: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez!");
                }
                break;
            default:
                Console.WriteLine("Lütfen geçerli bir işlem türü girin.. ");
                break;
        }

    }




}
while (true);
*/



/*
//Soru 7 - For ve While Döngüsü ile Sayı Toplama Oyunu 
//Kullanıcıdan pozitif tam sayılar girmesini isteyen bir program yazınız.
//Kullanıcı "0" girdiğinde girişi sonlandırın ve girilen pozitif sayıların toplamını bir while döngüsü kullanarak hesaplayın.
//Toplamı bulduktan sonra tüm pozitif sayıları tek tek ekrana yazdırmak için bir for döngüsü kullanınız.


int toplam = 0;
List<int> sayilar = new List<int>();


Console.WriteLine("Pozitif tam sayılar girin: ");

while (true)
{
    Console.Write("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi == 0)
    {
        break;
    }

    else if (sayi < 0)
    {
        Console.WriteLine("Lütfen pozitif bir sayı girin..");
    }
    else {
        toplam += sayi;
        sayilar.Add(sayi);
    }
 }

Console.WriteLine("Girilen pozitif tam sayıların toplamı: " + toplam);
Console.WriteLine("Girilen pozitif tam sayılar: ");
for (int i = 0; i<sayilar.Count ; i++)
{
    Console.WriteLine(sayilar[i]);
}
*/












