﻿// See https://aka.ms/new-console-template for more information
//aula 25/08/2023 Polimorfismo
using animal.Model;
namespace animal{
    public class Program{
        public static void Main(){
              var cachorro = new Cachorro();
              cachorro.EmitirSom();
              cachorro.ExecutarComando("Deitar", "Rolar");
              var cat = new Gato();
              cat.EmitirSom();
        }
    }
}
