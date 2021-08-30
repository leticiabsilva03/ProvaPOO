using System;
using System.Collections.Generic;
using System.Text;

namespace wfaQuestao2
{
    class Saude:Pagtos
    {
        // atributos
        private string m_estabelecimento;
        private double m_vlfatSaude;

        // construtor padrão
        public Saude() : base()
        {
            m_estabelecimento = "";
            m_vlfatSaude = 0.0;
        }

        // construtor com arguemntos
        public Saude(long cpf, double valor, int codigo, string estabelecimento) : base(cpf, valor, codigo)
        {
            m_estabelecimento = estabelecimento;
        
        }

        // getters
        public String getEstabelecimento()
        {
            return m_estabelecimento;
        }
        public double getfaturarSaude()
        {
            return m_vlfatSaude;
        }

        // setters
        public void setEstabelecimento(string estabelecimento)
        {
            m_estabelecimento = estabelecimento;
        }
        public void setfaturarSaude(double vlfatSaude)
        {
            m_vlfatSaude = vlfatSaude;
        }

        // Método para calcular fatura

        // método para gerar o valor da fatura
        public override void faturar()
        {
            m_vlfatSaude = m_valor + (0.12 * m_valor);
            
         }

    }
}
