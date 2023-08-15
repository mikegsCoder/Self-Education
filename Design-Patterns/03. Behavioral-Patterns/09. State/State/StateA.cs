namespace State
{
    public class StateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateB();
        }
    }
}
