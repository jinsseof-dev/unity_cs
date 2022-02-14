using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _089_Intercase
{
    interface IAA
    {
        int A { get; set; } // 프로퍼티 사용 가능합니다.
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }
    class Super
    {
        protected int num;
        public virtual void Print()
        {
            Console.WriteLine("================================");
        }
    }
    class AA : IAA
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
    }
    class BB : IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }
    class CC : Super, IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("class CC class Super Print() 재정의");
        }
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            IAA iaa = new AA();
            iaa.IAAPrint();

            IBB ibb = bb as IBB;
            ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();
        }
    }
}
