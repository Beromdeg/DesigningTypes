using System;
using static System.Console;

namespace DesigningPatterns
{
    //simple demo for Liskov substitution principle
    //eg: a rectangle class
    public class Rectangle
    {
        //public int Height { get; set; }
        //public int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    
        //empty constuct of rectangle
        public Rectangle(){}
        //constructor that initializes rectangle
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        //ToString implementation of rectangle to output info of its object
        public override string ToString()
        {
            return $"{nameof(Height)}:{Height}, {nameof(Width)}:{Width}";
        }

        //method that returns area
        //public int Area(Rectangle rc) => rc.Height * rc.Width;
    }

    //eg: square class wants to inherit from rectangle
    public class Square: Rectangle
    {
        /***Voilation***/
        //public new int Height
        //{
        //    set { base.Height = base.Width = value; }
        //}
        //public new int Widht
        //{
        //    set { base.Width = base.Height = value; }
        //}
        
        /***not voilation as it will use the virtual table to find the correct setter here***/
        public override int Height
        {
            set { base.Height = base.Width = value; } //bad side-effects
        }
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
    }

}
