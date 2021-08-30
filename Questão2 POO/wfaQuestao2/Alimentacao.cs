using System;
using System.Collections.Generic;
using System.Text;

namespace wfaQuestao2
{
    class Alimentacao: Pagtos
    {
        private string m_descricao;
        private double m_lfatAliment;

        // construtor padrão
        public Alimentacao() : base()
        {
            m_descricao = "";
            m_lfatAliment = 0.0;
        }

        // construtor com argumentos
        public Alimentacao(long cpf, double valor, int codigo, string descricao): base(cpf, valor, codigo)
        {
            m_descricao = descricao;
            
        }
        // getters
        public String getDescricao()
        {
            return m_descricao;
        }
        public double getValorFaturaAalimentacao()
        {
            return m_lfatAliment;
        }

        // setters
        public void setDescricao(string descricao)
        {
            m_descricao = descricao;
        }
        public void setValorFaturaAlimentacao(double valorFaturaAlimentacao)
        {
            m_lfatAliment = valorFaturaAlimentacao;
        }

        // Método para calcular fatura

        // método para gerar o valor da fatura
        public override void faturar()
        {
            m_lfatAliment = m_valor + (0.05 * m_valor);
        }

    }
}
