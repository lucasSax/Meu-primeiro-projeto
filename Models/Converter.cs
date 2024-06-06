using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerConsole.Models
{
    public class Converter
    {
        private int _escolha;
        private decimal _cotacaoDaMoeda;
        private decimal _valorDoMontante;

        public int Escolha
        {
            get
            {
                return _escolha;
            }

            set
            {

                if (value < 1 && value > 3)
                {
                    throw new ArgumentException("Digite um valor válido");
                }

                _escolha = value;

            }

        }

        public decimal CotacaoDaMoeda
        {
            get => _cotacaoDaMoeda;


            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor da cotação não pode ser 0 e nem ter valor negativo ");
                }

                _cotacaoDaMoeda = value;
            }
        }
        
        public decimal ValorDoMontante
        {  
            get => _valorDoMontante;


            set
            {
                
                if (value <= 0)
                {
                    throw new ArgumentException("O valor da cotação não pode ser 0 e nem ter valor negativo ");
                }

                _valorDoMontante = value;
            }


        }
        
        public decimal CalculoDeConversao()
        {
           
          decimal resultado = _cotacaoDaMoeda * _valorDoMontante;
           
          return resultado;
        }

    }
}