using System;

class Program {
  public static void Main (string[] args) {
    
int[] RanNums = {827,498,48,939,84,482,794,83,63,923,0,8383,48503,44,56,488,49,93,900,28};
    int LastNum = 0;
    foreach(int num in RanNums){
      if(num >= LastNum ){ 
        LastNum = num; 
      }
      
  }
     Console.WriteLine ("Número encontrado");
    Console.WriteLine("O Número "+ LastNum +" É o maior número");
}
  }