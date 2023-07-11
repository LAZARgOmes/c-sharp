using System;

class Aula14{
    static void Main(){
        string produto1 = "Carro";
        string produto2 = "Moto";
        string produto3 = "Ônibus";
        string escolha;
        Console.WriteLine("Escolha seu produto:\n1\t{0}\n2\t{1}\n3\t{2}",produto1,produto2,produto3);
        escolha = Console.ReadLine();

        if((escolha == "carro")||(escolha == "Carro")){
            Console.WriteLine("Parabéns!");
        }
        else if((escolha == "moto")||(escolha == "Moto")){
            Console.WriteLine("Parabéns pela Moto");
        }
        else{
            Console.WriteLine("Só resta o Ônibus");
        }

    }
}