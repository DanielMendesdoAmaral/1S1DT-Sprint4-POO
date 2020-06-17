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


/*
vc consegue rodar ele?

vou tentar ontem eu n consegui

acho q é pq falatam arquivos pra vc

não consigo mas eu consigo ver vc danso o dot net 

Insira o valor do ingresso normal: 10
Insira o valor adicional do ingresso VIP: 5
O valor do ingresso normal é: 10
O valor do ingresso VIP é: 15

ah ta blz então

é só isso então

ss kkk

qual a logica desse ser em trio é bem simple e o outroais trabalhoso era em dupla

tambem nao sei mano kkkk
da calculadora foi treta e foi sozinho

vou subir la mano e explicar a demora kkkk

blz sobe ai eu subo tbm

ta vou te mandar o link

fecho 

adeut

ate mais mano

so tira um print ai q nois tava junto

pronto pronto ate mano

ate mano valeu ai 
*/