using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voo1
{
    internal class voo
    {
        private int vooNumero;
        private DateTime data;
        private int passageiros;
        private int[] poltronas = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        public DateTime Data { get => data; set => data = value; }
        public int Passageiros { get => passageiros; set => passageiros = value; }
        public int VooNumero { get => vooNumero; set => vooNumero = value; }
        public int[] Poltronas { get => poltronas; set => poltronas = value; }

        public voo(int vooNumero, DateTime data, int passageiros)
        {
            this.vooNumero = vooNumero;
            this.data = data;
            this.passageiros = passageiros;
        }

        public poltronaDisponivel(int num)
        {
            int qtdPoltona = Poltronas.Length;
            for (int i = 0; i < qtdPoltona; i++)
            {
                if (num == i)
                {

                }
            }
        }
    }
}
