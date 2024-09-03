class Program
{

    static void Main()
    {


        // string[] fraudulentOrderIDs = new string[3]; array declaration
        string[] fraudulentOrderIDs = ["A123", "B456", "C789"];


        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");




        string[] names = ["Luca", "Maria", "Alice"];

        foreach (
             string name in names)

        {
            Console.WriteLine(name + "\n");

        }
        int[] inventory = [200, 150, 300, 400];
        int sum = 0;
        int bin = 0;

        foreach (int items in inventory)
        {

            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

        }
        Console.WriteLine($"We have {sum} items in inventory.\n");


        // Code challenge - Report the Order IDs that need further investigation
        string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        int count = 0;

        foreach (string order in orders)
        {

            if (order.StartsWith("B"))
            {
                Console.WriteLine(order);
                count++;

            }

        }
        Console.WriteLine($"Number of orders starting with B: {count}");

        /* int count = 0;

        foreach (string order in orders)
        {
            // Convert the order ID to a char array and check the first character
            char[] orderChars = order.ToCharArray();
            if (orderChars[0] == 'B')
            {
                Console.WriteLine(order);
                count++;
            }
        }*/

    }
}