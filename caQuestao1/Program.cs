using System;

namespace caQuestao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data(11, 3, 1999);
            Data data2 = new Data(23, 6, 2004);
            Data data3 = new Data(7, 7, 2012);

            Console.WriteLine("Comparando Datas: \n\nPrimeira data: " + data1.getDia() + "/" +
                data1.getMes() + "/" + data1.getAno() + "Segunda data: " + data2.getDia() + "/" + data2.getMes()+"/"+data2.getAno());
            data1.compara(data2);

            Console.WriteLine("Verificando se ano é bissexto: " + data1.isBissexto());
            data2.isBissexto();

            Console.WriteLine("O mês da data é: " + data1.getMesExtenso());

        }
    }
}
