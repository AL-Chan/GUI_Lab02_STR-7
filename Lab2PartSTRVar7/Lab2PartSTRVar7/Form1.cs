using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2PartSTRVar7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			YourText.Text = Properties.Settings.Default.YourText.ToString();
		}

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			//вводится предложение в первое поле
			var sentence = YourText.Text;
			Properties.Settings.Default.YourText = sentence;
			Properties.Settings.Default.Save(); //сохранение + восстановление

			//удаление символов в квадратных скобках,
			//тем самым получается предложение без пробелов
			sentence = System.Text.RegularExpressions.Regex.Replace
				(sentence, "[.,:;!?№()&^#@1234567890 -]", String.Empty);
			//во второе поле выводится предложение без пробелов
			YourTextNoSpaces.Text = sentence;
			//новый экземпляр класса Логика
			var Reserv = new Logic();
			Reserv.Dub(sentence);
			//счетчик высчитывает кол-во повторов
			int dub = Reserv.Dub(sentence);
			//в третье выведется вывод о кол-ве повторов
			Reserv.ProcessGoing(dub);
			var Itog = Reserv.ProcessGoing(dub);
			ItogText.Text = Itog;
		}

		class Logic
		{
			public int Dub(string sentence)
            {
				var dub = 0;

				for (int a = 0; a < sentence.Length - 1; a++)
					if (sentence[a] == sentence[a + 1])
					{
						dub++; //счётчик с шагом 1
					}
				return dub;
			}

			public string ProcessGoing(int dub)
			{
				string Itog = "";
				switch(dub)
                {
					case 0:
						Itog = ("В этом предложении нет повторяющихся пар букв");
						break;
					default:
						Itog = ("Количество повторяющихся пар букв в предложении: " + dub);
						break;
				}

				return Itog;
			}

		}

        private void abouttask_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Дано предложение. Определить, сколько в нем " +
				"повторяющихся пар букв. Пробелы не учитывать.",
				"Задание на строки, вариант 7");
        }
    }
}