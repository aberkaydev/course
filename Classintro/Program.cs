Product yeniUrun1 = new Product();
yeniUrun1.UrunAdi = "Monster Abra A5 Oyun Bilgisayarı";
yeniUrun1.UrunTanitimi = "F/P Oyun Bilgisayarı";
yeniUrun1.UrunFiyati = 4500;

Product yeniUrun2 = new Product();
yeniUrun2.UrunAdi = "Oynar başlıklı tıraş makinesi";
yeniUrun2.UrunTanitimi = "F/P tıraş makinesi";
yeniUrun2.UrunFiyati = 250;


Product yeniUrun3 = new Product();
yeniUrun3.UrunAdi = "Dijital baskül";
yeniUrun3.UrunTanitimi = "F/P dijital baskül";
yeniUrun3.UrunFiyati = 50;

Product[] urunler = new Product[] {yeniUrun1,yeniUrun2,yeniUrun3 };

foreach (Product urun in urunler)
{
    Console.WriteLine(urun.UrunAdi+":"+urun.UrunTanitimi+":"+urun.UrunFiyati);

}





class Product
{
    public string UrunAdi { get; set; }
    public string UrunTanitimi { get; set; }
    public int UrunFiyati { get; set; }
}