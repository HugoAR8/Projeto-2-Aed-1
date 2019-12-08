using System;
using System.IO;
namespace Sistema {
 class DB {
  public static Paciente[] pacientes = new Paciente[20];
  private Consulta[] consultas = new Consulta[20];
  public static Medico[] medicos = new Medico[20];

  public DB() {
 }

 public static void salvarBackup() {
   StreamWriter saida;
   saida = File.AppendText("Backup.txt");
   for (int x = 0; x < Paciente.pacientes.Length; x++) {
    if (Paciente.pacientes[x] != null) {
     saida.WriteLine("Paciente numero {0}\nNome do paciente: {1} \nIdade do paciente: {2}\nPeso do paciente: {3}\nAltura do paciente: {4}", x + 1, Paciente.pacientes[x].getNome(), Paciente.pacientes[x].getIdade(), Paciente.pacientes[x].getPeso(), Paciente.pacientes[x].getAltura());
    }
   }
   saida.Close();
  }

  public static void listarBackup() {
    StreamReader entrada;
    string caminho = "Backup.txt";
    entrada = File.OpenText(caminho);

    while(entrada.EndOfStream != true){

     
      Console.WriteLine(entrada.ReadLine());

    } 
    entrada.Close();
  }
  
}
}