namespace LoveLetter
{
  public class Prince : SinglePlayerCard
  {
    public Prince(int strengthNumber, string cardName) : base(strengthNumber, cardName)
    {
    }

    public override void PlayEffect(PlayerHand opponent)
    {
      throw new NotImplementedException();
    }
  }
}