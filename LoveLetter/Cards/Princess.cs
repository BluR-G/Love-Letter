namespace LoveLetter
{
  public class Princess : SinglePlayerCard
  {
    public Princess(int strengthNumber, string cardNumber) : base(strengthNumber, cardNumber)
    {
    }

    public override void PlayEffect(PlayerHand player)
    {
      throw new NotImplementedException();
    }
  }
}