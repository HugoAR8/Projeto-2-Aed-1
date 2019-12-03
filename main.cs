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

   Console.WriteLine("Pacientes");
   Console.WriteLine("Consultas");
   Console.WriteLine("Médicos");
   aux = Console.ReadLine();

   if (aux == "Pacientes") {
    Console.Clear();
    Console.WriteLine("Cadastrar");
    Console.WriteLine("Listar");
    Console.WriteLine("Buscar");
    Console.WriteLine("Editar");
    Console.WriteLine("Excluir");
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
    Console.WriteLine("Marcar");
    Console.WriteLine("Listar");
    Console.WriteLine("Buscar");
    Console.WriteLine("Editar");
    Console.WriteLine("Excluir");
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
      Console.WriteLine("Cadastrar");
      Console.WriteLine("Listar");
      Console.WriteLine("Buscar");
      Console.WriteLine("Editar");
      Console.WriteLine("Excluir");
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
