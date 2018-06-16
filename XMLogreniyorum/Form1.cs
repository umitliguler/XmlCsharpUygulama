using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;// dosya okuma yazma işlerine bakan class

namespace XMLogreniyorum    // Platformlar arası bilgi göndermeyi kolaylaştırmak için kullanılır, bilgi transfer için kullanılır
{                           // Text dosyasından farkı yok, kullanımı kolay

    //örneğin bir disbritörün var malların listesini istiyorsun, disbritör sana direk eql i sunmak yerine xml dosyasını gönderiyor
    //en başdaki xml beyanı olmak zorunda
    //<? xml version="1.0" encoding="utf-8" ?>
    //utf-8 avrupa dil desteği


    /*
     <Calisanlar>  ----->  Root
      <Calisan TCNo = "12345678901" >    ----> Node(Child)  TCNo = "12345678901"---> attribute
        < Adi > Umit </ Adi >
        < Soyadi > Guler </ Soyadi >
        < DogumYili > 1990 </ DogumYili >
      </ Calisan >

     */

        //Calısanlar.xml'e tıklayıp properties'den Copy to Output = always olacak
        //böylece her F5 e bastığımızdan bundan bi tane kopya koyuyor
        //dosyayaı silsek bile yeniden oraya koyacak // bin/debug içerisi


        //Form uygulamasında DataGriedView Kullandık tablo için



    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        // Application.StartupPath --> XmlOgreniyorum/bin/debug
        String DosyaYolu = Application.StartupPath + "\\CalisanListesi.xml";
        //    "\\..\\CalisanListesi.xml"  --> iki klasör yukarı çık 


