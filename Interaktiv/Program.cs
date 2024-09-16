string choice = "";

Console.WriteLine("You are prophet Moses guiding your people back to the promised land.");
Console.WriteLine("You and your people are currently being chased by the Egyptians who had been keeping you detained for a long time.");
Console.WriteLine("As you're all trying to outrun and escape from the Egyptians, you suddenly come across the Red Sea.");
Console.WriteLine("You become sceptical and are unsure what path to choose");
Console.WriteLine("One of your people suggest that we run towards the coast of the Red Sea.");
Console.WriteLine("However, another one suggests that we go around the coast, hoping for escape.");
Console.WriteLine("Which path do you take, around or towards?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "around")
{
  Console.WriteLine("You're all running around the coast of the Red Sea, hoping for any new plans.");
  Console.WriteLine("The Egyptians, however, manage to catch up because you were practically running to nowhere.");
  Console.WriteLine("You and your people have been sent back to Egypt to be enslaved again, you have failed your Lord's plans.");
}
else if (choice == "towards")
{
  Console.WriteLine("You run towards the coast of the Red Sea while your people wait behind you.");
  Console.WriteLine("With the staff that you have been holding in your right hand this whole time, you suddenly remember the message from God.");
  Console.WriteLine(" \"You shall take in your hand this staff, with which you shall perform the signs.\" ");
  Console.WriteLine("You become sceptical yet again, showing doubts towards God's plans");
  Console.WriteLine("What is your behaviour towards God, trust or distrust");
  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "trust")
  {
    Console.WriteLine("As you proceed with God's plan, you take the staff in your hands and strikes the ground with it.");
    Console.WriteLine("With that, the Red Sea suddenly splits, causing a dramatic view and then a way for you and your people to the promised");
    Console.WriteLine("You all run all the way to the promised land after shouting at your people.");
    Console.WriteLine("After making it to the promised land, the Red Sea suddenly goes back to normal, consuming the Egyptians that had been chasing you.");
    Console.WriteLine("Glory to God, the people are all safe now, and more prophets are yet to come in the future, prophesying the coming of the Messiah.");
  }
  else if (choice == "distrust")
  {
    Console.WriteLine("You deny God's plan, thinking of one yourself.");
    Console.WriteLine("You tell your people to simply swim towards the promised land, hoping for luck.");
    Console.WriteLine("Unfortunately because of your reckless decision, not everyone is able able to swim and everyone falls short.");
    Console.WriteLine("This causes the Egyptians to easily cease you and your people, taking you back to their land to enslave you.");
    Console.WriteLine("You have failed God's precious works.");
  }
  else
  {
    Console.WriteLine("You fool! You took too long deciding and you've let the Egyptians detain everyone of you, now you have to rethink of what you've done!");
  }
}
else
{
  Console.WriteLine("You fool! You took too long deciding and you've let the Egyptians detain everyone of you, now you have to rethink of what you've done!");
}

Console.WriteLine("Press ENTER to end this stimulation.");
Console.ReadLine();