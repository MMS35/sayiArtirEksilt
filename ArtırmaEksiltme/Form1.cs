using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtırmaEksiltme
{
    public partial class Form1 : Form
    {



        #region Global ve local alanlar
        /*
         
                Global ve Local Alanlar

        Bizim kod yazdığımız sayfada eventlerimizin kendi yaşam alanlarına local alan denir.Global alanda oluşturduğunuz değişkenler direkt olarak Ram'e çıkartılırlar..
        Local alan kendi içerisinde oluşturulan yapıları asla dışarıya göstermez..Çünkü buradaki yapılar orada yaşar ve o yaşam alanı sonlandığında görevleri biter....

        Global alan ise bu local alan dediğimiz yapıların bir kademe dışında kalan alandır..Global alanda sadece tanımlamalar ve atamalar yapılabilir...

        Global alanda tanımlanmış bir değişken aynı isimde bir local alanda da tanımlanırsa local alan her zaman kendi değişkenine öncelik verir.
        Global alanda oluşturulan bir değişken o sayfadaki local alanların hepsi tarafından görülebilir.


        Local alandaki değişkenler local alanın işi bittiği zaman Garbage Collector tarafından Ram'den kaldırılır..Ancak Global alanda tanımlanmış olan değişkenler ramden kaldırılmazlar..

         */

        #endregion


        int a = 1000;

        public Form1()
        {
            InitializeComponent();
        }

       // int a = 4;

        private void Form1_Load(object sender, EventArgs e)
        {
            //int a = 3;

            //Eğeer bir yaşam alanı global alanda oluşturulmuş bir değişken ile aynı isme sahip bir değişkene sahipse ve siz buna rağmen global alandaki değişkene ulaşmak istiyorsanz this keyword'unu kullanmalısınız..
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //int b = 2;
            //b++;
            //MessageBox.Show(b.ToString());
            a++;
            MessageBox.Show(a.ToString());

        }
        

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            a--;
            MessageBox.Show(a.ToString());

        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
        }
    }
}
