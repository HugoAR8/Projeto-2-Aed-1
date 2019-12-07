using System;
using System.IO;
namespace Sistema {
 class DB {
  
  private Paciente[] pacientes = new Paciente[20];
  private Consulta[] consultas = new Consulta[20];
  private Medico[] medicos = new Medico[20];

  public DB() {

  }


  //--------------- Bloco Pacientes

  public void listarPacientes() {
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


  public void buscarPaciente(string nome) {
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

  public void excluirPaciente(string n) {

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

  public void editarPaciente(string nome) {
   Paciente aux = new Paciente();

   for (int i = 0; i < pacientes.Length; i++) {
    aux = pacientes[i];

    if (pacientes[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
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



  public void cadastrarPaciente() {
   Paciente aux = new Paciente();

   Console.WriteLine("Escreva o nome do paciente: ");
   aux.setNome(Console.ReadLine());
   Console.WriteLine("Escreva a idade do paciente: ");
   try{
    aux.setIdade(int.Parse(Console.ReadLine()));
   }
   catch(System.FormatException e){
     Console.WriteLine("A idade tem que ser em numeros inteiros, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
     arrumarIdadePaciente(aux);
   }
   Console.WriteLine("Escreva a altura do paciente: ");
   try{
     aux.setAltura(double.Parse(Console.ReadLine()));
   }
   catch(System.FormatException e){
     Console.WriteLine("A altura tem que ser em numeros quebrados, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
     arrumarAlturaPaciente(aux);

   }
   Console.WriteLine("Escreva o peso do paciente: ");
   try{
    aux.setPeso(double.Parse(Console.ReadLine()));
   }
   catch(System.FormatException e){
     Console.WriteLine("A altura tem que ser em numeros quebrados, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
     arrumarPesoPaciente(aux);

   }
   for (int i = 0; i < pacientes.Length; i++) {

    if (pacientes[i] == null) {
     pacientes[i] = aux;
     break;

    }
   }
  }

  public void arrumarPesoPaciente(Paciente i ){
    bool conseguiu = false;
    while(conseguiu == false){
      try{
        conseguiu = true;
        i.setPeso(double.Parse(Console.ReadLine()));
      }
      catch(System.FormatException e){
        Console.WriteLine("O peso tem que ser em numeros quebrados, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
       conseguiu = false;
      }
    }
  }

  

  public void arrumarAlturaPaciente(Paciente i ){
    bool conseguiu = false;
    while(conseguiu == false){
      try{
        conseguiu = true;
        i.setAltura(double.Parse(Console.ReadLine()));
      }
      catch(System.FormatException e){
        Console.WriteLine("A altura tem que ser em numeros quebrados, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
       conseguiu = false;
      }
    }
  }
  public void arrumarIdadePaciente(Paciente i){
    bool conseguiu = false;
    while(conseguiu == false){
      try{
        conseguiu = true;
        i.setIdade(int.Parse(Console.ReadLine()));
      }
      catch(System.FormatException e){
       Console.WriteLine("A idade tem que ser em numeros inteiros, certifique-se que foi isso que você escreveu e escreva novamente a idade do paciente!");
       conseguiu = false;
      }
    }
    }
  

  public void salvarBackup() {
   StreamWriter saida;
   saida = File.AppendText("Backup.txt");
   for (int x = 0; x < pacientes.Length; x++) {
    if (pacientes[x] != null) {
     saida.WriteLine("Paciente numero {0}\nNome do paciente: {1} \nIdade do paciente: {2}\nPeso do paciente: {3}\nAltura do paciente: {4}", x + 1, pacientes[x].getNome(), pacientes[x].getIdade(), pacientes[x].getPeso(), pacientes[x].getAltura());
    }
   }
   saida.Close();
  }

  public void listarBackup() {
    StreamReader entrada;
    string caminho = "Backup.txt";
    entrada = File.OpenText(caminho);

    while(entrada.EndOfStream != true){

     
      Console.WriteLine(entrada.ReadLine());

    } 
    entrada.Close();
  }
  




  //------------------ Bloco Consulta 

  public void marcarConsulta() {
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

   for (int i = 0; i < medicos.Length; i++) {
    if (medicos[i] != null) {
     m = medicos[i];
     if (String.Equals(p.getNome(), aux2)) {
      c.setMedico(m);
      break;
     }
    }
   }


   for (int i = 0; i < pacientes.Length; i++) {
    if (pacientes[i] != null) {
     p = pacientes[i];
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



  public void buscarConsulta() {
   Consulta c = new Consulta();
   Paciente p = new Paciente();
   Console.Write("Nome do Paciente: ");
   string aux = Console.ReadLine();

   for (int i = 0; i < consultas.Length; i++) {
    c = consultas[i];
    p = c.getPaciente();
    if (String.Equals(p.getNome(), aux)) {
     Console.Clear();
     Console.Write("Nome do Paciente: {0}", p.getNome());
     Console.Write("\n");
     Console.Write("Data: {0}", c.getData());
     Console.Write("\n");
     Console.Write("Horário: {0}", c.getHorario());
     Console.Write("\n");
     //Console.Write("Médico: {0}", c.getMedico());

     break;

    }

   }
  }

  public void excluirConsulta() {
   Consulta c = new Consulta();
   Paciente p = new Paciente();
   Console.Write("Nome do Paciente: ");
   string aux = Console.ReadLine();

   for (int i = 0; i < consultas.Length; i++) {
    c = consultas[i];
    p = c.getPaciente();
    if (pacientes[i] != null) {
     if (String.Equals(p.getNome(), aux)) {
      consultas[i] = null;
      break;
     }
    }
   }

  }



  //------------------ Bloco Medico

  public void inicializarMedicos() {
   for (int i = 0; i < medicos.Length; i++) {
    medicos[i] = new Medico();
   }
  }

  public void cadastrarMedico() {
   Medico aux = new Medico();

   Console.WriteLine("Escreva o nome do medico.");
   aux.setNome(Console.ReadLine());
   Console.WriteLine("Escreva a especializacao do medico.");
   aux.setEspecializacao(Console.ReadLine());
   for (int i = 0; i < aux.horarios.Length; i++) {
    Console.WriteLine("Digite o {0}° horário disponivel do médico.", i + 1);
    string auxH = Console.ReadLine();
    aux.setHorario(auxH, i);

   }

   for (int u = 0; u < medicos.Length; u++) {

    if (medicos[u] == null) {
     medicos[u] = aux;
     break;

    }
   }
  }

  public void excluirMedico(string n) {
   for (int i = 0; i < medicos.Length; i++) {
    if (medicos[i] != null) {
     if (medicos[i].getNome() == n) {
      medicos[i] = null;
     }
    }
   }
  }

  public void listarMedicos() {
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

  public void buscarMedico(string nome) {
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
      Console.WriteLine("Horarios :\n ");

      for (int u = 0; u < aux.horarios.Length; u++) {
       Console.WriteLine(aux.horarios[u]);
      }

      break;
     }
    }
   }
  }

  public void editarMedico(string nome) {
   Medico aux = new Medico();

   for (int i = 0; i < pacientes.Length; i++) {
    aux = medicos[i];

    if (medicos[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
      Console.WriteLine("Editar nome do médico: ");
      aux.setNome(Console.ReadLine());
      Console.WriteLine("Editar especialização do médico: ");
      aux.setEspecializacao(Console.ReadLine());
      medicos[i] = aux;
      Console.WriteLine("Editar horarios do médico:");
      for (int x = 0; x < aux.horarios.Length; x++) {
       Console.WriteLine("Edite o {0} horario do medico", x + 1);
       aux.horarios[x] = Console.ReadLine();
      }
      break;
     }
    }
   }
  }

 }
}