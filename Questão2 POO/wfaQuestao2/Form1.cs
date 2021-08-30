using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaQuestao2
{
    public partial class Form1 : Form
    {

        private List<Saude> listaPagamentosSaude;
        private List<Alimentacao> listaPagamentosAlimentacao;

        private Saude m_pagtosSaude;
        private Alimentacao m_pagtosAlimentacao;

        private String c_cpf;
        private String v_valor;
        private String c_codigo;
        private String d_descricao;
        private String e_estabelecimento;

        public Form1()
        {
            InitializeComponent();

            listaPagamentosSaude = new List<Saude>();
            listaPagamentosAlimentacao = new List<Alimentacao>();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Botão Saúde
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox2.Text != "")
            {
                int index = -1;
                foreach (Saude pagtosSaude in listaPagamentosSaude)
                {
                    if (pagtosSaude.getCPF() == long.Parse(textBox1.Text) & pagtosSaude.getCod() == int.Parse(textBox3.Text))
                        {
                        index = listaPagamentosSaude.IndexOf(pagtosSaude); ;
                    }
                }

                m_pagtosSaude = new Saude();

                m_pagtosSaude.setCPF(long.Parse(textBox1.Text));
                m_pagtosSaude.setValor(double.Parse(textBox2.Text));
                m_pagtosSaude.setCod(int.Parse(textBox3.Text));
                m_pagtosSaude.setEstabelecimento(textBox4.Text);

                if (index < 0)
                {
                    listaPagamentosSaude.Add(m_pagtosSaude);

                    MessageBox.Show("Dados do pagamento salvos!");

                }
                else
                {

                    listaPagamentosSaude[index] = m_pagtosSaude;

                    MessageBox.Show("Dados do pagamento atualizados!");

                }


                MessageBox.Show("\t\tCadastro Realizado: \n\n" + m_pagtosSaude);
            }
            else
            {
                MessageBox.Show("Inserir dados!");
            }
        }

        // Botão Alimentacao
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "")
            {
                int index = -1;
                foreach (Alimentacao pagtosAlimentacao in listaPagamentosAlimentacao)
                {
                    if (pagtosAlimentacao.getCPF() == long.Parse(textBox1.Text) & pagtosAlimentacao.getCod() == int.Parse(textBox3.Text))
                    {
                        index = listaPagamentosAlimentacao.IndexOf(pagtosAlimentacao); ;
                    }
                }

                m_pagtosAlimentacao = new Alimentacao();

                m_pagtosAlimentacao.setCPF(long.Parse(textBox5.Text));
                m_pagtosAlimentacao.setValor(double.Parse(textBox6.Text));
                m_pagtosAlimentacao.setCod(int.Parse(textBox7.Text));
                m_pagtosAlimentacao.setDescricao(textBox8.Text);

                if (index < 0)
                {
                    listaPagamentosAlimentacao.Add(m_pagtosAlimentacao);

                    MessageBox.Show("Dados do pagamento salvos!");

                }
                else
                {

                    listaPagamentosAlimentacao[index] = m_pagtosAlimentacao;

                    MessageBox.Show("Dados do pagamento atualizados!");

                }


                MessageBox.Show("\t\tCadastro Realizado: \n\n" + m_pagtosAlimentacao);
            }
            else
            {
                MessageBox.Show("Inserir dados!");
            }
        }

        // Botão Gerar Relatório
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Saude pagtosSaude in listaPagamentosSaude)
            {

            }
        }

       
    }
}
