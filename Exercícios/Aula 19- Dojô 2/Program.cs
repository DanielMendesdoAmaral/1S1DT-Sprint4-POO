/*

Crie uma classe chamada Ingresso, que possui um valor em reais e um método imprimirValor(). Crie uma classe IngressoVIP, que herda de Ingresso e possui um valor adicional. Crie um método que retorne o valor do ingresso VIP (com o adicional incluído). Crie um programa para criar as instâncias de Ingresso e IngressoVIP, mostrando a diferença de preços.

DUPLA:
DANIEL MENDES DO AMARAL
MURILO DELLIZE 

*/

using System;

namespace Aula_19__Dojô_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorNormal=0;
            Ler("Insira o valor do ingresso normal: ", ref valorNormal);
            double valorAdicional=0;
            Ler("Insira o valor adicional do ingresso VIP: ", ref valorAdicional);

            Ingresso ingressoNormal = new Ingresso(valorNormal);
            IngressoVIP ingressoDeBoy = new IngressoVIP(valorNormal, valorAdicional);

            Console.Clear();

            Console.WriteLine($"O valor do ingresso normal é: {ingressoNormal.ImprimirValor()}\nO valor do ingresso VIP é: {ingressoDeBoy.ImprimirValor()}\nA diferença de preço entre os ingressos é de R${ingressoDeBoy.ImprimirValor()-ingressoNormal.ImprimirValor()}.");
        }

        static void Ler(string mensagem, ref double variavel) {
            Console.Write(mensagem);
            variavel = Convert.ToDouble(Console.ReadLine());
        }
    }
}