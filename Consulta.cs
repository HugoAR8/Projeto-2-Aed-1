using System;
namespace Sistema {


 class Consulta {

  public static Consulta[] consultas = new Consulta[20];
  private Paciente paciente = new Paciente();
  private Medico medico = new Medico();
  private string data;
  private string horario;

  public Consulta() {

  }

  public static void marcarConsulta() {
   Consulta c = new Consulta();
   Paciente p = new Paciente();
   Medico m = new Medico();


   Console.WriteLine("Digite o nome do paciente: ");
   string aux = Console.ReadLine();
   Console.WriteLine("Digite a data da consulta: ");
   c.setData(Console.ReadLine());
   Console.WriteLine("Digite a hora da consulta: ");
   c.setHorario(Console.ReadLine());
   Console.WriteLine("Médico responsável: ");
   string aux2 = (Console.ReadLine());

   for (int i = 0; i < Medico.medicos.Length; i++) {
    if (Medico.medicos[i] != null) {
     m = Medico.medicos[i];
     if (String.Equals(p.getNome(), aux2)) {
      c.setMedico(m);
      break;
     }
    }
   }


   for (int i = 0; i < Paciente.pacientes.Length; i++) {

    if (Paciente.pacientes[i] != null) {
     p = Paciente.pacientes[i];
     if (String.Equals(p.getNome(), aux)) {
      c.setPaciente(p);
      break;
     }
    }
   }

   for (int i = 0; i < consultas.Length; i++) {
    if (consultas[i] == null) {
     consultas[i] = c;
     break;

    }
   }

  }

  public void listarConsultas() {
   Consulta c = new Consulta();
   Paciente p = new Paciente();
   Console.Write("Consultas Marcadas:\n");
   Console.Write("\n");

   for (int i = 0; i < consultas.Length; i++) {
    if (consultas[i] != null) {
     c = consultas[i];
     p = c.getPaciente();
     Console.Write("Nome do Paciente: {0}", p.getNome());
     Console.Write("\n");
     Console.Write("Data: {0}", c.getData());
     Console.Write("\n");
     Console.Write("Horário: {0}", c.getHorario());
     Console.Write("\n");
     Console.Write("Médico Responsável: {0}", c.getMedico());
     Console.Write("\n");
     Console.Write("\n");
    }
   }
  }

  public void setPaciente(Paciente p) {
   this.paciente = p;
  }

  public Paciente getPaciente() {
   return paciente;
  }

  public void setData(string d) {
   this.data = d;
  }


  public string getData() {
   return data;
  }

  public void setHorario(string h) {
   this.horario = h;
  }

  public string getHorario() {
   return horario;
  }

  public void setMedico(Medico m) {
   this.medico = m;
  }

  public Medico getMedico() {
   return medico;
  }

 }
}