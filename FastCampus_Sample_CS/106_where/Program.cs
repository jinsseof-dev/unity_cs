using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_where
{
    internal class Program
    {
class REF
{
}

class AA<T> where T : struct
{
    private T sData;

    public AA()
    {
        sData = default(T);
    }
    public void Print()
    {
        Console.WriteLine("" + sData);
    }
}
interface II
{
    void IIPrint();
}

class CC<T> where T : II
{
    public T _interface;
}

class DD : II
{
    public void IIPrint()
    {
        Console.WriteLine("DDbase: ");
    }
}
static void Main(string[] args)
{
    //AA<REF> bb = new AA<REF>();
    AA<int> aa = new AA<int>();
    aa.Print();

    CC<II> cc = new CC<II>();
    cc._interface = new DD();
    cc._interface.IIPrint();
}
    }
}
