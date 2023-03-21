using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BejinariuAndreeaAtestat
{
    public partial class Nivel1 : Form
    {
        public Nivel1()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int startx; //coordonatele cosului
        int starty;
        private void Form4_Load(object sender, EventArgs e)
        {

            startx = cos.Location.X;
            starty = cos.Location.Y;
        }
        private void keyPressed(object sender, KeyEventArgs e)
        {

            action(e);
        }
        private void check_wall_collision(Label target)
        {

            int target_x = target.Location.X;
            int target_y = target.Location.Y;
            int target_w = target.Width;
            int target_h = target.Height;
            int cos_x = cos.Location.X;
            int cos_y = cos.Location.Y;
            int cos_w = cos.Width;
            int cos_h = cos.Height;

            if ((cos_x > target_x && cos_x < (target_x + target_w)) && (cos_y > target_y && cos_y < (target_y + target_h)))
            {
                MessageBox.Show("Din păcate, ai atins peretele! Încearcă din nou :(", "Ai pierdut");//punct stanga sus
                cos.Location = new Point(startx, starty);
                t = 0;
                timer1.Stop();
            }
            else
            {
                if (((cos_x + cos_w) > target_x && (cos_x + cos_w) < (target_x + target_w)) && (cos_y > target_y && cos_y < (target_y + target_h)))
                {
                    MessageBox.Show("Din păcate, ai atins peretele! Încearcă din nou :(", "Ai pierdut");//punct dreapta sus
                    cos.Location = new Point(startx, starty);
                    t = 0;
                    timer1.Stop();
                }
                else
                {
                    if ((cos_x > target_x && cos_x < (target_x + target_w)) && ((cos_y + cos_h) > target_y && (cos_y + cos_h) < (target_y + target_h)))
                    {
                        MessageBox.Show("Din păcate, ai atins peretele! Încearcă din nou :(", "Ai pierdut");//punct stanga  jos
                        cos.Location = new Point(startx, starty);
                        t = 0;
                        timer1.Stop();
                    }
                    else
                    {
                        if (((cos_x + cos_w) > target_x && (cos_x + cos_w) < (target_x + target_w)) && ((cos_y + cos_h) > target_y && (cos_y + cos_h) < (target_y + target_h)))
                        {
                            MessageBox.Show("Din păcate, ai atins peretele! Încearcă din nou :(", "Ai pierdut");//punct dreapta  jos
                            cos.Location = new Point(startx, starty);
                            t = 0;
                            timer1.Stop();
                        }
                    }
                }
            }
        }
        private void check_win()
        {
            int target_x = pictureBox2.Location.X;
            int target_y = pictureBox2.Location.Y;
            int target_w = pictureBox2.Width;
            int target_h = pictureBox2.Height;
            int cos_x = cos.Location.X;
            int cos_y = cos.Location.Y;
            int cos_w = cos.Width;
            int cos_h = cos.Height;

            if ((cos_x > target_x && cos_x < (target_x + target_w)) && (cos_y > target_y && cos_y < (target_y + target_h)))
            {
                //punct stanga sus
                timer1.Stop();
                t = t / 10;
                string mesaj = "FELICITĂRI! Ai rezolvat labirintul în " + t.ToString() + " secunde" + "\nDacă dorești să continui jocul apasă DA, iar dacă dorești să ieși din joc apasă NU";
                var result = MessageBox.Show(mesaj, "Ai câștigat!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Nivel2 f = new Nivel2();
                    f.Show();
                    this.Close();
                }
                if (result == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                if (((cos_x + cos_w) > target_x && (cos_x + cos_w) < (target_x + target_w)) && (cos_y > target_y && cos_y < (target_y + target_h)))
                {
                    //punct dreapta sus
                    timer1.Stop();
                    t = t / 10;
                    string mesaj = "FELICITĂRI! Ai rezolvat labirintul în " + t.ToString() + " secunde"+ "\nDacă dorești să continui jocul apasă DA, iar dacă dorești să ieși din joc apasă NU";
                    var result = MessageBox.Show(mesaj, "Ai câștigat!", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Nivel2 f = new Nivel2();
                        f.Show();
                        this.Close();
                    }
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
                else
                {
                    if ((cos_x > target_x && cos_x < (target_x + target_w)) && ((cos_y + cos_h) > target_y && (cos_y + cos_h) < (target_y + target_h)))
                    {
                        //punct stanga  jos
                        timer1.Stop();
                        t = t / 10;
                        string mesaj = "FELICITĂRI! Ai rezolvat labirintul în " + t.ToString() + " secunde" + "\nDacă dorești să continui jocul apasă DA, iar dacă dorești să ieși din joc apasă NU";
                        var result = MessageBox.Show(mesaj, "Ai câștigat!", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            Nivel2 f = new Nivel2();
                            f.Show();
                            this.Close();
                        }
                        if (result == DialogResult.No)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        if (((cos_x + cos_w) > target_x && (cos_x + cos_w) < (target_x + target_w)) && ((cos_y + cos_h) > target_y && (cos_y + cos_h) < (target_y + target_h)))
                        {
                            //punct dreapta  jos
                            timer1.Stop();
                            t = t / 10;
                            string mesaj = "FELICITĂRI! Ai rezolvat labirintul în " + t.ToString() + " secunde" + "\nDacă dorești să continui jocul apasă DA, iar dacă dorești să ieși din joc apasă NU";
                            var result = MessageBox.Show(mesaj, "Ai câștigat!", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                Nivel2 f = new Nivel2();
                                f.Show();
                                this.Close();
                            }
                            if (result == DialogResult.No)
                            {
                                Close();
                            }

                        }
                    }
                }
            }
        }
        private void check_all_walls()
        {
            check_wall_collision(label1);
            check_wall_collision(label2);
            check_wall_collision(label3);
            check_wall_collision(label4);
            check_wall_collision(label5);
            check_wall_collision(label6);
            check_wall_collision(label7);
            check_wall_collision(label8);
            check_wall_collision(label9);
            check_wall_collision(label10);
            check_wall_collision(label11);
            check_wall_collision(label12);
            check_wall_collision(label13);
            check_wall_collision(label14);
            check_wall_collision(label15);
            check_wall_collision(label16);
        }
        private void action(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                cos.Location = new Point(cos.Location.X, cos.Location.Y - 10);
                check_all_walls();
                check_win();
                if (!timer1.Enabled)
                    timer1.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                cos.Location = new Point(cos.Location.X, cos.Location.Y + 10);
                check_all_walls();
                check_win();
                if (!timer1.Enabled)
                    timer1.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                if (!timer1.Enabled)
                    timer1.Start();
                cos.Location = new Point(cos.Location.X - 10, cos.Location.Y);
                check_all_walls();
                check_win();

            }
            if (e.KeyCode == Keys.Right)
            {
                if (!timer1.Enabled)
                    timer1.Start();
                cos.Location = new Point(cos.Location.X + 10, cos.Location.Y);
                check_all_walls();
                check_win();

            }
        }

        int t = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            timp.Text = (t / 10).ToString();
        }
    }
}
