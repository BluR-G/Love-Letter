namespace LoveLetter
{
  abstract class OpponentEffectCard : Card
  {
    public int StrengthNumber {get;}
    public string CardNumber {get;}
    public OpponentEffectCard(int strengthNumber, string cardNumber)
    {
      StrengthNumber = strengthNumber;
      CardNumber = cardNumber;
    }

  }
}