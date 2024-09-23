/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random random = new(); // Create a new instance of the Random class to generate random numbers
string[] orderIDs = new string[5]; // Initialize an array of strings with a length of 5 to store the order IDs

for (int i = 0; i < orderIDs.Length; i++) // Loop through each element in the orderIDs array
{
  int prefixValue = random.Next(65, 70); // Generate a random integer between 65 and 69 (inclusive)
  string prefix = Convert.ToChar(prefixValue).ToString(); // Convert the random integer to its corresponding ASCII character and then to a string
  string suffix = random.Next(1, 1000).ToString("000"); // Generate a random integer between 1 and 999 (inclusive) and format it as a three-digit string with leading zeros if necessary

  orderIDs[i] = prefix + suffix; // Concatenate the prefix and suffix to form the order ID and assign it to the current element in the orderIDs array
}

foreach (var orderID in orderIDs) // Iterate over each order ID in the orderIDs array
{
  Console.WriteLine(orderID); // Print the current order ID to the console
}





/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{ 
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");