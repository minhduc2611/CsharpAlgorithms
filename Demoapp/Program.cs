using System;

class demo
{
    // linked list
    public class Node{
        public Object Element;
        public Node Next;
        public Node(){
            Element = null;
            Next = null;
        }
        public Node(Object theElement){
            this.Element = theElement;
            Next = null;
        }
    }
        public class LinkedList{
            protected Node Header;
            public LinkedList(){
                Header = new Node("Header");
            }
            private Node FindNode(Object Item){
                Node Current = new Node();
                Current = Header;
                // iteration 
                while(Current.Element != Item) // Current.Element 
                    Current = Current.Next;
                return Current;
            }
            public void Insert(Object newItem ){
               // check if got the second one after "header"
               Node Current = new Node();
               Node NewNode = new Node(newItem);
               Current = Header;
               while(!(Current.Next == null)){
                   Current = Current.Next;
               }
               Current.Next = NewNode;
            }
            public void InsertNewAfter(Object ItemBeforeNewItem,Object newItem ){
                Node Current = new Node();  
                Node NewNode = new Node(newItem); 
                Current = FindNode(ItemBeforeNewItem); // đằng sau cái node ( = ItemBeforeNewItem.Next )
                NewNode.Next = Current.Next;  
                Current.Next = NewNode; // ??tráo đổi 
            }

            public Node FindPrevious(Object n){
                Node Current = Header;
                while(!(Current.Next == null) && (Current.Next.Element != n)  ) // Current.Next.Element 
                    Current = Current.Next;
                return Current;
            }

            public void Remove(Object n){
                Node PreviousNode = FindPrevious(n);
                if(!(PreviousNode.Next == null))
                    PreviousNode.Next = PreviousNode.Next.Next;
            }

            public void PrintList(){
                Node Current = new Node();
                Current = Header; 
                while(!(Current.Next == null)){
                    Console.WriteLine(Current.Next.Element);
                    Current = Current.Next;
                }
            }
        }
    static void Main(string[] args)
    {
        LinkedList List = new LinkedList();
        List.Insert("Meow"); 
        List.Insert("wooof"); 
        List.Insert("rrrrr"); 
        List.Insert("quack"); 
        // List.InsertNewAfter("Meow","wooof");List.InsertNewAfter("wooof","rrrrr");
        // List.InsertNewAfter("rrrrr","qwuak quack");

        // List.Remove("rrrrr");
        List.PrintList();
     
    }

}
