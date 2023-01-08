namespace LoveLetter
{
  public abstract class SinglePlayerCard : Card
  {
    public int StrengthNumber { get; }
    public string CardName { get; }

    public SinglePlayerCard(int strengthNumber, string cardName)
    {
      StrengthNumber = strengthNumber;
      CardName = cardName;
    }
    public override string ToString()
    {
      return $"{CardName} | {StrengthNumber}";
    }
    public abstract void PlayEffect(PlayerHand player);
  }
}