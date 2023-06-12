﻿namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente
    {
        public Agencia Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public int Numero { get; set; }
        public string DigitoVerificador { get; set; }
        public decimal Saldo { get; set; }

        public void EfetuarOperacao(decimal valor, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Deposito:
                    Saldo += valor;
                    break;
                case Operacao.Saque:
                    Saldo -= valor;
                    break;
            }
        }
    }
}