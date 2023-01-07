namespace LoveLetter
{
  abstract class PlayerOpponentCard : Card
  {
    public int StrengthNumber{get;}
    public string CardNumber{get;}

    public PlayerOpponentCard(int strengthNumber, string cardNumber)
    {
      StrengthNumber = strengthNumber;
      CardNumber = cardNumber;
    }


  }
}