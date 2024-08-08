Console.WriteLine($"Insira a nota do aluno.");
var input = int.TryParse(Console.ReadLine(), out int nota);

if (nota > 5 && nota <= 10)
    Console.WriteLine($"o aluno foi aprovado.");
else if (new[] {4, 5}.Contains(nota)) 
    Console.WriteLine($"o aluno está de recuperação.");
else if (nota < 4)
    Console.WriteLine($"o aluno foi reprovado.");
else
    Console.WriteLine($"Nota inválida.");


