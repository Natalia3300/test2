using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Game
{ 
public partial class Form1 : System.Windows.Forms.Form
{
    // Переменные для ходов и денег
    private int energy = 3;
    private int totalValue = 0;

    public Form1()
    {
        InitializeComponent();
        // Текст, который появится сразу при запуске
        txtLog.Text = "=== ТАЙНЫ ЗАБРОШЕННОГО ЧЕРДАКА ===\r\n" +
                      "Вы поднялись на скрипучий чердак старого дома.\r\n" +
                      "Вокруг темнота. Батарейки фонарика хватит на 3 осмотра.\r\n" +
                      "Выберите место для поиска старья ниже.\r\n\r\n";
    }

    // Логика для кнопки "Сундук"
    private void btnChest_Click(object sender, EventArgs e)
    {
        txtLog.AppendText("-> Вы открыли тяжелый кованый сундук.\r\n" +
                          "Среди старых вещей вы нашли серебряные карманные часы 1912 года! (+3500 руб)\r\n\r\n");
        totalValue += 3500;
        btnChest.Enabled = false; // Выключаем кнопку, чтобы нельзя было кликать дважды
        MakeTurn();
    }

    // Логика для кнопки "Комод"
    private void btnCabinet_Click(object sender, EventArgs e)
    {
        txtLog.AppendText("-> Вы выдвинули пыльный ящик дубового комода.\r\n" +
                          "На старом конверте вы обнаружили редкую почтовую марку! (+1500 руб)\r\n\r\n");
        totalValue += 1500;
        btnCabinet.Enabled = false; // Выключаем кнопку
        MakeTurn();
    }

    // Логика для кнопки "Брезент"
    private void btnTrash_Click(object sender, EventArgs e)
    {
        txtLog.AppendText("-> Вы сдернули серый брезент, подняв тучу пыли.\r\n" +
                          "Там оказался лишь сломанный велосипед и ржавые гвозди. Ничего ценного. (0 руб)\r\n\r\n");
        btnTrash.Enabled = false; // Выключаем кнопку
        MakeTurn();
    }

    // Функция, которая срабатывает при каждом действии игрока
    private void MakeTurn()
    {
        energy -= 1; // Минус один заряд фонарика

        // Обновляем текст на экране
        lblEnergy.Text = $"Фонарик: {energy} ед.";
        lblMoney.Text = $"Находки: {totalValue} руб.";

            // Если ходы кончились — выводим финал
            if (energy <= 0)
            {
                txtLog.AppendText("====================================\r\n" +
                                  "Батарейка фонарика окончательно села! Игра окончена.\r\n" +
                                  $"Вы собрали антиквариата на сумму: {totalValue} рублей.\r\n");

                if (totalValue >= 5000)
                    txtLog.AppendText("УСПЕХ! Из вас вышел отличный охотник за старьём!\r\n");
                else if (totalValue > 0)
                    txtLog.AppendText("НЕПЛОХО! Кое-какие вещи выгодно пополнят лавку.\r\n");
                else
                    txtLog.AppendText("ПРОВАЛ. Вы вернулись с чердака с пустыми руками.\r\n");

                // Полностью блокируем все кнопки в конце игры
                btnChest.Enabled = false;
                btnCabinet.Enabled = false;
                btnTrash.Enabled = false;
            }
          
        }
    }
}
