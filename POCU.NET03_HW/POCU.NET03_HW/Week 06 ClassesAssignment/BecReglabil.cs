using System;
using System.Collections.Generic;
using System.Text;

namespace POCU.NET03_HW.Week_06_ClassesAssignment
{
    public class BecReglabil
    {
        private ushort _putereaMaxima, _putereaCurenta;
        public BecReglabil(ushort putereMaxima, ushort putereCurenta) {
            _putereaCurenta = putereCurenta;
            _putereaMaxima = putereMaxima;
        }

        public ushort PutereaCurenta { get { return _putereaCurenta; } }
        public ushort PutereaMaxima { get { return _putereaMaxima; } }
        public bool Aprins { get { return _putereaCurenta > 0; } }
        public void Stinge() { _putereaCurenta = 0; }
        public void Aprinde() { _putereaCurenta = _putereaMaxima; }

        public void MaresteLumina(ushort maresteCu) {
            ushort rezultat = (ushort) (_putereaCurenta + maresteCu);
            if (rezultat > _putereaMaxima)
                _putereaCurenta = _putereaMaxima;
            else
                _putereaCurenta = rezultat;
        }

        public void ReduceLumina(ushort reduceCu) {
            ushort rezultat = (ushort)(_putereaCurenta - reduceCu);
            if (rezultat < 0)
                _putereaCurenta = 0;
            else
                _putereaCurenta = rezultat;
        }


    }
}
