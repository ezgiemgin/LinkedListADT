using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzgiEmgin_BarisAltun
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            
            //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
            tmpHead.Next = Head;
            //Yeni Head artık tmpHead oldu
            Head = tmpHead;
                
            
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }
        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Node HeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (HeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = HeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }
            return temp;
        }


        public override void InsertLast(int value)
        {
            Node newLast = new Node
            {
                Data = value
            };
            Node oldLast=new Node();
            Node temp = new Node();
            
            while(temp.Next.Next!=null)
            {
            if (Head == null)
                Head = newLast;
            else if (oldLast.Next == null)
            {
                oldLast.Next = newLast;
            }
            Size++;
            }
        }

        public override void InsertPos(int position, int value)
        {
            Node newNode = new Node
            {
                Data = value
            };
            Node posNode = new Node();
            int pos = 0;
            Node temp = Head;
           if (Head!=null)
           {
               while(temp!=null)
               {
                   if (temp.Next == null)
                       break;
                   else if(temp.Data==value && pos==position)
                   { 
                                Size++;
                                temp = posNode.Next;
                                posNode.Next = newNode;
                                newNode.Next = temp;
                    }
                    
                    temp = temp.Next;
                    pos++;
                }
            }
           }
            
                                       /*  head null mı değil headden başla temple gez pos ++ 
                                        * temp son mu evetse bitir değilse tempin değeri value mi poz position a eşit mi  */
             

        public override void DeleteLast()
        {
            Node temp = new Node();
            Node last = new Node();
            while(temp != null)
            {
                
                if (Head == null)
                    break;
                else if(Head.Next==null)
                {
                    Head = null;
                }
                //else if(temp.Next.Next==0)

            }
        }
    
        public override void DeletePos(int position)
        {
            throw new NotImplementedException();
        }

        public override Node GetElement(int position)
        {
            throw new NotImplementedException();
        }
    }
}
