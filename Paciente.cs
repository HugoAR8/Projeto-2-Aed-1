using System;
namespace Sistema {

 class Paciente {
  public static Paciente[] pacientes = new Paciente[20];
  private string nome;
  private int idade;
  private double peso;
  private double altura;

  public Paciente() {}

  public void cadastrarPaciente() {
   Paciente aux = new Paciente();
   Console.WriteLine("Escreva o nome do paciente: ");
   aux.setNome(Console.ReadLine());
   Console.WriteLine("Escreva a idade do paciente: ");
   aux.setIdade(int.Parse(Console.ReadLine()));
   Console.WriteLine("Escreva o peso do paciente: ");
   aux.setPeso(double.Parse(Console.ReadLine()));
   Console.WriteLine("Escreva a altura do paciente: ");
   aux.setAltura(double.Parse(Console.ReadLine()));

   for (int i = 0; i < pacientes.Length; i++) {

    if (pacientes[i] == null) {
     pacientes[i] = aux;
     break;

    }
   }
  }


  public static void buscarPaciente(string nome) {
   Paciente aux = new Paciente();

   for (int i = 0; i < pacientes.Length; i++) {
    aux = pacientes[i];

    if (String.Equals(aux.getNome(), nome)) {
     Console.Clear();
     Console.Write("Nome: {0}", aux.getNome());
     Console.Write("\n");
     Console.Write("Idade: {0}", aux.getIdade());
     Console.Write("\n");
     Console.Write("Peso: {0}", aux.getPeso());
     Console.Write("\n");
     Console.Write("Altura: {0}", aux.getAltura());

     break;

    }
   }
  }

  public static void listarPacientes() {

   Paciente aux = new Paciente();
   Console.Write("Lista de Pacientes:\n");
   Console.Write("\n");

   for (int i = 0; i < pacientes.Length; i++) {
    if (pacientes[i] != null) {
     aux = pacientes[i];
     Console.Write(aux.getNome());
     Console.Write("\n");
    }
   }
  }

  public static void editarPaciente(string nomePaciente) {

   for (int i = 0; i < pacientes.Length; i++) {
    Paciente aux = new Paciente();
    aux = pacientes[i];

    if (pacientes[i] != null) {

     if (String.Equals(aux.getNome(), nomePaciente)) {

      Console.WriteLine("Editar nome do paciente: ");
      aux.setNome(Console.ReadLine());
      Console.WriteLine("Editar idade do paciente: ");
      aux.setIdade(int.Parse(Console.ReadLine()));
      Console.WriteLine("Editar altura do paciente: ");
      aux.setAltura(double.Parse(Console.ReadLine()));
      Console.WriteLine("Editar peso do paciente: ");
      aux.setPeso(double.Parse(Console.ReadLine()));

      pacientes[i] = aux;
      break;
     }
    }
   }
  }

  public static void excluirPaciente(string n) {

   for (int i = 0; i < pacientes.Length; i++) {
    Paciente aux = new Paciente();
    aux = pacientes[i];

    if (pacientes[i] != null) {

     if (String.Equals(aux.getNome(), n)) {
      pacientes[i] = null;
      break;
     }
    }
   }
  }



  public string getNome() {
   return nome;
  }

  public void setNome(string n) {
   nome = n;
  }

  public int getIdade() {
   return idade;
  }

  public void setIdade(int i) {
   idade = i;
  }

  public double getPeso() {
   return peso;
  }

  public void setPeso(double p) {
   peso = p;
  }

  public double getAltura() {
   return altura;
  }

  public void setAltura(double a) {
   altura = a;
  }

 }
}