using System;
namespace Sistema {

 class Paciente : Pessoas {

  private int idade;
  private double peso;
  private double altura;
  
  public Paciente() {
  }


  

  public int getIdade() {
   return idade;
  }
  
  public void setIdade(int i){
    idade = i;
  }

  public double getPeso() {
   return peso;
  }

  public void setPeso(double p){
    peso = p;
  }

  public double getAltura() {
   return altura;
  }

  public void setAltura(double a){
    altura = a;
  }

 }
 }