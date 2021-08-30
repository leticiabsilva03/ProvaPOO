using System;
using System.Collections.Generic;
using System.Text;

namespace caQuestao1
{
    class Data
    {
        // atributos
        private int d_dia;
        private int m_mes;
        private int a_ano;

        private string m_mesExtenso;
        private Data clone;
        
        // construtor padrão
        public Data()
        {
            d_dia = 0;
            m_mes = 0;
            a_ano = 0;
        }

        // construtor com argumentos
        public Data (int dia, int mes, int ano)
        {
            d_dia = dia;
            m_mes = mes;
            a_ano = ano;
        }

        // getters
        public int getDia()
        {
            return d_dia;
        }
        public int getMes()
        {
            return m_mes;
        }
        public int getAno()
        {
            return a_ano;
        }

        // setters

        public void setDia(int dia)
        {
            d_dia = dia;
        }
        public void setMes(int mes)
        {
            m_mes = mes;
        }
        public void setAno(int ano)
        {
            a_ano = ano;
        }

        // metodos
               
        // Método para retornar verdadeiro se o ano for bissexto
        public bool isBissexto()
        {
            if ((a_ano % 4 == 0 && a_ano%100 !=0)|| a_ano%400==0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        // Método para retornar o mês corrente por extenso
        public string getMesExtenso()
        {
            switch(m_mes)
            {
                case 1:
                    m_mesExtenso = "Janeiro";
                    break;
                case 2:
                    m_mesExtenso = "Fevereiro";
                    break;
                case 3:
                    m_mesExtenso = "Março";
                    break;
                case 4:
                    m_mesExtenso = "Abril";
                    break;
                case 5:
                    m_mesExtenso = "Maio";
                    break;
                case 6:
                    m_mesExtenso = "Junho";
                    break;
                case 7:
                    m_mesExtenso = "Julho";
                    break;
                case 8:
                    m_mesExtenso = "Agosto";
                    break;
                case 9:
                    m_mesExtenso = "Setembro";
                    break;
                case 10:
                    m_mesExtenso = "Outubro";
                    break;
                case 11:
                    m_mesExtenso = "Novembro";
                    break;
                default:
                    m_mesExtenso = "Dezembro";
                    break;
            }
            return (m_mesExtenso);
            
        }
        // Comparação de Data
        public int compara(Data data)
        {
            if (a_ano==data.getAno())
            {
                if(m_mes==data.getMes())
                {
                    if (d_dia==data.getDia())
                    {
                        return 0;
                    }
                    else
                    {
                        if(d_dia>data.getDia())
                        {
                            return (1);
                        }
                        else
                        {
                            return (-1);
                        }
                    }
                    
                    
                }
                else
                {
                    if(m_mes>data.getMes())
                    {
                        return (1);
                    }
                    else
                    {
                        return (-1);
                    }
                }
            }
            else
            {
                if(a_ano>data.getAno())
                {
                    return 1;
                }
                else
                {
                    return (-1);
                }
            }
        }

        // Metodo de clonagem
        public int Data clone ()
        {
            clone = new Data(this.d_dia, this.m_mes, this.a_ano);
            return (clone);
        }
    }
}
