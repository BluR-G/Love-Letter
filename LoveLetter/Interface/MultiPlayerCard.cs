namespace LoveLetter
{
  public abstract class MultiPlayerCard : Card
  {
    public int StrengthNumber{get;}
    public string CardName{get;}

    public MultiPlayerCard(int strengthNumber, string cardNumber)
    {
      StrengthNumber = strengthNumber;
      CardName = cardNumber;
    }

    public override string ToString()
    {
      return $"{CardName} | {StrengthNumber}";
    }

    public abstract void PlayEffect(PlayerHand player, PlayerHand opponent);
  }
}