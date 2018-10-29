using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//var 1 hold interger, var 2 hold 2, var 3 for total, access modifier public
//function for addition using argument and return value 

public class Calc : MonoBehaviour { 
 public int Num1;
    public int Num2;
    int Total;
    
    //Calc Code
    
    void Start (){
        CalcAdd();
    }

    public void CalcAdd(){
    
        Add(Num1,Num2);
    }

    //Print to Console

    public void Add(int One, int Two){
       
        Total = One + Two; 
        
        print(Total);
    }

    
}
    
   
    

    
