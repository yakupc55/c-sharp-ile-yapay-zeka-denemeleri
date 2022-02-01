using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapayzekadenemeleri1
{
    public partial class Form1 : Form
    {
        string[] lines;
        string dosya;
        List<iris> irisler = new List<iris>();
        yapaySinirAgi agimiz;
        DataTable tablo = new DataTable();
        bool dosyaOkuma = false;
        bool satirYazdirmaDurumu = false;
        bool irisListesiOlusturmaDurumu = false;
        bool agOlusturmaDurumu = false;
        bool agCalistirmaDurumu = false;
        bool agEgitmeDurumu = false;
        public Form1()
        {
            InitializeComponent();
   
        }// constructor sonu

        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            // dosya okuma işlemleri burda gerçekleşiyor
            try
            {
                // dosya okumalarını sağlayan sınıfımızı oluşturuyoruz.
                OpenFileDialog theDialog = new OpenFileDialog();
                // açıklama yazısını değiştiriyoruz
                theDialog.Title = "data dosyasi açın";
                // hangi data tipini seceçeğini filtreleyerek belirtiyoruz. 
                theDialog.Filter = "TXT files|*.data";
                // eğer dosya seçme gerçekleşmisse if çalışacak.
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    // seçilen dosyanın adresini string verisine atıyoruz. 
                    string adres = theDialog.FileName;
                    // read all text yöntemiyle hepsini okuyup. satırlara bölüyoruz. 
                    lines = File.ReadAllText(adres).Split('\n');
                    lblBilgiAlani.Text = "dosya okuma başarılı";
                }// if sonu
                // diğer durumlarda kontrol etmek için oluşturulan bool değerini true yapıyoruz. 
                dosyaOkuma = true;
            }// try sonu
            catch (Exception ex)
            {

                lblBilgiAlani.Text = "hata : " + ex.Message;
            }// catch sonu
        }//fonksiyon sonu

        private void stringDiziYazdir(string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(i + ". eleman : '" + dizi[i] + "'");
            }
        }// fonksiyon sonu

        private void btnSatirYazdir_Click(object sender, EventArgs e)
        {
            // eğer dosya okuma kısımı sıkıntısız geçilmişse devam et diyoruz. 
            if (dosyaOkuma)
            {
                // dizimizi consolda yazdırıyoruz. 
                stringDiziYazdir(lines);
                lblBilgiAlani.Text = "satir yazdırma işlemi başarılı";
                satirYazdirmaDurumu = true;
            }// if sonu
            else
            {
                MessageBox.Show("lütfen önce dosya okuma yapın");
            }// else sonu
        }// fonksiyon sonu

        private void irisListesiOlustur()
        {
            // iris listesini sıfırlıyoruz.
            irisler.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                // sütunlara ayırıyoruz. 
                string[] aralar = lines[i].Split(',');

                //dizimizin parçalanmış sutunlarını ayırıyoruz. 
                stringDiziYazdir(aralar);
                double sepalLength = Convert.ToDouble(aralar[0].Replace(".", ","));
                double sepalWidth = Convert.ToDouble(aralar[1].Replace(".", ","));
                double petalLength = Convert.ToDouble(aralar[2].Replace(".", ","));
                double petalWidth = Convert.ToDouble(aralar[3].Replace(".", ","));
                Console.WriteLine("ilk double = ' " + sepalLength + "' : '" + aralar[0] + "'");

                // type değerini matematiksel bir değer haline getiriyoruz .
                int type;
                switch (aralar[4])
                {
                    case "Iris-setosa": type = 1; break;
                    case "Iris-versicolor": type = 2; break;
                    case "Iris-virginica": type = 3; break;
                    default: type = 0;
                        break;
                }// switch sonu
                Console.WriteLine("dönen type değeri : '" + type + "'");
                Console.WriteLine(i + ".ci dizi = ");

                if (type > 0)
                {
                    // eğer type kısmında herhangi bir sıkıntı olmadıysa iris eklemlerini yapıyoruz. 
                    irisler.Add(new iris(sepalLength, sepalWidth, petalLength, petalWidth, type));
                }// if sonu
            }// for sonu
            Console.WriteLine("iris listesi uzunluğu : '" + irisler.Count + "'");
            Console.WriteLine("iris listesi ilk double : '" + irisler[0].petalLength + "'");
        }// fonskiyon sonu

        private void btnIrisListesiOlustur_Click(object sender, EventArgs e)
        {
            // dosya okuma durumu başarılı ise devam et diyoruz. 
            if (dosyaOkuma)
            {
                try
                {
                    // iris için gerekli listemizi oluşturuyoruz. 
                    irisListesiOlustur();
                    lblBilgiAlani.Text = "iris listesi oluşturuldu.";
                    irisListesiOlusturmaDurumu = true;
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu
            }// if sonu
           else
            {
                MessageBox.Show("lütfen önce dosya okuması yapın");
            }// else sonu
}// fonksiyon sonu

        private void agiOlustur()
        {
            agimiz = new yapaySinirAgi(4, 1);
        }// fonksiyon sonu

        private void egitimVerileriEkle()
        {
            // 45 tanesi eğitime harcandı. 15*3= 45
            irisSinirVerisiEkle(agimiz.egitim, 0, 15);

        }// fonksiyon sonu

        private void testVerileriniEkle()
        {
            // 105 tanesi eğitime harcandı. 35*3= 105
            irisSinirVerisiEkle(agimiz.test, 15, 50);
        }//fonksiyon sonu

        private void irisSinirVerisiEkle(List<double[]> liste, int baslangic, int son)
        {
            int i = 0;
            for (int j = baslangic; j < son; j++)
            {
                i = j;
                liste.Add(new double[] { irisler[i].petalLength, irisler[i].petalWidth, irisler[i].sepalLength, irisler[i].sepalWidth, irisler[i].type });
                i = 50 + j;
                liste.Add(new double[] { irisler[i].petalLength, irisler[i].petalWidth, irisler[i].sepalLength, irisler[i].sepalWidth, irisler[i].type });
                i = 100 + j;
                liste.Add(new double[] { irisler[i].petalLength, irisler[i].petalWidth, irisler[i].sepalLength, irisler[i].sepalWidth, irisler[i].type });
            }// for sonu

        }// fonksiyon sonu

        private void button1_Click(object sender, EventArgs e)
        {
            // iris lisleri oluşmadan buraya girme duyuyoruz.
            if (irisListesiOlusturmaDurumu)
            {
                try
                {
                    agiOlustur();
                    egitimVerileriEkle();
                    testVerileriniEkle();
                    lblBilgiAlani.Text = "ağ oluşturuldu eğitim ve test verileri eklendi.";
                    agOlusturmaDurumu = true;

                    tbYaklasimMax.Text = agimiz.yaklasimOrani.ToString();
                    tbYaklasimNormal.Text = agimiz.normalOran.ToString();
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu
            }// if sonu
            else
            {
                MessageBox.Show("lütfen önce iris listesi oluşturun");
            }// else sonu
        }// fonksiyon sonu

        private void btnAgiCalistir_Click(object sender, EventArgs e)
        {

            try
            {
                if (agOlusturmaDurumu) {
                    agimiz.ilkDuzen();
                    lblBilgiAlani.Text = "ağ başarılı bir şekilde çalıştı ";
                    agCalistirmaDurumu = true;
                }// if sonu
                else
                {
                    MessageBox.Show("lütfen önce ağı oluşturun");
                }// else sonu
            }// try sonu
            catch (Exception ex)
            {
                lblBilgiAlani.Text = "hata : " + ex.Message;
            }// catch sonu
        }// fonksiyon sonu

        private void btnAgiEgit_Click(object sender, EventArgs e)
        {
            if (agCalistirmaDurumu)
            {
                try
                {
                    switch (cbEgitimAlgoritmasi.SelectedIndex)
                    {
                        case 0: agimiz.tumAgiEgit(); break;
                        case 1: agimiz.tumAgiEgitaa2(); break;
                        default:
                            Console.WriteLine("algoritma seçiminde teknik bir hata oluştu.");
                            break;
                    }//switch sonu

                    lblBilgiAlani.Text = "tüm ağ başarıyla eğitildi. ";
                    agEgitmeDurumu = true;
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu
            }// if sonu
            else
            {
                MessageBox.Show("lütfen önce ağı çalıştırın");
            }// else sonu
        }// fonksiyon sonu

        private void btnAgiTestEt_Click(object sender, EventArgs e)
        {
            if (agEgitmeDurumu)
            {
                try
                {
                    agimiz.agiTestEt();
                    double oran = (1.0 * agimiz.dogruSayisi / (agimiz.dogruSayisi + agimiz.yanlisSayisi)) * 100;
                    tablo.Rows.Add(tablo.Rows.Count,cbAgTipleri.SelectedItem, cbEgitimAlgoritmasi.SelectedItem, agimiz.yaklasimOrani, agimiz.normalOran, agimiz.dogruSayisi, agimiz.yanlisSayisi, agimiz.yuksekYanilgiSayisi, oran);
                    dgwTestSonuclari.DataSource = tablo;
                    lblBilgiAlani.Text = "tüm ağ başarıyla test edildi. ";
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu
            }// if sonu
            else
            {
                MessageBox.Show("lütfen önce ağınızı eğitin bilgisiz kalmasın");
            }// else sonu
        }// fonksiyon sonu

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("ağ tipi", typeof(string));
            tablo.Columns.Add("eğitim", typeof(string));
            tablo.Columns.Add("y-max", typeof(double));
            tablo.Columns.Add("y-nor", typeof(double));
            tablo.Columns.Add("dogru", typeof(double));
            tablo.Columns.Add("normal", typeof(double));
            tablo.Columns.Add("yuksek", typeof(double));
            tablo.Columns.Add("oran", typeof(double));
            dgwTestSonuclari.DataSource = tablo;
            for (int i = 0; i < dgwTestSonuclari.Columns.Count; i++)
            {
                dgwTestSonuclari.Columns[i].Width = 50;
            }// for sonu

            // combo boxları boş olmaktan kurtarıyoruz. 
            cbEgitimAlgoritmasi.SelectedIndex = 0;
            cbAgTipleri.SelectedIndex = 0;
        }// fonksiyon sonu

        private void btnYaklasimDegistir_Click(object sender, EventArgs e)
        {
            if (agCalistirmaDurumu)
            {
                try
                {
                    double yaklasimMax = Convert.ToDouble(tbYaklasimMax.Text);
                    double yaklasimNormal = Convert.ToDouble(tbYaklasimNormal.Text);

                    agimiz.yaklasimOrani = yaklasimMax;
                    agimiz.normalOran = yaklasimNormal;
                    lblBilgiAlani.Text = "yaklaşımlar başarıyla değiştirildi. ";
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu
            }//if sonu
            else
            {
                MessageBox.Show("lütfen önce ağınızı çalıştırın");
            }// else sonu
        }// fonksiyon sonu

        private void btnTumAgIslemleri_Click(object sender, EventArgs e)
        {
            if (irisListesiOlusturmaDurumu)
            {
                try
                {
                    agimiz.agiOlustur();
                }// try sonu
                catch (Exception ex)
                {
                    lblBilgiAlani.Text = "hata : " + ex.Message;
                }// catch sonu

                btnAgiCalistir_Click(sender, e);
                btnAgiEgit_Click(sender, e);
                btnAgiTestEt_Click(sender, e);
            }// if sonu
            else
            {
                MessageBox.Show("lütfen önce iris data listesi oluşturun");
            }// else sonu
        }// fonksiyon sonu

        private void toolsAa3Yapilandirmasi_Click(object sender, EventArgs e)
        {
            aa3YapilandirmaFormu formum = new aa3YapilandirmaFormu();
            formum.Show();
        }// fonksiyon sonu

        private void toolsBasitAgYapilandirmasi_Click(object sender, EventArgs e)
        {
            basitAgYapilandirmaFormu formum = new basitAgYapilandirmaFormu();
            formum.Show(); // formumu çalıştırıyoruz.
        }// fonksiyon sonu

        private void aaAlgoritmalariToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }// fonksiyon sonu
    }// sınıf sonu

}// isimlendirme sonu
