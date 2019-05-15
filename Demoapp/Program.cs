using System;

class demo
{
    // Sort a array By Binary tree


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
           // thuc hien insert khi co root
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

      int[] arr = new int[]{4,2,3,5,7,2,1,7,5};
      Node BinaryTree = new Node(arr[0]);

      for(int i = 1; i< arr.Length ; i++){
         BinaryTree.Insert(arr[i]); 
      }
      BinaryTree.PrintInOrder();
      
   }
   
}

// References https://www.youtube.com/watch?v=oSWTXtMglKE 