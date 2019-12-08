using System;
namespace Sistema {

  class Medico{
    
    public static Medico[] medicos = new Medico[20];
    private string nome;
    private string especializacao;


    public Medico(){
    }


   public static void cadastrarMedico() {
   Medico aux = new Medico();

   Console.WriteLine("Escreva o nome do medico.");
   aux.setNome(Console.ReadLine());
   Console.WriteLine("Escreva a especializacao do medico.");
   aux.setEspecializacao(Console.ReadLine());
   for (int u = 0; u < medicos.Length; u++) {

    if (medicos[u] == null) {
     medicos[u] = aux;
     break;

    }
   }
  }

  public static void excluirMedico(string n) {
   for (int i = 0; i < medicos.Length; i++) {
    if (medicos[i] != null) {
     if (medicos[i].getNome() == n) {
      medicos[i] = null;
     }
    }
   }
  }

  public static void listarMedicos() {
   Medico aux = new Medico();
   Console.Write("Lista de Medicos:\n");
   Console.Write("\n");

   for (int i = 0; i < medicos.Length; i++) {
    if (medicos[i] != null) {
     aux = medicos[i];
     Console.Write(aux.getNome());
     Console.Write("\n");
    }
   }
  }

  public static void buscarMedico(string nome) {
   Medico aux = new Medico();

   for (int i = 0; i < medicos.Length; i++) {
    aux = medicos[i];
    if (medicos[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
      Console.Clear();
      Console.Write("Nome: {0}", aux.getNome());
      Console.Write("\n");
      Console.Write("Especialização: {0}", aux.getEspecializacao());
      Console.Write("\n");

     }
    }
   }
  }

  public static void editarMedico(string nome) {
   Medico aux = new Medico();

   for (int i = 0; i < Paciente.pacientes.Length; i++) {
    aux = medicos[i];

    if (medicos[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
      Console.WriteLine("Editar nome do médico: ");
      aux.setNome(Console.ReadLine());
      Console.WriteLine("Editar especialização do médico: ");
      aux.setEspecializacao(Console.ReadLine());
      medicos[i] = aux;
      break;
     }
    }
   }
  }

    public string getEspecializacao(){
      return especializacao;
    }

    public void setEspecializacao(string e){
      especializacao = e;
    }

    public string getNome(){
      return nome;
    }

    public void setNome(string n){
      nome = n;
    }
    
  }
}