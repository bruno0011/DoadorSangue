int numerodigitado;

Console.Write("Qual a sua idade:");
numerodigitado = Convert.ToInt32(Console.ReadLine());

if (numerodigitado > 80)
{
Console.WriteLine("Você não pode ser doador de sangue.");
}

else if (numerodigitado < 15 )
{
Console.WriteLine("Você não pode ser doador de sangue.");
}
else if (numerodigitado > 15)
{
Console.WriteLine("Você pode ser doador de sangue.");
}
