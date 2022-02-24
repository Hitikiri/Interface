namespace Interface
{
    public interface IVehicle
    {
        void Run();
        void Stop();
        void Move(int speed);
        void Brake();
        int GasLevel();
    }
}