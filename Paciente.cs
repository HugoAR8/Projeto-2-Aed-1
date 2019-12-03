using System;
namespace Sistema {

 class Paciente {

  private string nome;
  private int idade;
  private double peso;
  private double altura;

  public Paciente() {
  }


  public string getNome() {
   return nome;
  }

  public void setNome(string n){
    nome = n;
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