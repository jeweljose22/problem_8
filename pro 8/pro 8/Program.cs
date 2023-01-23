Decimal[] fare = new decimal[3];
string[] destination = new string[3];
Console.WriteLine("enter fare");
for(int i = 0;i < 3; i++)
{
    fare[i] =Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine("enter destination");
for(int i = 0;i < 3; i++)
{
    destination[i]= Console.ReadLine();
}
Console.WriteLine("enter the pos");
int pos= Convert.ToInt32(Console.ReadLine());
if(pos < 4)
{
    Console.WriteLine(fare[pos-1]);
    Console.WriteLine(destination[pos-1]);
}
else
{
    Console.WriteLine("not valid");   
}

    
    //Console.WriteLine(destination[pos]);


