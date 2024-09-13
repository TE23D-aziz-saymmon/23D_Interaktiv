string choice = "";

Console.WriteLine("You are prophet Moses guiding your people back to the promised land.");
Console.WriteLine("You and your people are currently being chased by the Egyptians who had been keeping your detained for a long time.");
Console.WriteLine("As you're all trying to outrun and escape from the Egyptians, you suddenly come across the Red Sea.");
Console.WriteLine("You become sceptical and are unsure what path to choose");
Console.WriteLine("One of your people suggest that we run towards the coast of the Red Sea.");
Console.WriteLine("However, another one suggests that we go around the coast, hoping for escape.");
Console.WriteLine("Which path do you take, towards or around?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "around")
{
  Console.WriteLine("As you're all running around the coast of the Red Sea, hoping for any new plans.");
  Console.WriteLine("The Egyptians, however, manage to catch up because you were practically running to nowhere.");
  Console.WriteLine("You and your people have been sent back to Egypt to be enslaved again, you have failed your Lord's plans.");
}
else if (choice == "towards")
{
  Console.WriteLine("You run towards the coast of the Red Sea while your people wait behind you.");
  Console.WriteLine
}