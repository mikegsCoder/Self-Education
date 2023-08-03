namespace CommandExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Volume volume = new Volume();
            MultiPult mPult = new MultiPult();
            mPult.SetCommand(0, new TVOnCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(volume));

            // turn on TV
            mPult.PressButton(0);

            // increase volume
            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressButton(1);

            // cancel
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();

            Console.Read();
        }
    }
}