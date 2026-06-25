

class Program{
    static void Main(){
        
        double raio = 0;
        double altura = 0;
        Console.Write("Qual é o seu raio?: ");
        raio = double.Parse(Console.ReadLine());
        Console.Write("E qual sua altura?: ");
        altura = double.Parse(Console.ReadLine());
        Console.Write($"Seu volume é {(raio*raio)*3.14*altura}");

    }
}