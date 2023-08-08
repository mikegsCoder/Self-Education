namespace Car
{
    public class Car
    {
        protected int passengers; 
        protected string model; 

        public Car(int num, string model, IMovable mov)
        {
            passengers = num;
            model = model;
            Movable = mov;
        }

        public IMovable Movable { private get; set; }

        public void Move()
        {
            Movable.Move();
        }
    }
}
