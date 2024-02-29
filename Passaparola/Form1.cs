using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				switch (soruno)
				{
					//Cevap 1
					case 1:
						if (textBox1.Text == "akdeniz")
						{
							button26.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button26.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
						//Cevap 2
					case 2:
						if (textBox1.Text == "bursa")
						{
							button2.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
						    button2.BackColor= Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 3
					case 3:
						if (textBox1.Text == "cuma")
						{
							button3.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button3.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 4
					case 4:
						if (textBox1.Text == "diyarbakır")
						{
							button4.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button4.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 5
					case 5:
						if (textBox1.Text == "eski")
						{
							button5.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button5.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 6
					case 6:
						if (textBox1.Text == "ferman")
						{
							button6.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button6.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 7
					case 7:
						if (textBox1.Text == "güneş")
						{
							button12.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button12.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 8
					case 8:
						if (textBox1.Text == "halı")
						{
							button11.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button11.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 9
					case 9:
						if (textBox1.Text == "ısparta")
						{
							button9.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button9.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 10
					case 10:
						if (textBox1.Text == "içel")
						{
							button24.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button24.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 11
					case 11:
						if (textBox1.Text == "jandarma")
						{
							button10.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button10.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 12
					case 12:
						if (textBox1.Text == "kayısı")
						{
							button8.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button8.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 13
					case 13:
						if (textBox1.Text == "lale festivali")
						{
							button7.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button7.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 14
					case 14:
						if (textBox1.Text == "mart")
						{
							button17.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button17.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 15
					case 15:
						if (textBox1.Text == "ney")
						{
							button16.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button16.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 16
					case 16:
						if (textBox1.Text == "ozan")
						{
							button15.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button15.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 17
					case 17:
						if (textBox1.Text == "pırasa")
						{
							button14.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button14.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 18
					case 18:
						if (textBox1.Text == "ramazan")
						{
							button13.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button13.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 19
					case 19:
						if (textBox1.Text == "snake")
						{
							button21.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button21.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 20
					case 20:
						if (textBox1.Text == "tarkan")
						{
							button20.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button20.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 21
					case 21:
						if (textBox1.Text == "umut")
						{
							button19.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button19.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 22
					case 22:
						if (textBox1.Text == "van")
						{
							button18.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button18.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 23
					case 23:
						if (textBox1.Text == "yıldırak")
						{
							button22.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button22.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
					//Cevap 24
					case 24:
						if (textBox1.Text == "zeytin")
						{
							button23.BackColor = Color.Green;
							dogru++;
							label2.Text = dogru.ToString();
						}
						else
						{
							button23.BackColor = Color.Red;
							yanlis++;
							label5.Text = yanlis.ToString();
						}
						break;
				}
			}
		}

		int soruno = 0, dogru = 0, yanlis = 0;
		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.Text = "Sonraki";
			soruno++;
			this.Text = soruno.ToString();
			List<string> alfabe = new List<string>();
			alfabe.Add("A");
			alfabe.Add("B");
			alfabe.Add("C");
			alfabe.Add("D");
			alfabe.Add("E");
			alfabe.Add("F");
			alfabe.Add("G");
			alfabe.Add("H");
			alfabe.Add("I");
			alfabe.Add("İ");
			alfabe.Add("J");
			alfabe.Add("K");
			alfabe.Add("L");
			alfabe.Add("M");
			alfabe.Add("N");
			alfabe.Add("O");
			alfabe.Add("P");
			alfabe.Add("R");
			alfabe.Add("S");
			alfabe.Add("T");
			alfabe.Add("U");
			alfabe.Add("V");
			alfabe.Add("Y");
			alfabe.Add("Z");

			//List<string> alfabe = new List<string> { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
			//List<string> cikarilacakHarfler = new List<string> { "Ç", "Ğ", "Ö", "Ş", "Ü" };
			//string _alfabe = string.Join("", alfabe.Except(cikarilacakHarfler));

			if(soruno <=24)
			{
				button25.Text = alfabe[soruno - 1]; // -1 index 0'dan başlar.
			}
			

			if (soruno == 1)
			{
				richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
				button26.BackColor = Color.Yellow;
			}
			if (soruno == 2)
			{
				richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
				button2.BackColor = Color.Yellow;
			}
			if (soruno == 3)
			{
				richTextBox1.Text = "Müslümanların kutsal günü?";
				button3.BackColor = Color.Yellow;
			}
			if (soruno == 4)
			{
				richTextBox1.Text = "Karpuzuyla ünlü olan ilimiz?";
				button4.BackColor = Color.Yellow;
			}
			if (soruno == 5)
			{
				richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir?";
				button5.BackColor = Color.Yellow;
			}
			if (soruno == 6)
			{
				richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
				button6.BackColor = Color.Yellow;
			}
			if (soruno == 7)
			{
				richTextBox1.Text = "Dünyanın ısı kaynağı?";
				button12.BackColor = Color.Yellow;
			}
			if (soruno == 8)
			{
				richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne ?";
				button11.BackColor = Color.Yellow;
			}
			if (soruno == 9)
			{
				richTextBox1.Text = "Gülüyle ünlü ilimiz?";
				button9.BackColor = Color.Yellow;
			}
			if (soruno == 10)
			{
				richTextBox1.Text = "Mersin'in diğer ismi?";
				button24.BackColor = Color.Yellow;
			}
			if (soruno == 11)
			{
				richTextBox1.Text = "Askeri bir topluluk?";
				button10.BackColor = Color.Yellow;
			}
			if (soruno == 12)
			{
				richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
				button8.BackColor = Color.Yellow;
			}
			if (soruno == 13)
			{
				richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
				button7.BackColor = Color.Yellow;
			}
			if (soruno == 14)
			{
				richTextBox1.Text = "Yılın üçüncü ayı?";
				button17.BackColor = Color.Yellow;
			}
			if (soruno == 15)
			{
				richTextBox1.Text = "Üflemeli bir müzik aleti?";
				button16.BackColor = Color.Yellow;
			}
			if (soruno == 16)
			{
				richTextBox1.Text = "Halk şairi?";
				button15.BackColor = Color.Yellow;
			}
			if (soruno == 17)
			{
				richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzeler ile yapılan yemek ?";
				button14.BackColor = Color.Yellow;
			}
			if (soruno == 18)
			{
				richTextBox1.Text = "11 ayın sultanı ?";
				button13.BackColor = Color.Yellow;
			}
			if (soruno == 19)
			{
				richTextBox1.Text = "İngilizce'de yılan anlamına gelen kelime";
				button21.BackColor = Color.Yellow;
			}
			if (soruno == 20)
			{
				richTextBox1.Text = "Türkiye'nin megastarı?";
				button20.BackColor = Color.Yellow;
			}
			if (soruno == 21)
			{
				richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
				button19.BackColor = Color.Yellow;
			}
			if (soruno == 22)
			{
				richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
				button18.BackColor = Color.Yellow;
			}
			if (soruno == 23)
			{
				richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
				button22.BackColor = Color.Yellow;
			}
			if (soruno == 24)
			{
				richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
				button23.BackColor = Color.Yellow;
			}
		}
	}	
}
