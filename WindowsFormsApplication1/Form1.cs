using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       String[][] gameArray = { new String[3], new String[3], new String[3] };
       Boolean[] check = new Boolean[1];
       String[] tips = { "Ничего себе", "Ничего себе как умно", "Вау", "ОЙ как ты его туда засунул", " Вот так, даа", "О, да детка", "Не так уж круто", "Ништяк", "Абалдеть" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[0];
            button1.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0, y = 1;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[1];
            button2.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0, y = 2;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[2];
            button3.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 1, y = 0;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[3];
            button4.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 1, y = 1;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[4];
            button5.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x = 1, y = 2;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[8];
            button6.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = 2, y = 0;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[5];
            button7.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2, y = 1;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[6];
            button8.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 2, y = 2;
            Button.game(x, y, this.gameArray, this.check);
            richTextBox1.Text = tips[7];
            button9.Text = this.gameArray[x][y];
            if (Button.CheckWin(gameArray) || Button.verticalCheckWin(gameArray) || Button.DiagonalCheckWin1(gameArray) || Button.DiagonalCheckWin2(gameArray))
            {
                richTextBox1.Text = gameArray[x][y] + " выиграл";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Button.newGame(gameArray);
            richTextBox1.Text = "CРАЗИМСЯ!";
        }
    }
}
