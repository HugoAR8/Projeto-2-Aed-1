using System;
namespace Sistema {

  class Medico : Pessoas{
    private string especializacao;
    public string[] horarios = new string[5]; 

    public Medico(){
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

     //Horários disponíveis do médico em questão.
    public void setHorario(string h,int i){
     horarios[i] = h;
    }

    public void imprimirHorarios(){
     for(int i = 0; i < horarios.Length; i++){
       Console.WriteLine(horarios[i]);
      }
   }

    
  }
}