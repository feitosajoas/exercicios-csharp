String maMatricula;
 Double maAltura;

 String meMatricula;
 Double meAltura;

 String Matricula;
 Double Altura;

 Console.WriteLine("Determina o maior aluno e o menor aluno");
 Console.Write("Informe a matricula do aluno: ");
 Matricula = Console.ReadLine();
 Console.Write("Informe a altura do aluno: ");
 Altura = Convert.ToDouble(Console.ReadLine());

 maAltura = Altura;
 meAltura = Altura;
 maMatricula = Matricula;
 meMatricula = Matricula;
 int i = 1;
 while (i < 5)
 {
 Console.Write("Informe a matricula do aluno: ");
 Matricula = Console.ReadLine();
 Console.Write("Informe a altura do aluno: ");
 Altura = Convert.ToDouble(Console.ReadLine());
 if(maAltura < Altura)
 {
 maMatricula = Matricula;
 maAltura = Altura;
 }

 if (meAltura > Altura)
 {
 meMatricula = Matricula;
 meAltura = Altura;
 }
 i++;
 }
 Console.WriteLine("Maior aluno");
 Console.WriteLine("Matricula: {0}, Altura: {1}", maMatricula, maAltura);
 Console.WriteLine("Menor aluno");
 Console.WriteLine("Matricula: {0}, Altura: {1}", meMatricula, meAltura);
 Console.ReadKey();