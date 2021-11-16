Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.StokAdedi = 19;

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 14;

Product[] urunler = new Product[] {urun1,urun2};

foreach (Product urun in urunler)
{
    Console.WriteLine(urun.Adi+" "+urun.Fiyati+" "+urun.Aciklama+" "+urun.StokAdedi);
}
SepetManager sepetManager = new SepetManager();

sepetManager.Ekle(urun1);
class Product 
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public double Fiyati { get; set; }
    public string Aciklama { get; set; }
    public int StokAdedi { get; set; }
}
class SepetManager
{
    public void Ekle(Product urun)
    {
        Console.WriteLine("Sepete Eklendi:  "+urun.Adi);
    }
}