using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    //point class now support clone ability
  public  class Point:ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();


        //construtor
        public Point()
        {

        }
        public Point(int XPos, int Ypos,string name)
        {
            X = XPos;
            Y = Ypos;
            desc.PetName = name;
        }
        public override string ToString() => $"X={X}; Y={Y} Name={desc.PetName} \n" +
            $"{desc.PointID} \n";
        //expression-bodied member

        // public object Clone() => new Point(this.X, this.Y);
        public object Clone()
        {//first get a shallow copy
            Point newPoint = (Point)this.MemberwiseClone();
            //then fill in the gap
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
  }
}
