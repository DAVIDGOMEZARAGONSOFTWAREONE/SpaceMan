using System;

namespace Spaceman
{
  internal class Game:Ufo{

    string CodeWord;
    string CurrentWord;
    int MaxNumberGuesses;
    int CurrentNumberWrongGuesses;
    string[] WordArray=new string[]{"vaca","perro","gallina","burro"};
    Ufo ufo = new Ufo();

    public Game(){
      Random rnd = new Random();
      int rand  = rnd.Next(0, 4);
      CodeWord=WordArray[rand];
      MaxNumberGuesses=5;
      CurrentNumberWrongGuesses=0;
      for(int i=0;i<CodeWord.Length;i++){
        CurrentWord+="_";
      }
    }

    public void Greet(){
      Console.WriteLine("Wellcome to de UFO game!");
    }

    public bool DidWin(){
      bool Win=CodeWord.Equals(CurrentWord);
      return Win;
    }

    public bool DidLose(){
      bool Lose=false;
      if(CurrentNumberWrongGuesses>=MaxNumberGuesses){
        Lose=true;
      }
      return Lose;
    }

    public void Display(){
      Console.WriteLine(ufo.Stringify());
      Console.WriteLine("CurrentWord: "+CurrentWord);
      Console.WriteLine("incorrect Guesses: "+CurrentNumberWrongGuesses);
    }

    public void Ask(){
      Console.Write("Adivina una letra: ");
      string LetraGuess=Console.ReadLine();
      if(LetraGuess.Length!=1){
        Console.WriteLine("Debes introducir una letra de cada vez...");
        return;
      }
      bool CheckWord=false;
      if(CodeWord.Contains(LetraGuess)){
        Console.WriteLine("Has acertado esta letra!");
        //Reemplazar letras
        for(int i=0;i<CodeWord.Length;i++){
          if((CodeWord[i].ToString()).Equals(LetraGuess)){
            CurrentWord=CurrentWord.Remove(i,1).Insert(i,LetraGuess);
          }
        }
      }else{
        Console.WriteLine("Has fallado...");
        CurrentNumberWrongGuesses++;
        ufo.AddPart();
      }
    }
  }
}
