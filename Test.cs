using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VarianceTest
{
    public class Events<T> : IEvents<T>
    {
        public event Changing<T> Changing;
        public T Value { get; set; }
    }

    public interface IEvents<out T>
    {
        event Changing<T> Changing;
        T Value { get; set; }
    }

    public delegate void Changing<out T>(object sender, IChangingEventArgs<T> e);

    public class ChangingEventArgs<T> : IChangingEventArgs<T>
    {
        public T Old { get; }
        public T Value { get; set; }
    }

    public interface IChangingEventArgs<out T>
    {
        T Old { get; }
        T Value { get; set; }
    }
}