namespace LoveLetter
{
  public class Priest : SinglePlayerCard
  {
    public Priest(int strengthNumber, string cardNumber) : base(strengthNumber, cardNumber)
    {
    }

    public override void PlayEffect(PlayerHand player)
    {
      throw new NotImplementedException();
    }
  }
}