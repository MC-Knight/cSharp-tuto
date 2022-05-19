for(int a=1; a < 7; a++){
    for(int b=1; b < a; b++){
        Console.Write("* ");
    }
    Console.WriteLine();
}


for(int i=0; i < 10; i++){
  Console.WriteLine($"This is for Loop {i} time");
  }
  
  
  int number = 1;
  while(number < 10){
    Console.WriteLine($"This is for Loop {number} time");
    number++;
  }
  
  int number1 = 1;
  do
  {
    Console.WriteLine($"This is do while Loop {number1} time");
    number1++;
  }while(number1 < 10);
  
  
  var names = new List<string> {"Patrick","Jonas","Bahanda","Richard"};
  
  foreach(var name in names){
    Console.WriteLine($"this name {name} is in names list.");
    }
