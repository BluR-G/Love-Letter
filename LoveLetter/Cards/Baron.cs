namespace LoveLetter
{
    public class Baron : MultiPlayerCard
  {
    public Baron(int strengthNumber, string cardName) : base(strengthNumber, cardName)
    {
    }

    public override void PlayEffect(PlayerHand player, PlayerHand opponent)
    {
      throw new NotImplementedException();
    }
  }
}