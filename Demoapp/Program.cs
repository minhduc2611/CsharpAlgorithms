using System;

class demo
{
    // Simple Binary tree


   //--- ------- ----- ------- ---- -- node model--- ------- ---- --
    public class Node{
       public int Data;
       public Node Left;
       public Node Right;
       public Node(int i){
          this.Data = i;
       }
   //  --------- ------- ---- -- --- function insert --- ------- ---- --
           public void Insert(int i)
        {
           if( i <= Data ){
              //left
              if(this.Left == null){
                 this.Left = new Node(i);
              }else{
                 this.Left.Insert(i);
              }
           }
           else{
            // right
               if(this.Right == null){
                  this.Right = new Node(i);
               }else{
                  this.Right.Insert(i);
               }
           }
        }
    //--- ------- ---- ----- ------- ---- -- Print In order--- ------- ---- --

    public void PrintInOrder(){
       //left first 
      if(this.Left != null){
         this.Left.PrintInOrder();
      }
       // main node 
       Console.WriteLine(this.Data);
       //then right
       if(this.Right!= null){
          this.Right.PrintInOrder();
       }
    }
    }
   static void Main(string[] args) {
            Node nums = new Node(50);
            nums.Insert(17);
            nums.Insert(23);
            nums.Insert(12);
            nums.Insert(19);
            nums.Insert(54);
            nums.Insert(9);
            nums.Insert(14);
            nums.Insert(67);
            nums.Insert(76);
            nums.Insert(72);

            nums.PrintInOrder();

      }
   
}

// References https://www.youtube.com/watch?v=oSWTXtMglKE 