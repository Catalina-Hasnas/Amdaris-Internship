using System;

namespace VisitorPattern
{
    internal interface ISubscriber
    {
        //void Notify(T item);
        void Notify(Tuple<Shape, float> item);
    }
}