using System;
using System.Collections.Generic;
using System.Text;

namespace POCU.NET03_HW.Week_06_ClassesAssignment
{
    class Candelabru
    {
        private BecReglabil[] becuri;

        public Candelabru(params ushort[] puteriMaxime)
        { 
            becuri = new BecReglabil[puteriMaxime.Length];
            for (int i = 0; i < puteriMaxime.Length; i++)
            {
                becuri[i] = new BecReglabil(puteriMaxime[i], 0);
            }
        }
        public bool Aprins
        {
            get
            {
                foreach (BecReglabil bec in becuri)
                {
                    if (bec.Aprins)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public ushort PutereMaxima
        {
            get
            {
                ushort putereMax = 0;
                foreach (BecReglabil bec in becuri)
                {
                    putereMax += bec.PutereaMaxima;
                }
                return putereMax;
            }
        }

        public ushort PutereCurenta
        {
            get
            {
                ushort putereCurenta = 0;
                foreach (BecReglabil bec in becuri)
                {
                    putereCurenta += bec.PutereaCurenta;
                }
                return putereCurenta;
            }
        }

        public void Stinge()
        {
            foreach (BecReglabil bec in becuri)
            {
                bec.Stinge();
            }
        }

        public void Aprinde()
        {
            foreach (BecReglabil bec in becuri)
            {
                bec.Aprinde();
            }
        }

        public void MaresteLumina(ushort maresteCu)
        {
            foreach (BecReglabil bec in becuri)
            {
                bec.MaresteLumina(maresteCu);
            }
        }

        public void ReduceLumina(ushort reduceCu)
        {
            foreach (BecReglabil bec in becuri)
            {
                bec.ReduceLumina(reduceCu);
            }
        }

        public override string ToString() {
            return "{Candelabrul cu " + becuri.Length + " becuri}";
        }

        public static void RunExercise()
        {
            Candelabru cl3 = new Candelabru(60, 75, 100);
            Candelabru cl5 = new Candelabru(40, 60, 75, 75, 100);
            Candelabru[] candelabre = { cl3, cl5 };
            foreach (Candelabru cl in candelabre)
            {
                Console.WriteLine(cl.Aprins ? $"{cl} este aprins" : $"{cl} nu este aprins");
                Console.WriteLine($"Puterea maxima a {cl} este {cl.PutereMaxima}");
                Console.WriteLine($"Puterea curenta a {cl} este {cl.PutereCurenta}");
                cl.Aprinde();
                Console.WriteLine("Dupa aprindere: " + (cl.Aprins ? $"{cl} este aprins" : $"{cl} nu este aprins"));
                Console.WriteLine($"Dupa aprindere: Puterea curenta a {cl} este {cl.PutereCurenta}");
                cl.Stinge();
                Console.WriteLine("Dupa stringere: " + (cl.Aprins ? $"{cl} este aprins" : $"{cl} nu este aprins"));
                cl.MaresteLumina(80);
                Console.WriteLine("Dupa marire: " + (cl.Aprins ? $"{cl} este aprins" : $"{cl} nu este aprins"));
                Console.WriteLine($"Dupa marire: Puterea curenta a {cl} este {cl.PutereCurenta}");
                cl.ReduceLumina(50);
                Console.WriteLine("Dupa reducere: " + (cl.Aprins ? $"{cl} este aprins" : $"{cl} nu este aprins"));
                Console.WriteLine($"Dupa reducere: Puterea curenta a {cl} este {cl.PutereCurenta}");
            }
        }

    }
}
