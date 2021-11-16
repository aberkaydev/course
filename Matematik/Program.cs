DortIslem dortIslem = new DortIslem();

dortIslem.Topla(9, 3);
dortIslem.Cikar(9, 3);
dortIslem.Carp(9, 3);
dortIslem.Bol(9, 3);
class DortIslem
{
    public void Topla(int sayi1, int sayi2)
    {
        int toplam = sayi1 + sayi2;
        Console.WriteLine(toplam);
    }

    public void Cikar(int sayi1, int sayi2)
    {
        int sonuc = sayi1 - sayi2;
        Console.WriteLine(sonuc);
    }

    public void Carp(int sayi1, int sayi2)
    {
        int sonuc = sayi1 * sayi2;
        Console.WriteLine(sonuc);
    }

    public void Bol(int sayi1, int sayi2)
    {
        int sonuc = sayi1 / sayi2;
        Console.WriteLine(sonuc);
    }
}