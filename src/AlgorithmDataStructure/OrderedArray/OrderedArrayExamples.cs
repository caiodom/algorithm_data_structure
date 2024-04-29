using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedArray
{
    public class OrderedArrayExamples
    {
        private int _capacidade=0;
        private int _ultimaPosicao = 0;
        private int[] _valores;


        public OrderedArrayExamples(int capacidade)
        {
            _capacidade = capacidade;
            _valores = new int[capacidade];
        }


        public void Imprime()
        {
            if (_ultimaPosicao == -1) 
                Console.WriteLine("Capacidade atingida");
            else
                for (int i = 0; i < (_ultimaPosicao + 1) ; i++)
                       Console.Write($"{i} - {_valores[i]}");
                
        }

       public void Insere(int valor)
        {
            if(_ultimaPosicao==_capacidade)
            {
                Console.WriteLine("Capacidade máxima atiginda");
                return;
            }

            int posicao = 0;

            for (int i = 0; i < (_ultimaPosicao + 1); i++)
            {
                posicao = i;
                if (_valores[i] > valor)
                    break;
                if (i == _ultimaPosicao)
                    posicao = i + 1;
            }

            var x = _ultimaPosicao;
            while (x >= posicao)
            {
                _valores[x + 1] = _valores[x];
                x -= 1;
            }

            _valores[posicao] = valor;
            _ultimaPosicao += 1;
        }


        public int PesquisaLinear(int valor)
        {
            for (int i = 0; i < (_ultimaPosicao+1); i++)
            {
                if (_valores[i] > valor)
                    return -1;
                if (_valores[i] == valor)
                    return i;
            }

            return -1;
        }

        public int PesquisaBinaria(int valor)
        {
            int limiteInferior = 0;
            int limiteSuperior = _ultimaPosicao;

            while (true)
            {
                int posicaoAtual = (limiteInferior + limiteSuperior) / 2;

                if (_valores[posicaoAtual] == valor)
                    return posicaoAtual;
                else if (limiteInferior > limiteSuperior)
                    return -1;
                else
                {
                    if (_valores[posicaoAtual] < valor)
                        limiteInferior = posicaoAtual + 1;
                    else
                        limiteSuperior = posicaoAtual - 1;
                }

            }
        }

        public int Excluir(int valor)
        {
            var posicao = PesquisaBinaria(valor);

            if (posicao == -1)
                return -1;
            else
            {
                for (int i = posicao; i < _ultimaPosicao; i++)
                {
                    _valores[i] = _valores[i + 1];
                }

                _ultimaPosicao -= 1;
            }

            return 1;
        }

    }

}
