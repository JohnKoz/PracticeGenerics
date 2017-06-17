using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeGenerics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class MyTuple<TypeParameter1, TypeParameter2>
        {
            public class TypeParameter1 Value1 {get; set; }
        public class TypeParameter2 Value2 {get; set; }

    public MyTuple(TypeParameter1, TypeParameter2)
    {
        Value2 = value2;
        Value1 = value1;
    }
    public MyTuple<TypeParameter2, TypeParameter1) SwapValues()
    {
        return new myTuple<TypeParameter2, TypeParameter1>(Value2, Value1);
    }
public List<TypeParameter1> GetListOfValue1(int length)
{
    //create the list to return
    List<TypeParameter1> toReturn = new List<TypeParameter1>();

    for (int i = 0; i < length; i++) toReturn.add(Value1
        return toReturn;
}
}


MyTuple<int, int> twoInts = new MyTuple<int, int>(1, 2);


    }
}
