using System;

namespace Sistema {


 class MainClass {


  public static void Main() {
   DB db = new DB();
   menu(db);

  }

  public static void menu(DB data) {
   DB db = new DB();
   db = data;
   string aux;


   Console.Clear();
   art();
   Console.WriteLine("O que deseja acessar ?");
   Console.WriteLine("Informações dos pacientes (digite 'Pacientes')");
   Console.WriteLine("Informações das consultas (digite 'Consultas')");
   Console.WriteLine("Informações das consultas (digite 'Médicos')");
   Console.WriteLine("Mostrar backup (digite 'Backup')");
   aux = Console.ReadLine();

   
  if(aux == "Backup"){
     Console.Clear();
     db.listarBackup();
   }else{
   if (aux == "Pacientes") {
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("Cadastrar paciente (digite 'Cadastrar')");
    Console.WriteLine("Listar pacientes (digite 'Listar')");
    Console.WriteLine("Buscar paciente (digite 'Buscar')");
    Console.WriteLine("Editar paciente (digite 'Editar')");
    Console.WriteLine("Excluir paciente (digite 'Excluir')");
    Console.WriteLine("Menu");

    aux = (Console.ReadLine());

    if (aux == "Cadastrar") {
     Console.Clear();
     db.cadastrarPaciente();
     db.salvarBackup();
     menu(db);


    } else {
     if (aux == "Listar") {
      Console.Clear();
      db.listarPacientes();
      Console.WriteLine("Menu");
      string i = "";
      while (i != "Menu") {
       i = Console.ReadLine();
      }
      menu(db);

     } else {
      if (aux == "Buscar") {
       Console.Clear();
       Console.WriteLine("Escreva o nome do Paciente: ");
       string paciente = Console.ReadLine();
       db.buscarPaciente(paciente);
       Console.WriteLine("\n");
       Console.WriteLine("Menu");

       //--- escape
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu(db);

      } else {
       if (aux == "Editar") {
        Console.Clear();
        Console.WriteLine("Nome do Paciente: ");
        string editarPaciente = Console.ReadLine();
        db.editarPaciente(editarPaciente);
        db.salvarBackup();
        menu(db);

       } else {
        if (aux == "Excluir") {
         Console.Clear();
         Console.WriteLine("Nome do Paciente: ");
         string excluirPaciente = Console.ReadLine();
         db.excluirPaciente(excluirPaciente);
         menu(db);
         db.salvarBackup();

        } else {
         menu(db);
        }

       }
      }
     }
    }

   } else {
    if (aux == "Consultas") {
    Console.Clear();
    Console.WriteLine("O que deseja fazer ?");
    Console.WriteLine("Marcar consulta (digite 'Marcar')");
    Console.WriteLine("Listar consultas (digite 'Listar')");
    Console.WriteLine("Buscar consulta (digite 'Buscar')");
    Console.WriteLine("Editar consulta (digite 'Editar')");
    Console.WriteLine("Excluir consulta (digite 'Excluir')");
    Console.WriteLine("Menu");

    aux = (Console.ReadLine());

    if (aux == "Marcar") {
     Console.Clear();
     db.marcarConsulta();
     menu(db);


    } else {
     if (aux == "Listar") {
      Console.Clear();
      db.listarConsultas();
      Console.Write("\n");
      Console.WriteLine("Menu");
      //--- escape
      string i = "";
      while (i != "Menu") {
       i = Console.ReadLine();
       break;
      }
      menu(db);

     } else {
      if (aux == "Buscar") {
       Console.Clear();
       db.buscarConsulta();
       Console.WriteLine("\n");
       Console.WriteLine("Menu");

       //--- escape
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu(db);

      } else {
       if (aux == "Editar") {
        Console.Clear();
        Console.WriteLine("Nome do Paciente: ");
        string editarPaciente = Console.ReadLine();
        db.editarPaciente(editarPaciente);
        menu(db);

       } else {
        if (aux == "Excluir") {
         Console.Clear();
         Console.WriteLine("Nome do Paciente: ");
         string excluirPaciente = Console.ReadLine();
         db.excluirPaciente(excluirPaciente);
         menu(db);

        } else {
         menu(db);
        }

       }
      }
     }
    }


    } else {
     if (aux == "Médicos") {
      Console.Clear();
      Console.WriteLine("O que deseja fazer ?");
      Console.WriteLine("Cadastrar médico (digite 'Cadastrar')");
      Console.WriteLine("Listar médicos (digite 'Listar')");
      Console.WriteLine("Buscar médico (digite 'Buscar')");
      Console.WriteLine("Editar médico (digite 'Editar')");
      Console.WriteLine("Excluir médico (digite 'Excluir')");
      Console.WriteLine("Menu");
      aux = (Console.ReadLine());

      if (aux == "Cadastrar") {
       Console.Clear();
       db.cadastrarMedico();
       menu(db);

      } else {
       if (aux == "Listar") {
        Console.Clear();
        db.listarMedicos();
        Console.WriteLine("Menu");
        string i = "";
        while (i != "Menu") {
         i = Console.ReadLine();
        }
        menu(db);

       } else {
        if (aux == "Buscar") {
         Console.Clear();
         Console.WriteLine("Digite o nome do médico que procura.");
         string auxN = Console.ReadLine();
         db.buscarMedico(auxN);
         Console.WriteLine("Menu");
         string i = "";
         while (i != "Menu") {
          i = Console.ReadLine();
         }
         menu(db);


        } else {
         if (aux == "Editar") {
          Console.Clear();
          Console.WriteLine("Digite o nome do médico que procura.");
          string auxN = Console.ReadLine();
          db.editarMedico(auxN);
          menu(db);

         } else {
          if (aux == "Excluir") {
           Console.Clear();
           Console.WriteLine("Digite o nome do médico que deseja excluir");
           db.excluirMedico(Console.ReadLine());
           menu(db);

          } else {
           menu(db);
          }
         }
        }


       }
      }
     }
    }


    }

    menu(db);

   }
  }

  public static void art() {

    Console.WriteLine(@"  
  __  __          _   ____  _           
 |  \/  | ___  __| | |  _ \| |_   _ ___ 
 | |\/| |/ _ \/ _` | | |_) | | | | / __|
 | |  | |  __/ (_| | |  __/| | |_| \__ \
 |_|  |_|\___|\__,_| |_|   |_|\__,_|___/
                                        ");
                                        
  }
 }
}
