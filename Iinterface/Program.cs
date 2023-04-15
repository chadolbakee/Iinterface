using System;
using System.Collections.Generic;

class marketData
{
    public double Euro { get; set; }
    public double snp { get; set; }
    public double kospi { get; set; }
}

class greeksData
{
    public double Euro { get; set; }
    public double snp { get; set; }
    public double kospi { get; set; }
}



class Program
{
    static void Main(string[] args)
    {
        // Create a list of MyClass instances
        IList<greeksData> myGreeksList = new List<greeksData>
        {
            new greeksData(),
            new greeksData(),
            new greeksData()
        };

        marketData marketData = new marketData();
        marketData.Euro = 5243.25;
        marketData.snp = 4171.75;
        marketData.kospi = 2255;

        int i = 0;
        // Iterate through each instance in the list and set multiple property values using object initializer syntax
        foreach (var myClassInstance in myGreeksList)
        {
            // Assign multiple property values using object initializer syntax without writing their names
            myClassInstance.Euro = 100 + i;
            myClassInstance.snp = 100 + i;
            myClassInstance.kospi = 100 + i;

            i += 10;
        }

        IList<greeksData> myClassListCopy = myGreeksList.ToList(); //복사본 만들기

        //빈공간 만들기
     

        foreach (var myClassInstance in myClassListCopy)
        {
            // Assign multiple property values using object initializer syntax without writing their names
            myClassInstance.Euro = marketData.Euro*myClassInstance.Euro;
            myClassInstance.snp = marketData.snp * myClassInstance.snp;
            myClassInstance.kospi = marketData.kospi * myClassInstance.kospi;

        }
        // Print out the property values of each instance in the list
        foreach (var myClassInstance in myClassListCopy)
        {
            Console.WriteLine($"Value1: {myClassInstance.Euro}, Value2: {myClassInstance.snp}, Value3: {myClassInstance.kospi}");
        }
    }
}
