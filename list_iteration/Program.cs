using System;
using System.Collections.Generic;

class Program{

    static void Main(string[] args){

        List<int> myList = new List<int> {0, 5, 0, 3, 4, 5};

        for(int i = 0; i<myList.Count; i++){

            if(myList[i]==0){
                myList.RemoveAt(i);
                myList.Add(0);
                
            }

                
        }

        Console.WriteLine(string.Join(", ", myList));
   



    }
}

