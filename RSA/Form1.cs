using System;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string r1 = "972346137165803391741260008403144412592226901362682364547049471060890442818028662684991378613392752649526029617987887831986881792545318603515625",
            //       d1 = "22983739567277988919042289396428710786145324792192232804170083110737035787583849273823365929873717251150764764138805660660379086529618183783224083851254755909296311355783335836143389327521201376549033723148092483179600710950306613747200493079222995914375542032098763712401202494234918921944013939247333847767",
            //       n1 = "73978911732176026833167368994754912842905264174868749338422455012684833941285514850118959086781027402141524084571780720250595184767208529052252519896226263393823641657376749316226639741705539840030421180292436487353552514212712139817343632730311183906689281114374406278900745155401497285690088598371426402521";
            //BigInteger r11 = BigInteger.Parse(r1),
            //           d11 = BigInteger.Parse(d1),
            //           n11 = BigInteger.Parse(n1);
            //Crypted.Text = Convert.ToString(BigInteger.ModPow(r11, d11, n11));

            //int[] bit = tenintwo('0');
            //for (int i = 0; i < 9; i++)
            //    Crypted.Text += Convert.ToString(bit[i]);
        }

        string num = "0123456789",
               abc = "0123456789абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        BigInteger p, q, n, d, Fi;
        //int E;
        BigInteger E;
        int num_bits = 512;

        private void TxtChanged(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            t = (TextBox)(sender as Control);
            if (t.TextLength != 0)
            {
                int cur = t.SelectionStart;
                if (t.Text[0] == '0')
                {
                    StringBuilder str = new StringBuilder(t.Text);
                    str.Remove(0, 1);
                    t.Clear();
                    t.Text += str;
                }
                for (int i = 0; i < t.TextLength; i++)
                    if (num.IndexOf(t.Text[i]) == -1)
                    {
                        StringBuilder str = new StringBuilder(t.Text);
                        str.Remove(i, 1);
                        t.Clear();
                        t.Text += str;
                        t.SelectionStart = cur - 1;
                    }
            }
        }

        private void p_text_TextChanged(object sender, EventArgs e)
        {
            TxtChanged(sender, e);
        }

        private void q_text_TextChanged(object sender, EventArgs e)
        {
            TxtChanged(sender, e);
        }

        private void d_text_TextChanged(object sender, EventArgs e)
        {
            TxtChanged(sender, e);
        }

        private void n_text_TextChanged(object sender, EventArgs e)
        {
            TxtChanged(sender, e);
        }

        private void bits_TextChanged(object sender, EventArgs e)
        {
            TxtChanged(sender, e);
            num_bits = int.Parse(bits.Text);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            p = Gen_512();
            while (!MillerRabin(p))
                p = Gen_512();
            //p = 3557;
            p_text.Text = Convert.ToString(p);

            q = Gen_512();
            while (!MillerRabin(q) || q == p)
                q = Gen_512();
            //q = 2579;
            q_text.Text = Convert.ToString(q);

            n = p * q;
            n_text.Text = Convert.ToString(n);

            Fi = (p - 1) * (q - 1);

            BigInteger n_copy = n;
            E = n / 3;
            //while (n_copy > 0)
            //{
            //    E++;
            //    n_copy /= 10;
            //}
            //E /= 3;
            while (p == E || q == E || Fi % E == 0 || !MillerRabin(E)) E++;
            e_text.Text = Convert.ToString(E);

            BigInteger x, y;
            d = nod(Fi, E, out x, out y);
            if (y < 0) d = y + Fi;
            else d = y;
            d_text.Text = Convert.ToString(d);
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (IN.TextLength != 0)
            {
                Crypted.Text = "";
                for (int i = 0; i < IN.TextLength; i++)
                {
                    Crypted.Text += Convert.ToString(BigInteger.ModPow(abc.IndexOf(IN.Text[i]) + 13, E, n)) + ' ';
                }
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (Crypted.TextLength != 0)
            {
                OUT.Text = "";
                string s = Crypted.Text;
                while (s.Length > 0)
                {
                    int j = s.IndexOf(' ');
                    string s2 = s.Substring(0, j);
                    s = s.Remove(0, j + 1);
                    BigInteger r = BigInteger.Parse(s2);
                    int c_num;
                    try
                    {
                        c_num = int.Parse(Convert.ToString(BigInteger.ModPow(r, d, n) - 13));
                    }
                    catch
                    {
                        Random rnd = new Random();
                        c_num = rnd.Next(130);
                    }
                    char c = abc[c_num];
                    OUT.Text += c;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IN.Clear();
            OUT.Clear();
            Crypted.Clear();
        }

        private BigInteger Gen_512()
        {
            Random rnd = new Random();
            BigInteger num = 0;
            for (int i = 0; i < num_bits; i++)
            {
                if (rnd.Next(2) != 0)
                    num += BigInteger.Pow(2, i);
            }
            return num;
        }

        private bool MillerRabin(BigInteger n)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            BigInteger t = n - 1;
            int s = 0;
            while (t % 2 == 0)
            {
                t /= 2;
                s += 1;
            }
            for (int i = 0; i < s + 2; i++)
            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] b = new byte[n.ToByteArray().LongLength];
                BigInteger a;
                do
                {
                    rng.GetBytes(b);
                    a = new BigInteger(b);
                }
                while (a < 2 || a >= n - 2);
                BigInteger x = BigInteger.ModPow(a, t, n);
                if (x == 1 || x == n - 1)
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }
            return true;
        }

        private bool CheckProst(int n)
        {
            for (int i = 2; i * i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        private BigInteger nod(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            BigInteger x1, y1;
            BigInteger d = nod(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

    }
}
