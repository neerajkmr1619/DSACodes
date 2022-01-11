using System;

namespace Linkedlist
{
    public class LinkList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkList(){
            this.size = 0;
        }
        
        public void insertFirst(int val){
            Node node = new Node(val);
            node.next = head;
            head = node;

            if(tail == null){
                tail = head;
            }
            size += 1;
        }
        
        public void insertLast(int val){            
            
            if(tail == null){
                insertFirst(val);
                return;
            }
                Node node = new Node(value:val);
                tail.next = node;
                tail = node;
                size++;
            
        }

        public void insert(int val, int index){
            if(index == 0){
                insertFirst(val);
                return;
            }
            if(index == size){
                insertLast(val);
                return;
            }

            Node temp = head;

            for(int i = 1; i< index; i++){
                temp = temp.next;
            }

            Node node = new Node(val,temp.next);
            temp.next = node;

            size++;
        }
        public void display(){

            Node temp = head;
            while(temp != null){
                Console.Write(temp.value + " -> ");
                temp = temp.next;
            }
            Console.Write(" End");
        }

        public int deleteFirst(){

            int val = head.value;
            head = head.next;
            if(head == null){
                tail = null;
            }
            size--;
            return val;
        }

        public int deleteLast(){
            if(size <= 1){
               return deleteFirst();
            }
            Node secondLast = getNode(size -2);
            int val = tail.value;
            tail = secondLast;
            tail.next = null;
            size--;
            return val;
        }
        
        public int delete(int index){
            if(index == 0){
                return deleteFirst();
            }
            if(index == size-1){
                return deleteLast();
            }

            Node prevNode = getNode(index - 1);
            int val = prevNode.next.value;
            prevNode.next = prevNode.next.next;

            return val;

        }

        public Node getNode(int index){
            Node node = head;
            for(int i=0; i <index; i++){
                node = node.next;
            }
            return node;
        }

        public Node getNodeValue(int val){
            Node node = head;
            while(node!= null){
                if(node.value == val){
                   return node;
                }
                node = node.next;
            }
            return null;
        }

        public Node findNode(int val){
            if(size == 0){
                return null;
            }

            Node temp = head;
            while(temp != null){
                if(temp.value == val){
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
        
        public class Node
        {
            public int value;
            public Node next;

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