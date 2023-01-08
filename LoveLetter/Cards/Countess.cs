namespace LoveLetter
{
  public class Countess : SinglePlayerCard
  {
    public Countess(int strengthNumber, string cardNumber) : base(strengthNumber, cardNumber)
    {
    }

    public override void PlayEffect(PlayerHand player)
    {
      throw new NotImplementedException();
    }
  }
}