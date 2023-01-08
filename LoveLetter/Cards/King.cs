namespace LoveLetter
{
  public class King : MultiPlayerCard
  {
    public King(int strengthNumber, string cardNumber) : base(strengthNumber, cardNumber)
    {
    }

    public override void PlayEffect(PlayerHand player, PlayerHand opponent)
    {
      throw new NotImplementedException();
    }
  }
}