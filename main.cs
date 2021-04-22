using System;
using System.Collections.Generic;
class RockPaperScissors {
  static void Main() {
      var random = new Random();
      var list = new List<string>{ "Rock","Paper","Scissors"};
      int counterA=0;
      int counterB=0;
      int counterTie=0;
    for(int i=0;i<100;i++){
        int index = random.Next(list.Count);
        if(list[index] == "Scissors"){
            counterB++;
        }
        else if(list[index] == "Rock"){
            counterA++;
        }
        else{
            counterTie++;
        }
        
        
    }
    
    Console.WriteLine("Player A wins "+counterA+" of 100 games");
    Console.WriteLine("Player B wins "+counterB+" of 100 games");
    Console.WriteLine("Tie: "+counterTie+" of 100 games");
    
  }
}
