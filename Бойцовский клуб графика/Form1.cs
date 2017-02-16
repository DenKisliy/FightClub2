using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бойцовский_клуб_графика
{
    public partial class Form1 : Form
    {
        public int live_player1 = 10, live_player2 = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Ataka(int udar_player1, int blok_player2, bool proverka)
        {
            if (Udar.SelectedIndex == 0)
            {
                udar_player1 = 0;
                proverka = true;
            }
            else
            {
                if (Udar.SelectedIndex == 1)
                {
                    udar_player1 = 1;
                    proverka = true;
                }
                else
                {
                    if (Udar.SelectedIndex == 2)
                    {
                        udar_player1 = 2;
                        proverka = true;
                    }
                    else
                    {
                        MessageBox.Show("Выберите часть тела которую будете атокавать.");
                        proverka = false;
                    }
                }
            }

            if (udar_player1 != blok_player2 && proverka == true)
            {
                MessageBox.Show("Вы нанесли удар.");
                live_player2 = live_player2 - 1;
            }
            if (udar_player1 == blok_player2 && proverka == true)
                MessageBox.Show("Ваш удар блокировали.");
        }
        private void Zahita(int udar_player2, int blok_player1, bool proverka)
        {
            if (Blok.SelectedIndex == 0)
            {
                blok_player1 = 0;
                proverka = true;
            }
            else
            {
                if (Blok.SelectedIndex == 1)
                {
                    blok_player1 = 1;
                    proverka = true;
                }
                else
                {
                    if (Blok.SelectedIndex == 2)
                    {
                        blok_player1 = 2;
                        proverka = true;
                    }
                    else
                    {
                        MessageBox.Show("Выберите часть тела которую будете защищать.");
                        proverka = false;
                    }
                }
            }

            if (udar_player2 != blok_player1 && proverka == true)
            {
                if (udar_player2 == 1)
                    MessageBox.Show("Вы не смогли блокировать удар. Удар нанесли по голове. ");
                else
                {
                    if (udar_player2 == 2)
                        MessageBox.Show("Вы не смогли блокировать удар. Удар нанесли по туловищу. ");
                    else
                        MessageBox.Show("Вы не смогли блокировать удар. Удар нанесли по ноге. ");
                }

                live_player1 = live_player1 - 1;
            }
            if (udar_player2 == blok_player1 && proverka == true)
                MessageBox.Show("Вы блокировали удар.");
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int udar_player1 = 0, udar_player2 = 0, blok_player1 = 0, blok_player2 = 0;
            bool ataka = false, blok = false, kto_atakuet = false;

            if (kto_atakuet == false)
            {
                //Атака
                blok_player2 = 0;
                udar_player1 = 0;

                blok_player2 = rnd.Next(1, 3);

                Ataka(udar_player1, blok_player2, ataka);

                if (live_player2 == 0)
                    MessageBox.Show("Победа. Поздравляем.");
                kto_atakuet = true;
            }
            if (kto_atakuet == true)
            {
                //Защита
                udar_player2 = rnd.Next(1, 3);

                blok_player1 = 0;
                udar_player2 = 0;

                Zahita(udar_player2, blok_player1, blok);

                if (live_player1 == 0)
                    MessageBox.Show("К сожелению вы проиграли.Поражение.");

                kto_atakuet = false;
            }

        }

        }   
    }
