namespace LoveLetter
{
  abstract class PlayerEffectCard : Card
  {
    public int StrengthNumber { get; }
    public string CardNumber { get; }

    public PlayerEffectCard(int strengthNumber, string cardNumber)
    {
      StrengthNumber = strengthNumber;
      CardNumber = cardNumber;
    }
  }
}