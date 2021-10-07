using System;

namespace Spaceman
{
  internal class Program:Game
  {
    static void Main(string[] args)
    {
      Game xogo=new Game();
      xogo.Greet();
      xogo.Display();
      xogo.Ask();
      while(!xogo.DidWin() || !xogo.DidLose()){
        xogo.Display();
        xogo.Ask();
        if(xogo.DidWin()){
          Console.WriteLine("Enhorabuena. Has ganado!");
          break;
        }
        if(xogo.DidLose()){
          Console.WriteLine("Lo siento. Has perdido");
          break;
        }
      }
    }
  }
}
