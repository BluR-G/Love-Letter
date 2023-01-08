namespace LoveLetter
{
  public class Handmaid : SinglePlayerCard
  {
    public Handmaid(int strengthNumber, string cardNumber) : base(strengthNumber, cardNumber)
    {
    }

    public override void PlayEffect(PlayerHand player)
    {
      throw new NotImplementedException();
    }
  }
}