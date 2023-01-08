namespace LoveLetter
{
  public abstract class ChoiceCard : Card
  {
    public int StrengthNumber { get; }
    public string CardName { get; }
    public ChoiceCard(int strengthNumber, string cardName)
    {
      StrengthNumber = strengthNumber;
      CardName = cardName;
    }

    public override string ToString()
    {
      return $"{CardName} | {StrengthNumber}";
    }
    public abstract void PlayEffect(PlayerHand opponent, int choice);
  }
}