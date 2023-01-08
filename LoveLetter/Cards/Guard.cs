namespace LoveLetter
{
  public class Guard : ChoiceCard
  {
    public Guard(int strengthNumber, string cardName) : base(strengthNumber, cardName)
    {
    }

    public override void PlayEffect(PlayerHand opponent, int choice)
    {
      throw new NotImplementedException();
    }
  }
}