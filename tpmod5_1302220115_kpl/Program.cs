﻿

public class DataGeneric<T>
{
    private T Data;
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}
class Program
{
    private static void Main(string[] args)
    {
      

        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302220115");
        dataGeneric.PrintData();
    }
}