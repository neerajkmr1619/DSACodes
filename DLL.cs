using System;

namespace Linkedlist{
    public class DLL{
      private Node head = null;

      private Node tail = null;

      private int size;

      public DLL(){
          this.size = 0;
      }
      public void insertFirst(int val){
          Node node = new Node(val);
          node.next = head;
          node.prev = null;
          
          if(head != null){
              head.prev = node;
          }

          head = node;
      }

      public void insertLast(int val){
          
          Node node = new Node(val);
          Node last = head;

          if(head == null){
              node.prev = null;
              node.next = null;
              head = node;
              return;
          }
          while(last.next != null){
              last = last.next;
          }

          last.next = node;
          node.next = null;
          node.prev = last;
          tail = node;
          return;
          

      }

      public void insertAfterValue(int val, int newVal){
         Node insertNode = new Node(newVal); 
         Node node = findNode(val);
         if(node != null){
           insertNode.next = node.next;
           insertNode.prev = node;

           node.next = insertNode;
           
           insertNode.next.prev = insertNode;
         }
      }
       
      public Node findNode(int val){
          Node node = head;

          while(node.next!=null){
              if(node.value == val){
                  return node;
              }
              node = node.next;
          }
          return node;
      } 
      public void display(){
          Node node = head;

          while(node!= null){
              Console.Write(node.value + " -> ");

              node = node.next;
          }

          Console.Write("End");
      }

       public class Node
        {
            public int value;
            public Node next;

            public Node prev;

            public Node(int value)
            {
                this.value = value;
            }

            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }

        }
    }
}