using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag MyNewBag = new Bag();
            MyNewBag.color = "black";
            MyNewBag.numberOfHandles = 3;
            MyNewBag.numberOfZippers = 2;
            MyNewBag.type = "laptop bag";
            MyNewBag.extra = "keychain";
            
            Console.WriteLine(MyNewBag.MyBagDescription());
            Console.WriteLine(MyNewBag.FirstUse());
            Console.WriteLine(MyNewBag.SecondUse());
            Console.WriteLine(MyNewBag.ThirdUse());
            Console.WriteLine(MyNewBag.ForthUse());
            Console.WriteLine(MyNewBag.LastUse());

            Console.WriteLine("");

            MsgBoard MyNewMsgBoard = new MsgBoard();
            MyNewMsgBoard.legs = 4;
            MyNewMsgBoard.material = "Metal";
            MyNewMsgBoard.msg = "'Please turn around'";
            MyNewMsgBoard.what = "Message Board";
            MyNewMsgBoard.feature = "Klap sammen funktion";

            Console.WriteLine(MyNewMsgBoard.Description());
            Console.WriteLine(MyNewMsgBoard.FirstUse());
            Console.WriteLine(MyNewMsgBoard.SecondUse());
            Console.WriteLine(MyNewMsgBoard.ThirdUse());
            Console.WriteLine(MyNewMsgBoard.ForthUse());
            Console.WriteLine(MyNewMsgBoard.LastUse());

            Plate NewPlate = new Plate();
            Console.WriteLine(NewPlate.FirstUse());
            Console.WriteLine(NewPlate.SecondUse());
            Console.WriteLine(NewPlate.ThirdUse());
            Console.WriteLine(NewPlate.ForthUse());
            Console.WriteLine(NewPlate.LastUse());
        }
    }
}
