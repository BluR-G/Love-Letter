using System.Linq;
namespace LoveLetter
{
  public class PlayerHand
  {
    public string Name{get;}
    public List<Card> hand = new List<Card>();
    public Boolean IsHandmaidProtected{get; set;}
    public Boolean IsEliminated{get; set;}
    public int TokenOfAffection{get; set;}

    public PlayerHand(string name)
    {
      Name = name;
      IsHandmaidProtected = false;
      IsEliminated = false;
      TokenOfAffection = 0;
    }

    public override string ToString()
    {
      string builder = "";
      builder += $"Name: {Name}\n";
      for(int i = 0; i < hand.Count; i++)
      {
        builder += $"----{i + 1}----\n";
        builder += $"{hand[i].CardName} | {hand[i].StrengthNumber}\n";
      }
      return builder;
    }

    public void AddToHand(Card card)
    {
      if(hand.Count >= 2)
      {
        Console.WriteLine("Hand Full");
      } 
      else 
      {
        hand.Add(card);
      }
    }

    public void RemoveFromHand(int pos)
    {
      if(pos < 0 || pos > 1)
      {
        throw new IndexOutOfRangeException("Position out of range");
      }
      else if (hand.Count == 1 && pos == 1)
      {
        hand.RemoveAt(0);
      } 
      else
      {
        hand.RemoveAt(pos);
      }
    }
  }
}