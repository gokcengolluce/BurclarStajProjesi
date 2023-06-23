using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurclarStaj
{
    public partial class Form1 : Form
    {
        int foto_numara;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] burclar = { "Koç", "Boğa", "İkizler", "Yengeç", "Aslan", "Başak", "Terazi", "Akrep", "Yay", "Oğlak", "Kova", "Balık" };
            comboBox1.Items.AddRange(burclar);
            
            label2.Text = "Burçların Tarihçesi";
            label3.Text = "Yazılı tarihte ilk ortaya çıkışı MÖ 2500 yılında," +
                " gezegenlerin insanın kaderini etkileyen güçlü tanrılar " +
                "olduğuna inanılan Mezopotamya'da olmuştur. " +
                "Bu ilk astrologlar gökyüzünü dikkatle izlemeye ve onun geceleri parıltılı," +
                " muhteşem sessizliğinde gördüklerinde düzenli kayıtlarını tutmaya başladılar." +
                " Astroloji danışmanları Kraliyet ailesine devlet yönetimi konusunda akıl " +
                "verirlerdi ve Mezopotamya tarihinin erken " +
                "dönemlerinde astroloji 'Kraliyet Sanatı' olarak düşünülürdü.";
            pictureBox1.Image = ımageList1.Images[0];






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                pictureBox1.Image = ımageList1.Images[1];
                label2.Text = "Koç Burcu";
                label3.Text = "Astrolojinin ilk burcu koç burcudur. " +
                    "Koç burcu olan kişiler hareketli, enerjik, özgür ve cesaretli insanlardır." +
                    " Koç burcu insanları diğer kişileri yönlendirmeyi severler. " +
                    "Koç burcunda olan kişiler coşkulu ve hedef odaklıdırlar. " +
                    "Koç burcu insanları genellikle çok enerjiktirler ve" +
                    " etrafa yaydıkları enerjiyle bunu hemen hemen her ortamda gösterirler." +
                    " Liderlik özelliklerine sahip olmalarının yanında cesur ve atılgandırlar" +
                    " ve bu özellikleri nedeniyle diğer kişileri kolaylıkla yönlendirebilirler." +
                    " Koç burcu olan insanlarının özgüveni oldukça yüksektir.";
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                pictureBox1.Image = ımageList1.Images[2];
                label2.Text = "Boğa Burcu";
                label3.Text = "Boğa burcu güvenilir ve inatçı bir burçtur." +
                    "Boğa burçları güvenilir ve sıcakkanlı kişilikleriyle geniş" +
                    "bir arkadaş grubuna sahip insanlardır. " +
                    "Boğa burcu insanları genellikle sanatsever olarak" +
                    "nitelendirilirler. Boğa burçlarının çoğu zaman " +
                    "duygularıyla hareket ettiği gözlemlenmiştir. " +
                    "Boğa burcu insanları rahatlarına düşkün ve " +
                    "tembellik yapmayı sevmelerine rağmen inatçı " +
                    "kişiliklerinin de katkısı ile çok istedikleri " +
                    "şeyler konusunda azimli olabilirler ve " +
                    "böylece başarıya ulaşabilirler.";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = ımageList1.Images[3];
                label2.Text = "İkizler Burcu";
                label3.Text = "İkizler burcuna ait kişiler birden çok " +
                    "duyguyu aynı anda yaşamaları ile bilinirler. " +
                    "İkizler burcuna ait kişilerin bir anı diğer anının " +
                    "tutmayabilir bu nedenle birçok insan tarafından dengesiz " +
                    "olarak ifade edilir. İkizler burcu sosyalleşmeyi seven ve " +
                    "konuşkan kişilerdir bu nedenle çevrelerinde oldukça " +
                    "popülerdirler. İkizler burcuna ait kişilerin kendilerine " +
                    "güveni yüksektir ve bu sayede sosyal ortamlarda çekici " +
                    "bir kişilik olarak tanımlanırlar.";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = ımageList1.Images[4];
                label2.Text = "Yengeç Burcu";
                label3.Text = "Yengeç yani cancer burcuna ait kişiler" +
                    "çevreleri tarafından hassas ve duygusal kişiler " +
                    "olarak bilinirler. Hassas olmalarından dolayı yengeç " +
                    "burcu insanları hemen kırılabilir ve çok çabuk " +
                    "incinebilirler. Yengeç burcuna ait kişiler ailelerine " +
                    "doldukça düşün olurlar. Sadece ailelerine değil " +
                    "karşılaştıkları her insana duyarlı ve ilgili davranırlar, " +
                    "bu sayede çevrelerindeki insanlarla kurdukları duygusal " +
                    "bağlar oldukça güçlüdür. Yengeç burcu insanları gerek sosyal " +
                    "yaşamlarında gerek iş hayatlarında sorumluluk " +
                    "sahibidirler.";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.Image = ımageList1.Images[5];
                label2.Text = "Aslan Burcu";
                label3.Text = "Aslan burcuna ait kişilerin kendilerine çok yüksek " +
                    "güvenleri vardır, bu nedenle çevreleri tarafından burnu havada " +
                    "ve hatta kaba ve kendini beğenmiş olarak nitelendirilebilirler. " +
                    "Aslan burcuna mensup kişiler otoriterdirler ve gerek sosyal gerek " +
                    "iş hayatında çevrelerindeki insanları yönetmeyi severler. " +
                    "Aslan burcu aynı zamanda cömert ve fedakar kişilerdir. " +
                    "Aslan burcuna mensup kişiler zaman zaman duygusal olabilirler ama " +
                    "bu durum yüksek egoları ile çatışma yaşamalarına neden olur.";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                pictureBox1.Image = ımageList1.Images[6];
                label2.Text = "Başak Burcu";
                label3.Text = "Virgo, yani başak burcuna ait kişiler oldukça düzenli " +
                    "ve yaptıkları işlerde titiz kişilerdir. Başak burcu " +
                    "ani kararlar vermez, her ne yapıyorlarsa ilk önce " +
                    "analiz yapar ve düşünerek karar verirler. " +
                    "Bu nedenle başak burcu insanlarını aklı ön plana " +
                    "alan kişiler olarak ifade edebiliriz. Başak burcu " +
                    "insanı temizlik ve düzene önem verir, onları en " +
                    "rahatsız eden şeyler arasında kir " +
                    "ve dağınıklık ilk sıralarda gelir. ";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                pictureBox1.Image = ımageList1.Images[7];
                label2.Text = "Terazi Burcu";
                label3.Text = "Terazi, (Libra) burcuna mensup insanlar " +
                    "çevrelerinde diplomatik olarak tanınırlar ve bu özellikleri " +
                    "ile ön plana çıkarlar. Terazi burcunun diplomatik " +
                    "olmasından dolayı karşıt görüşte olan kişiler dahil hemen hemen " +
                    "herkesle iyi ilişkiler kurabilirler. Libra burcuna ait kişiler " +
                    "iş yaşamlarında azimlidir, başarı ve para kazanma hırsları yüksektir. " +
                    "Kazandıklarını pahalı zevklere ve eşyalara harcamaktan çekinmezler. " +
                    "Terazi burcu insanının sosyal yaşamda ve iş ortamında temiz ve şık görünüme " +
                    "takıntısı vardır.";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                pictureBox1.Image = ımageList1.Images[8];
                label2.Text = "Akrep Burcu";
                label3.Text = "Akrep burcu (ingilizcede Scorpio) insanları tutkuludur ve " +
                    "tutkulu yaşam tarzları ile tanınırlar. Sosyal yaşamda arkadaş " +
                    "canlısı kişilikleri ve alımlı görüntüleri ile her ortama " +
                    "rahatlıkla girerler ve kendilerini sevdirirler. Akrep burcuna " +
                    "ait şahıslar aklı ön planda tutarlar ve sorgulamayı severler. " +
                    "Sorgulayıcı olmaları iş yaşamında başarılı olmalarını " +
                    "sağlarken sosyal yaşamda bazı zorluklar yaşamalarına sebep olabilir. ";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                pictureBox1.Image = ımageList1.Images[9];
                label2.Text = "Yay Burcu";
                label3.Text = "Yay burcu (ingilizce Sagittarius) insanları pozitif ve " +
                    "hayata karşı canlı bir kişilikleri vardır. Sosyal yaşamda bir " +
                    "yay burcunun yeni insanlarla tanışmaları kolaydır ve arkadaşlarıyla " +
                    "eğlenmeyi severler. Yay burcuna ait kişiler doğa sevdalısıdır. " +
                    "Doğayla iç içe olmayı, doğada vakit geçirmeyi, doğa yürüyüşleri " +
                    "yapmayı severler. Bu onların aynı zamanda sportif olmalarını sağlar. ";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                pictureBox1.Image = ımageList1.Images[10];
                label2.Text = "Oğlak Burcu";
                label3.Text = "Oğlak burcu (ingilizce capricorn veya capricornus) insanları " +
                    "oldukça hırslı ve tutkulu kişilerdir. Oğlakların akılcı düşünme " +
                    "eğilimleri vardır ve hayatlarını her zaman kontrol altında tutmak isterler." +
                    "Oğlak insanlarının akılcı olmalarından dolayı mantık " +
                    "çerçevesinde hareket ederler bu durum sosyal ve iş çevrelerinde " +
                    "soğuk kişiler olarak tanınmalarına neden olabilir. Oğlak burcu yaptıkları işlerde " +
                    "titiz, hırslı ve çalışkandır ve iyi bir kariyer sahibi olmak isterler. ";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                pictureBox1.Image = ımageList1.Images[11];
                label2.Text = "Kova Burcu";
                label3.Text = "Kova burcu (ingilizce Aquarius) insanları kendi bildiklerini " +
                    "yapmayı seven özgür ruhlu kişilerdir. Çevrelerindeki insanların kendi " +
                    "haklarında ne düşündüklerini çoğunlukla önemsemezler. Bu nedenle " +
                    "çevreleri tarafından ilgisiz olarak nitelendirilebilirler. Aslında " +
                    "bu özellikleri sorgulayıcı yapılarından kaynaklanır. Olayları iyi " +
                    "sorgulayabildikleri için taraf tutmazlar ve olaylara karşı tarafsızdırlar. " +
                    "Bu özellikleri sayesinde kova burcu insanları doğru ve tarafsız kararlar " +
                    "alabilirler.";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                pictureBox1.Image = ımageList1.Images[12];
                label2.Text = "Balık Burcu";
                label3.Text = "Balık burcuna (ingilizcede Pisces) mensup olan insanlar oldukça " +
                    "duygusal kişilerdir. Balık burcunun duygusal olması nedeniyle şefkatli ve " +
                    "iyi niyetlidirler ve bu sayede çok yakın arkadaşlıklar kurmakta zorlanmazlar. " +
                    "Bu onların en güçlü yanları olmasına rağmen aynı zamanda oldukça melankolik ve " +
                    "olaylara karşı kötümser olmalarına neden olabilir. Balık burcu insanları çok iyi " +
                    "bir arkadaş ve çok iyi bir sırdaştırlar. Sır saklama konusunda onlardan daha iyi " +
                    "bir burç olmadığı bile iddia edilebilir.";
            }
        }

    }
}
