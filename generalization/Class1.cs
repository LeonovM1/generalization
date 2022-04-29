using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

namespace generalization
{
    class Class1<T> //обобщенный класс
    {
        delegate int Square(int x);
        T[] data; //Массив с данными о количестве
        public Class1()
        {
            data = new T[0];

        }
        public void Add(T item) // метод добавления в массив
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
                
            }

            newData[data.Length] = item;
            data = newData;
        }

        public void Resize(T item) // метод удаления из массива
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i > data.Length; i--)
            {
                newData[i] = data[i];
            }

            newData[data.Length] = item;
            data = newData;
        }

        public void Square1(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];

            }

            newData[data.Length] = item;
            data = newData;
        }
    }




    //class Message
    //{
    //    delegate void Message1();

    //    static void Main(string[] args)
    //    {
    //        Message1 mes = Specifications;
    //        mes();
    //    }

    //    public static void Specifications()
    //    {
    //        MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\generalization\generalization\resourse\Boeing747-400.txt"));
    //    }
    //}
}
