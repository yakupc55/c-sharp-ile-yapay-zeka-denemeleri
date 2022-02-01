using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapayzekadenemeleri1
{
    class siniflarSerisi
    {
    }

    class iris
    {
        public  double sepalLength;
        public double sepalWidth;
        public double petalLength;
        public double petalWidth;
        public int type;

        public iris(double sl, double sw, double pl, double pw, int t)
        {
            sepalLength = sl;
            sepalWidth = sw;
            petalLength = pl;
            petalWidth = pw;
            type = t;
        }// tanımlayıcı sonu
    }// sınıf sonu
    class yapaySinirAgi
    {
      
      public int yolSayisi = 0;
      public int girdiSayisi = 0;
      public int ciktiSayisi = 0;
      public int noronSayisi = 0;
      public int snapsisSayisi = 0;
      public double sonAralik = 1;
      public double yaklasimOrani = 3.0;
      public double normalOran = 0.1;
      public List<yol> yollar = new List<yol>();
      public List<double[]> egitim = new List<double[]>();
      public List<double[]> test = new List<double[]>();
      private Random rnd = new Random();

        private double yaklasimDegeri = 0.0;
        private double duzlenecekDeger = 0.0;
        private double duzlemeOrani = 0.0;
        private bool artirma = true;
        public int dogruSayisi;
        public int yanlisSayisi;
        public int yuksekYanilgiSayisi;
        public yapaySinirAgi(int girdi,int cikti)
        {
            girdiSayisi = girdi;
            ciktiSayisi = cikti;
            yolSayisi = girdi +1;

            agiOlustur();
        }//sınıf sonu

        public void agiOlustur()
        {
            //başlamadan önce yollar listesini boşaltıyoruz.
            yollar.Clear();
            // ilk yol için
            ilkYol();
            araYol();
            sonYol();
        }// fonksiyon sonu

        private void ilkYol()
        {
            yollar.Add(new yol());

            for (int i = 0; i < girdiSayisi*2; i++)
            {
                noronEkle(0,i,girdiSayisi);
            }// for sonu

            Console.WriteLine("ilk yol oluşturuldu");
        }// fonksiyon sonu

        private void araYol()
        {
            for (int yolNo = 1; yolNo <girdiSayisi; yolNo++)
            {
                yollar.Add(new yol());
                for (int i = 0; i < girdiSayisi*2; i++)
                {
                    noronEkle(yolNo,i,girdiSayisi*2);
                }// iç for sonu
            }// for sonu

         //   Console.WriteLine("ilk arayollar oluşturuldu");
        }// fonksiyon sonu

        private void sonYol()
        {
            yollar.Add(new yol());

            for (int i = 0; i < ciktiSayisi; i++)
            {
                // index numarasına göre girdi sayısı son indexi veriyor
                noronEkle(girdiSayisi, i, girdiSayisi*2);
            }// for sonu
         //   Console.WriteLine("son yol oluşturuldu");
         //   Console.WriteLine("son yol uzunluğu : '"+ciktiSayisi+"'");
        }// fonksiyon sonu

        private void noronEkle(int yolNo,int noronNo,int snapsisSayisi)
        {
            yollar[yolNo].noronlar.Add(new noron());

            for (int j = 0; j < snapsisSayisi; j++)
            {
                double farkOrani = sbs.basitAgRastgeleSnapsisMax - sbs.basitAgRastgeleSnapsisMin; 
                double sonuc = sbs.basitAgRastgeleSnapsisMin+ (rnd.NextDouble()*farkOrani);
                yollar[yolNo].noronlar[noronNo].snapsis.Add(sonuc);
            }// iç for sonu
        }// fonksiyon sonu

        public void ilkDuzen()
        {
            ilkYolOnHesaplama(egitim[0]);
            araYollarOnHesaplama();
            snapsisHesapla();
        }// fonksiyon sonu

        public void tumAgiEgit() 
        {
            for (int i = 1; i < egitim.Count; i++)
            {
                ilkYolOnHesaplama(egitim[i]);
                araYollarOnHesaplama();
                snapsisHesapla();
            }// fonksiyon sonu
            Console.WriteLine("tüm ağ başarıyla eğitildi.");
        }// fonksiyon sonu

        public void tumAgiEgitaa2()
        {
            for (int i = 1; i < egitim.Count; i++)
            {
                ilkYolOnHesaplama(egitim[i]);
                araYollarOnHesaplama();
                snapsisHesaplaAa2(egitim[i]);
            }// fonksiyon sonu
        }// fonksiyon sonu
        private void ilkYolOnHesaplama(double []liste)
        {
            //ilk yolun hesaplanması
            Console.WriteLine("ilk uzunluk : '" + yollar[0].noronlar.Count + "'");
            int uzunluk = yollar[0].noronlar.Count;
            double toplayici;
            noron nr;
            for (int noronNo = 0; noronNo < uzunluk; noronNo++)
            {
                nr = yollar[0].noronlar[noronNo];
                toplayici = 0;
                for (int i = 0; i < girdiSayisi; i++)
                {
                    toplayici += (nr.snapsis[i] * liste[i]);
                //    Console.WriteLine(i + ". snapsis değeri : '" + nr.snapsis[i] + "' egitim degeri : '" + liste[i]);
                //    Console.WriteLine("toplayici degeri : '" + toplayici);
                }// girdi sonu
                nr.deger = toplayici;
                yollar[0].noronlar[noronNo].deger = toplayici;
                Console.WriteLine(noronNo + ". noron degeri : '" + toplayici + "'");
            }// noron foru sonu
        }// fonksiyon sonu

        private void araYollarOnHesaplama()
        {
            for (int yolNo = 1; yolNo < girdiSayisi+1; yolNo++)
            {
                noronOnHesaplama(yollar[yolNo], yollar[yolNo - 1]);
            }// for sonu
        }// fonksiyon sonu

        private void noronOnHesaplama(yol yolumuz,yol onceki)
        {
            //ilk yolun hesaplanması
            Console.WriteLine("ilk uzunluk : '" + yolumuz.noronlar.Count + "'");
            int uzunluk = yolumuz.noronlar.Count;
            double toplayici;
            noron nr;
            for (int noronNo = 0; noronNo < uzunluk; noronNo++)
            {
                nr = yolumuz.noronlar[noronNo];
                toplayici = 0;
                for (int i = 0; i < onceki.noronlar.Count; i++)
                {
                    toplayici += (nr.snapsis[i] * onceki.noronlar[i].deger);
                //    Console.WriteLine(i + ". snapsis değeri : '" + nr.snapsis[i] + "' egitim degeri : '" + onceki.noronlar[i].deger);
                ///    Console.WriteLine("toplayici degeri : '" + toplayici);
                }// girdi sonu
                nr.deger = toplayici;
                yolumuz.noronlar[noronNo].deger = toplayici;
              //  Console.WriteLine(noronNo + ". noron degeri : '" + toplayici + "'");
            }// noron foru sonu
        }// fonksiyon sonu

        private void snapsisHesapla()
        {
            noronVerisiHesapla(egitim[0][4], yollar[yolSayisi - 1].noronlar[0].deger);
            for (int i = 0; i < yollar.Count; i++)
            {
                Console.WriteLine(i+". yol");
                for (int j = 0; j <yollar[i].noronlar.Count; j++)
                {
                    Console.WriteLine(j + ". noron");
                    snapsisVerisiHesapla(yollar[i].noronlar[j]);
                }// noron foru sonu
                
            }// yol foru sonu
           
        }// fonksiyon sonu

        private void snapsisHesaplaAa2(double [] liste)
        {
            noronVerisiHesapla(egitim[0][4], yollar[yolSayisi - 1].noronlar[0].deger);
            for (int i = 1; i < yollar.Count; i++)
            {
                Console.WriteLine(i + ". yol");
                for (int j = 0; j < yollar[i].noronlar.Count; j++)
                {
                    Console.WriteLine(j + ". noron");
                    snapsisVerisiHesaplaAa2(yollar[i].noronlar[j],yollar[i-1]);
                }// noron foru sonu

            }// yol foru sonu
            for (int j = 1; j < yollar[0].noronlar.Count; j++)
            {
                Console.WriteLine(j + ". noron");
                snapsisVerisiHesaplaGirdidenAa2(yollar[0].noronlar[j],liste);
            }// noron foru sonu
        }// fonksiyon sonu
        private void sondanGelimSnapsisDuzleme()
        {
            double son = egitim[0][4];
         //   Console.WriteLine("son değer: '"+son+"'");
            double bulunanDeger = yollar[yolSayisi-1].noronlar[0].deger;
            double yaklasimDegeri = son * yaklasimOrani;
          //  Console.WriteLine("yaklaşım değeri: '" + yaklasimDegeri + "'");
            double duzlenecekDeger = 0.0;
            double duzlemeOrani = 0.0;
          //  Console.WriteLine("bulunan değer: '" + bulunanDeger + "'");
         //   Console.WriteLine("çıkarma işlemi sonucu: '" + Math.Abs(bulunanDeger - son) + "'");
            if (Math.Abs(bulunanDeger-son)>yaklasimDegeri)
            {
           //     Console.WriteLine("oran geçildi");
                duzlenecekDeger = (son > bulunanDeger) ? (son - yaklasimDegeri) : (son + yaklasimDegeri);
             //   Console.WriteLine("düzlenecek değer: '" + duzlenecekDeger + "'");
                duzlemeOrani = bulunanDeger / duzlenecekDeger;
             //   Console.WriteLine("düzleme orani: '" + duzlemeOrani + "'");
            }// if sonu
        }// fonksiyon sonu

        private void noronVerisiHesapla(double gelen,double hesapsalDeger)
        {
          //  Console.WriteLine("gelen değer: '" + gelen + "'");
          //  Console.WriteLine("hesapsal değer: '" + hesapsalDeger + "'");
            yaklasimDegeri = gelen * yaklasimOrani;
          //  Console.WriteLine("yaklaşım değeri: '" + yaklasimDegeri + "'");

            // snapsislerde artirmamı çıkartma işlemimi yapılması gerektiği hakkında bilgiyi içerir.
            if (hesapsalDeger > gelen) artirma = true;
            else artirma = false;


           // Console.WriteLine("çıkarma işlemi sonucu: '" + Math.Abs(hesapsalDeger - gelen) + "'");
            if (Math.Abs(hesapsalDeger - gelen) > yaklasimDegeri)
            {
             //   Console.WriteLine("oran geçildi");
                duzlenecekDeger = (gelen > hesapsalDeger) ? (gelen - yaklasimDegeri) : (gelen + yaklasimDegeri);
              //  Console.WriteLine("düzlenecek değer: '" + duzlenecekDeger + "'");
                duzlemeOrani = hesapsalDeger / duzlenecekDeger;
                double eskiOran = duzlemeOrani;
               // Console.WriteLine("düzleme orani: '" + duzlemeOrani + "'");
                // şimdi düzleme oranini yapilara bölüyoruz.
                double karakokDegeri = 1 /yolSayisi;
                hesaplamalar hsp = new hesaplamalar();
                duzlemeOrani = hsp.multiKok(duzlemeOrani,yolSayisi);
                double testDegeri = Math.Pow(duzlemeOrani, yolSayisi);
              //  Console.WriteLine("eski oran: '" + eskiOran + "'");
              //  Console.WriteLine("test degeri: '" + testDegeri + "'");
              //  Console.WriteLine("düzleme orani: '" + duzlemeOrani + "'");
            }// if sonu
            else
            {
                double araFark = Math.Abs(hesapsalDeger - gelen);
                double sayisalDeger = araFark * normalOran;
                oranDuzleme(gelen, hesapsalDeger, sayisalDeger);
            }// else sonu
        }// fonksiyon sonu

        private void oranDuzleme(double gelen, double hesapsalDeger, double yaklasimDegeri)
        {
            duzlenecekDeger = (gelen > hesapsalDeger) ? (gelen - yaklasimDegeri) : (gelen + yaklasimDegeri);
           // Console.WriteLine("düzlenecek değer: '" + duzlenecekDeger + "'");
            duzlemeOrani = hesapsalDeger / duzlenecekDeger;
            double eskiOran = duzlemeOrani;
           // Console.WriteLine("düzleme orani: '" + duzlemeOrani + "'");
            // şimdi düzleme oranini yapilara bölüyoruz.
            double karakokDegeri = 1 / yolSayisi;
            hesaplamalar hsp = new hesaplamalar();
            duzlemeOrani = hsp.multiKok(duzlemeOrani, yolSayisi);
            double testDegeri = Math.Pow(duzlemeOrani, yolSayisi);
          //  Console.WriteLine("eski oran: '" + eskiOran + "'");
           // Console.WriteLine("test degeri: '" + testDegeri + "'");
           // Console.WriteLine("düzleme orani: '" + duzlemeOrani + "'");
        }// fonksiyon sonu 

        private void snapsisVerisiHesapla(noron gelen)
        {
            int snapsisSayisi = gelen.snapsis.Count;
            for (int snap = 0; snap < snapsisSayisi; snap++)
            {
              //  Console.WriteLine("önceki snapsis değeri: '" + gelen.snapsis[snap] + "'");

                if (artirma) gelen.snapsis[snap] /= duzlemeOrani;
                else gelen.snapsis[snap] *= duzlemeOrani;

              //  Console.WriteLine("sonraki snapsis değeri: '" + gelen.snapsis[snap] + "'");
            }// for sonu
        }// fonksiyon sonu

        private void snapsisVerisiHesaplaAa2(noron gelen, yol gelenYol)
        {
            int snapsisSayisi = gelen.snapsis.Count;
            double oran = noronOraniBulAa2(gelenYol);
            double hesapOrani = 0.0;
            for (int snap = 0; snap < snapsisSayisi; snap++)
            {
                //  Console.WriteLine("önceki snapsis değeri: '" + gelen.snapsis[snap] + "'");

                //şimdi norana göre hesapsal oran yapıyoruz.
                hesapOrani = (oran/gelenYol.noronlar[snap].deger) * duzlemeOrani;

                if (artirma) gelen.snapsis[snap] /= hesapOrani;
                else gelen.snapsis[snap] *= hesapOrani;

                //  Console.WriteLine("sonraki snapsis değeri: '" + gelen.snapsis[snap] + "'");
            }// for sonu
        }// fonksiyon sonu

        private void snapsisVerisiHesaplaGirdidenAa2(noron gelen, double [] liste)
        {
            int snapsisSayisi = gelen.snapsis.Count;
            double oran = noronOraniBulGirdidenAa2(liste);
            double hesapOrani = 0.0;
            for (int snap = 0; snap < snapsisSayisi; snap++)
            {
                //  Console.WriteLine("önceki snapsis değeri: '" + gelen.snapsis[snap] + "'");

                //şimdi norana göre hesapsal oran yapıyoruz.
                hesapOrani = (oran / liste[snap]) * duzlemeOrani;

                if (artirma) gelen.snapsis[snap] /= hesapOrani;
                else gelen.snapsis[snap] *= hesapOrani;

                //  Console.WriteLine("sonraki snapsis değeri: '" + gelen.snapsis[snap] + "'");
            }// for sonu
        }// fonksiyon sonu
        private double noronOraniBulAa2(yol gelenYol)
        {
            double toplam = 0;
            for (int i = 0; i < gelenYol.noronlar.Count; i++)
            {
                toplam += gelenYol.noronlar[i].deger;
            }// for sonu
            double adet = gelenYol.noronlar.Count;
            double oran = toplam / adet;
            return oran;
        }// fonksiyon sonu

        private double noronOraniBulGirdidenAa2(double [] liste)
        {
            double toplam = 0;
            for (int i = 0; i < girdiSayisi; i++)
            {
                toplam += liste[i];
            }// for sonu
            double oran = toplam / girdiSayisi;
            return oran;
        }// fonksiyon sonu
        public void agiTestEt()
        {
            double gelen = 0.0;
            double gercek = 0.0;
            double sonuc = 0.0;

            // gerekli sıfırlamar
            dogruSayisi = 0;
            yanlisSayisi = 0;
            yuksekYanilgiSayisi = 0;

            for (int i = 1; i < test.Count; i++)
            {
                ilkYolOnHesaplama(test[i]);
                araYollarOnHesaplama();

                gelen = yollar[yollar.Count - 1].noronlar[0].deger;
                gercek = test[i][4];
                sonuc = 0.0;
                if (gelen <= 1.5 && gelen > 0.5) sonuc = 1.0;
                else if (gelen <= 2.5 && gelen > 1.5) sonuc = 2.0;
                else if (gelen <= 3.5 && gelen > 2.5) sonuc = 3.0;
                else yuksekYanilgiSayisi++;
                Console.WriteLine("hesaplanan değer : '" + gelen + "'");
                Console.WriteLine("sonuc : '"+sonuc+"' gercek : "+gercek+"'");
                if (sonuc == gercek) dogruSayisi++;
                else yanlisSayisi++;
            }// fonksiyon sonu

            Console.WriteLine("dogru sayısı : '" + dogruSayisi + "' yanlis sayisi : " + yanlisSayisi + "'");
            Console.WriteLine("yüksek yanılgı sayısı : '" + yuksekYanilgiSayisi + "'");
        }// fonksiyon sonu

    }// sınıf sonu

    class yol
    {
      public  List<noron> noronlar = new List<noron>();
    }// sınıf sonu

    class noron
    {
       public double deger;
       public List<double> snapsis = new List<double>();
    }// sınıf sonu

    class hesaplamalar
    {
        public double multiKok(double sayi,double kok)
        {
            double miktar =1.0/ Math.Pow(10, 16);
            double artis = 0.125;
            double carpan = 1.25;
            double hesap = Math.Pow(carpan,kok);
          // Console.WriteLine(" multi kök kısmına girildi. hesap degeri : '" + hesap + "'");
            double bolum = sayi / hesap;
            int sayac = 0;
            int dusus=0;
            while (hesap != sayi)
            {
                if (hesap < sayi)
                {
                    artis = artis * 2;
                    carpan = carpan + artis;
                    dusus = 0;
                }// if sonu
                else
                {
                    dusus++;
                    artis = artis / 2;
                    carpan = carpan - artis;
                 //   artis = artis / 2;
                }// else sonu
            //   Console.WriteLine("carpan degeri : '" + carpan + "'");
             //  Console.WriteLine("artis degeri : '" + artis + "'");
                hesap = Math.Pow(carpan, kok);
             //  Console.WriteLine("hesap degeri : '" + hesap + "'");
                
                // artis sabitlenirse çık
                if (artis <=miktar) break;
                sayac++;
                if (sayac == 500) break;
            }// while sonu
            Console.WriteLine("sayac degeri : '"+sayac+"'");
            return carpan;
        }// fonksiyon sonu

    }// sınıf sonu

    // statik bilgiler sinifimiz.
    class sbs
    {
        public static double basitAgRastgeleSnapsisMin=0.0;
        public static double basitAgRastgeleSnapsisMax = 1.0;
    }// sınıf sonu
}// proje alanı sonu