        private void btnVeriOku_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml(DosyaYolu);
            dataGridView1.DataSource = ds.Tables[0];

        }



        private void btnVeriBul_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYolu);

            XmlNode SecilenNode = xmlDoc.ChildNodes[1];

            foreach (XmlNode item in SecilenNode)
            {
                //if (item.ChildNodes[0].InnerText == "Mahmut") ;
                if (item.Attributes["TCNo"].Value  == "12345678901") 
                {
                    MessageBox.Show("### Aranan Kişi Bilgileri ###\n"+ item.ChildNodes[0].InnerText
                        + " " + item.ChildNodes[1].InnerText + "\n" + item.ChildNodes[2].InnerText);
                    break;
                }
            }
        }



        private void btnVeriBul2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYolu);


            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TCNo = 12345678901]");

            MessageBox.Show("### Aranan Kişi Bilgileri ###\n" + secilenNode.ChildNodes[0].InnerText
    + " " + secilenNode.ChildNodes[1].InnerText + "\n" + secilenNode.ChildNodes[2].InnerText);
            
        }



        private void btnVeriDegistir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYolu);


            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TCNo = 12345678901]");

            if (secilenNode != null)
            {
                secilenNode.ChildNodes[0].InnerText = "Fatma";
                xmlDoc.Save(DosyaYolu);
                MessageBox.Show("OK");

            }
            else
                MessageBox.Show("Kisi bulunamadı..");

        }



        private void btnVeriBul3_Click(object sender, EventArgs e)
        {
            XPathDocument xmlDoc = new XPathDocument(DosyaYolu);
            XPathNavigator xnav = xmlDoc.CreateNavigator();//xml dosyasında Neyin altında ne var hepsini çıkarıyor
            //bir nevi yol haritası
            XPathNodeIterator SecilenNode = xnav.Select("Calisanlar/Calisan/Adi");

            String Metin = "";

            while (SecilenNode.MoveNext())// bi sonraki bi sonraki diyerek tarıyor, hepsini read et der gibi
            {

                //Metin += SecilenNode.Current.InnerXml + "\n" ;// bütün isimleri listele

                if (SecilenNode.Current.InnerXml.StartsWith("K"))// ismi K ile başlayanları listele
                {//elementlerde inner text, attributelarda value mesela value 1 ile başlayanları getir
                    Metin += SecilenNode.Current.InnerXml + "\n" ;

                }

            }

            MessageBox.Show(Metin);

        }



        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYolu);


            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TCNo = 12345678901]");

            if (secilenNode != null)
            {

                xmlDoc.DocumentElement.RemoveChild(secilenNode);
                xmlDoc.Save(DosyaYolu);
                MessageBox.Show("OK");

            }
            else
                MessageBox.Show("Silinecek Kisi bulunamadı..");
        }




        private void btnVeriEkle_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(DosyaYolu);

            XmlElement MyElement = xmlDoc.CreateElement("Calisan");

            XmlAttribute attTC = xmlDoc.CreateAttribute("TCNo");
            attTC.Value = "12345678904";
            MyElement.Attributes.Append(attTC);


            XmlNode xAdi = xmlDoc.CreateNode(XmlNodeType.Element, "Adi", "");
            xAdi.InnerText = "Buse";
            MyElement.AppendChild(xAdi);

            XmlNode xSoyadi = xmlDoc.CreateNode(XmlNodeType.Element, "Soyadi", "");
            xSoyadi.InnerText = "HAVALI";
            MyElement.AppendChild(xSoyadi);

            XmlNode xDogum= xmlDoc.CreateNode(XmlNodeType.Element, "DogumYili", "");
            xDogum.InnerText = "1987";
            MyElement.AppendChild(xDogum);

            xmlDoc.DocumentElement.AppendChild(MyElement);
            xmlDoc.Save(DosyaYolu);
            MessageBox.Show("OK");


        }



        private void btnSQLtoXML_Click(object sender, EventArgs e)
        {


            SqlConnection cnn = new SqlConnection("Data Source=UMITT\\SQLEXPRESS;" +
                "Initial Catalog=ErmasDepo;Persist Security Info=True;User ID=Sa;Password=159357"); // --> açıklama altta

            //project/Add new Data Source'ye tıklayarak ne olduğunu öğrendik
            //öncesinde sql server management studio indirdik  ve bir database oluşturduk.
            //version2017 pc gücü yetmedi
            //versiyon 2014 kurdum.

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Komponentler", cnn);
            //sql server management studio'da, ErmasDepo database içerisindeki, Komponentler Tablosu


            DataTable dt = new DataTable("Mal") ;
            adp.Fill(dt);
            DataSet ds = new DataSet("Komponentler");
            ds.Tables.Add(dt);

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();

            if (dr==DialogResult.OK)
            {
                ds.WriteXml(fd.SelectedPath + "\\SqlToXml.xml");
                MessageBox.Show("OK");
            }
            else
                MessageBox.Show("Not OK");
        }



        private void btnXmlToSql_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //ds.WriteXml(fd.SelectedPath + "\\SqlToXml.xml");
                String Dosya = fd.SelectedPath + "\\SqlToXml.xml";

                if (File.Exists(Dosya)  )
                {
                    SqlConnection cnn = new SqlConnection("Data Source=UMITT\\SQLEXPRESS;" +
                        "Initial Catalog=ErmasDepo;Persist Security Info=True;User ID=Sa;Password=159357"); // --> açıklama altta
                    //project/Add new Data Source'ye tıklayarak ne olduğunu öğrendik
                    //öncesinde sql server management studio indirdik  ve bir database oluşturduk.
                    //version2017 pc gücü yetmedi
                    //versiyon 2014 kurdum.

                    SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Komponentler", cnn);
                    //sql server management studio'da, ErmasDepo database içerisindeki, Komponentler Tablosu


                    // adaptor üzerinden insert update komutlarını otomatik yazan class
                    SqlCommandBuilder cb = new SqlCommandBuilder(adp);
                    DataSet ds = new DataSet();
                    ds.ReadXml(Dosya);// bütün kayıtlar dataset içerisine ilk defa geldiği için hepsi yeni kayıt oluyor
                    //yeni kayıt olduğuna göre bunların hepsi insert olması gerekiyor diye düşünüyor
                    adp.Update(ds.Tables[0]);// tüm kayıtları insert olarak göndermiş olduk
                    MessageBox.Show("OK");

                }
                else
                {

                    MessageBox.Show("Dosya Bulunamadı.\nSqlToXml.xml");

                }

            }
            else
                MessageBox.Show("Not OK");
        }

        private void btnSema_Click(object sender, EventArgs e)
            // veri alıcak olan firma karşı tarafa hangi formatta istediğini söylemek zorunda, bunun için yaptık
        {
            SqlConnection cnn = new SqlConnection("Data Source=UMITT\\SQLEXPRESS;" +
                "Initial Catalog=ErmasDepo;Persist Security Info=True;User ID=Sa;Password=159357");

            SqlDataAdapter adp = new SqlDataAdapter("SELECT Malzeme,Voltaji,Akimi FROM Komponentler", cnn);
            // bir firma bizden bir xml formatı istediğinde bu şemaya göre tablo oluşturmamızı ister,

            DataSet ds = new DataSet("xKomponentler");
            DataTable dt = new DataTable("xMalzeme");
            adp.Fill(dt);
            ds.Tables.Add(dt);

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string Dosya = fd.SelectedPath + "\\BenimSemam.xsd"; //xsd: açılımı; xml shema defination
                // fd.SelectedPath nereye kaydedeceğini sordurur..

                ds.WriteXmlSchema(Dosya);

                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Dosya Bulunamadı.\nSqlToXml.xml");
            }

        }



        private void BtnXmlToSqlWithSchema_Click(object sender, EventArgs e)
        {//Semaya göre düzenleme yapıyor.

            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "Size gelen Semanin Klasorunu Seciniz.";
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string Dosya = fd.SelectedPath + "\\BenimSemam.xsd";//xsd xml shema defination
                // fd.SelectedPath nereye kaydedeceğini sordurur..

                if (File.Exists(Dosya))
                {
                    SqlConnection cnn = new SqlConnection("Data Source=UMITT\\SQLEXPRESS;" +
                        "Initial Catalog=FrikDepo;Persist Security Info=True;User ID=Sa;Password=159357");

                    SqlDataAdapter adp = new SqlDataAdapter("SELECT ProID AS Malzeme," +
                        "ProNm AS Voltaji,UnitPri AS Akimi FROM Products", cnn);
                    //diyelimki elimizde bir tablo var ona göre düzenleme yapmak istiyoruz,
                    //as(gibi) diyerek anahtar kelimelerin ismini değiştiriyoruz.

                    DataTable dt = new DataTable("xMalzeme");

                    dt.ReadXmlSchema(Dosya);
                    adp.Fill(dt);

                    DataSet ds = new DataSet("xKomponentler");
                    ds.Tables.Add(dt);

                    FolderBrowserDialog fd2 = new FolderBrowserDialog();
                    fd2.Description = "XML Kayit Klasorunu Seciniz.";
                    DialogResult dr2 = fd2.ShowDialog();

                    if (dr2 == DialogResult.OK)
                    {
                        ds.WriteXml(fd2.SelectedPath + "\\Semali.xml");
                        MessageBox.Show("OK");

                    }
                    else
                        MessageBox.Show("Islem Iptal Edildi.");
                }
                else
                {
                    MessageBox.Show("Sema Bulunamadı\nBenimSemam.xsd");
                }
            }
            else
            {
                MessageBox.Show("Not OK");
            }

        }

        private void btnXmlSchemaValidation_Click(object sender, EventArgs e)
        {// semaya göre düzenleme yapılıp  yapılmasığını sorguluyor

            Hatalar = "";// her butona basılışda hataları temizliyoruz.

            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "Sizin Gönderdiğiniz Semanin Klasorunu Seciniz.";
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string SemaDosyasi = fd.SelectedPath + "\\BenimSemam.xsd";//xsd xml shema defination
              // fd.SelectedPath nereye kaydedeceğini sordurur..

                fd = new FolderBrowserDialog();
                fd.Description = "Size gelen xml Klasorunu Seciniz.";
                 dr = fd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string XmlDosyasi = fd.SelectedPath + "\\Semali.xml";//xsd xml shema defination

                    XmlReaderSettings Ayarlar = new XmlReaderSettings();
                    Ayarlar.Schemas.Add("",SemaDosyasi);//namespace boş,yok
                    Ayarlar.ValidationType = ValidationType.Schema;
                    Ayarlar.ValidationEventHandler += Ayarlar_ValidationEventHandler;
                    //+= tab tab yaptık event olduğu için, event en aşağıda

                    XmlReader rdr = XmlReader.Create(XmlDosyasi, Ayarlar);

                    while (rdr.Read())// içerisine herhangi birşey yazmıyoruz.
                    {                  // çünkü okurken birşey yapmasını istemiyoruz, sadece okuması için yazdık

                    }

                    if (Hatalar == "")
                    {
                        MessageBox.Show("OK.");
                    }
                    else
                    {
                        MessageBox.Show(Hatalar);
                    }
                }
                else
                {
                    MessageBox.Show("Xml Seçilmedi.");
                }
            }
            else
            {
                MessageBox.Show("Sema Seçilmedi.");
            }

        }
        string Hatalar = "";

        //Herhangi bir hata ile karşılaşıldığında burası çalışıyor
        private void Ayarlar_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {

            if (e.Severity==System.Xml.Schema.XmlSeverityType.Error)
            {
                Hatalar += "Hata -->" + e.Message + "\r\n";
                // "\r" paragraf sonu, mesela not defretie yazdıracaksak enter için n değil r istiyor
            }
            else
            {
                Hatalar += "Uyarı -->" + e.Message + "\r\n";

            }
        }
    }
}
