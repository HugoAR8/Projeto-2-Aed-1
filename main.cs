using System;

namespace Sistema {


 class MainClass {


  public static void Main() {
   string aux;

   Console.Clear();
   art();
   Console.WriteLine("O que deseja acessar ?");
   Console.WriteLine("Informações dos pacientes (digite 'Pacientes')");
   Console.WriteLine("Informações das consultas (digite 'Consultas')");
   Console.WriteLine("Informações das consultas (digite 'Medicos')");
   Console.WriteLine("Mostrar backup (digite 'Backup')");

   aux = Console.ReadLine();

   if(aux == "Backup"){
     Console.Clear();
     DB.listarBackup();
     Console.WriteLine("Deseja voltar para o menu ?(Digite 'Menu' caso a resposta seja sim)");
     aux = Console.ReadLine();
     if(aux == "Menu"){
      menu();
     }
   }
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
     Paciente p = new Paciente();
     Console.Clear();
     p.cadastrarPaciente();
     menu();

    } else {
     if (aux == "Listar") {
      Console.Clear();
      Paciente.listarPacientes();
      Console.WriteLine("Menu");

      //--- escape Listar
      string i = "";
      while (i != "Menu") {
       i = Console.ReadLine();
      }
      menu();

     } else {
      if (aux == "Buscar") {
       Console.Clear();
       Console.WriteLine("Escreva o nome do Paciente: ");
       string paciente = Console.ReadLine();
       Paciente.buscarPaciente(paciente);
       Console.WriteLine("\n");
       Console.WriteLine("Menu");

       //--- escape Buscar
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu();

      } else {
       if (aux == "Editar") {
        Console.Clear();
        Console.WriteLine("Nome do Paciente: ");
        string nomePaciente = Console.ReadLine();
        Paciente.editarPaciente(nomePaciente);

        menu();
       } else {
        if (aux == "Excluir") {
         Console.Clear();
         Console.WriteLine("Nome do Paciente: ");
         string excluirPaciente = Console.ReadLine();
         Paciente.excluirPaciente(excluirPaciente);
         menu();

        } else {
         menu();
        }
       }
      }
     }
    }


   } else {
    if (aux == "Medicos") {
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
      Medico.cadastrarMedico();
      menu();

     } else {
      if (aux == "Listar") {
       Console.Clear();
       Medico.listarMedicos();
       Console.WriteLine("Menu");

       //--- escape Listar
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu();

      } else {
       if (aux == "Buscar") {
        Console.Clear();
        Console.WriteLine("Digite o nome do médico que procura.");
        string auxN = Console.ReadLine();
        Medico.buscarMedico(auxN);
        Console.WriteLine("Menu");

        //--- escape Buscar
        string i = "";
        while (i != "Menu") {
         i = Console.ReadLine();
        }
        menu();


       } else {
        if (aux == "Editar") {
         Console.Clear();
         Console.WriteLine("Digite o nome do médico que procura.");
         string auxN = Console.ReadLine();
         Medico.editarMedico(auxN);
         menu();

        } else {
         if (aux == "Excluir") {
          Console.Clear();
          Console.WriteLine("Digite o nome do médico que deseja excluir");
          Medico.excluirMedico(Console.ReadLine());
          menu();

         } else {
          menu();
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
       //Consulta.marcarConsulta();
       menu();


      } else {
       if (aux == "Listar") {
        Console.Clear();
        //  Consultas.listarConsultas();
        Console.Write("\n");
        Console.WriteLine("Menu");
        //--- escape
        string i = "";
        while (i != "Menu") {
         i = Console.ReadLine();
         break;
        }
        menu();

       } else {
        if (aux == "Buscar") {
         Console.Clear();
         //  Consultas.buscarConsulta();
         Console.WriteLine("\n");
         Console.WriteLine("Menu");

         //--- escape
         string i = "";
         while (i != "Menu") {
          i = Console.ReadLine();
         }
         menu();

        } else {
         if (aux == "Editar") {
          Console.Clear();
          Console.WriteLine("Nome do Paciente: ");
          string nomePaciente = Console.ReadLine();
          //Consultas.editarConsulta(nomePaciente);
          menu();

         } else {
          if (aux == "Excluir") {
           Console.Clear();
           Console.WriteLine("Nome do Paciente: ");
           string nomePaciente = Console.ReadLine();
           //Consultas.excluirConsulta(excluirPaciente);
           menu();

          } else {
           menu();
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
        Medico.cadastrarMedico();
        menu();

       } else {
        if (aux == "Listar") {
         Console.Clear();
         Medico.listarMedicos();
         Console.WriteLine("Menu");
         string i = "";
         while (i != "Menu") {
          i = Console.ReadLine();
         }
         menu();

        } else {
         if (aux == "Buscar") {
          Console.Clear();
          Console.WriteLine("Digite o nome do médico que procura.");
          string auxN = Console.ReadLine();
          Medico.buscarMedico(auxN);
          Console.WriteLine("Menu");
          string i = "";
          while (i != "Menu") {
           i = Console.ReadLine();
          }
          menu();

         } else {
          if (aux == "Editar") {
           Console.Clear();
           Console.WriteLine("Digite o nome do médico que procura.");
           string auxN = Console.ReadLine();
           Medico.editarMedico(auxN);
           menu();

          } else {
           if (aux == "Excluir") {
            Console.Clear();
            Console.WriteLine("Digite o nome do médico que deseja excluir");
            Medico.excluirMedico(Console.ReadLine());
            menu();

           } else {
            menu();
           }
          }
         }


        }
       }
      }
     }


    }

    menu();

   }
  }


  public static void menu() {
   Main();
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
