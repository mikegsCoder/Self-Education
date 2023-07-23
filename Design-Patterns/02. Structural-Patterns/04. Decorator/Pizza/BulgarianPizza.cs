namespace Pizza
{
    public class BulgarianPizza : Pizza
    {
        public BulgarianPizza()
           : base("Bulgarian pizza")
        { }

        public override int GetCost()
        {
            return 8;
        }
    }
}
