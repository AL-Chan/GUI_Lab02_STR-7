using System;
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

			//новый экземпляр класса Логика
			var Logic = new Logic();
			//счетчик высчитывает кол-во повторов
			int dub = Logic.Dub(sentence);
			//во второе поле выводится предложение без пробелов
			YourTextNoSpaces.Text = Logic.NewSentence(sentence);
			//вывод сообщения о повторах
			var Itog = Logic.ProcessGoing(dub);
			//в третье поле выведется вывод о кол-ве повторов
			ItogText.Text = Itog;
		}

		public class Logic
		{
			public string NewSentence (string sentence) //удаление символов, перечисленных в квадратных скобках
			{
			sentence = System.Text.RegularExpressions.Regex.Replace
				(sentence, "[.,:;!?№()&^#@1234567890$%*+=_ -]", String.Empty);
				return sentence;
			}

			public int Dub(string sentence)
            {
				var Logic = new Logic();
				var dub = 0;
				sentence = Logic.NewSentence(sentence);
				for (int a = 0; a < sentence.Length - 1; a++)
					if (sentence[a] == sentence[a + 1])
					{
						dub++; //счётчик с шагом 1
					}

				return dub;
			}

			public string ProcessGoing(int dub) //для выводного сообщения
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

        private void abouttask_Click(object sender, EventArgs e) // кнопка Посмотреть задание
		{
			MessageBox.Show("Дано предложение. Определить, сколько в нем одинаковых соседних букв. Пробелы не учитывать.", "Задание на строки, вариант 7");
        }
    }
}
