class Program
{
    static void Main(string[] args)
    {
        Product urun1 = new Product();              //2. bu kısımda yazdığımız sınıfa verileri ekliyoruz.
        urun1.urunFiyat = 15;
        urun1.urunTuru = "Elektronik";
        urun1.urunIsmi = "16GB Flash Disk";
        Product urun2 = new Product();
        urun2.urunFiyat = 3000;
        urun2.urunTuru = "Beyaz Eşya";
        urun2.urunIsmi = "Bulaşık Makinesi";
        Product urun3 = new Product();
        urun3.urunFiyat = 250;
        urun3.urunTuru = "Aparatif ürünler";
        urun3.urunIsmi = "termos";

        Product[] urunler = new Product[] { urun1, urun2, urun3 };     //3. burada sınıftaki verileri bir diziye tanımlıyoruz
        for (int i = 0; i < urunler.Length; i++)
        {
            System.Console.WriteLine(urunler[i].urunIsmi);
        }
        int a = 0;                                                                                //4. bu kısımda dizideki verileri döngülerle yazdırıyoruz
        while (a < urunler.Length)
        {


            System.Console.WriteLine(urunler[a].urunIsmi);
            a++;
        }
        foreach (var product in urunler)
        {
            System.Console.WriteLine(product.urunIsmi + " " + product.urunFiyat);
        }





    }
}
class Product       //1. buradan sınıf tanımlayarak başlıyoruz
{
    public int urunFiyat { get; set; }
    public string urunIsmi { get; set; }
    public string urunTuru { get; set; }


}
