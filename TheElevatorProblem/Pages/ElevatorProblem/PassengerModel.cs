
namespace TheElevatorProblem.Pages.ElevatorProblem
{
    public class PassengerModel
    {
        public int Id { get; set; }
        public ElevatorModel CurrentElevator { get; set; }
        public FloorModel CurrentFloor { get; set; }
        public FloorModel RequestedFloor { get; set; }
        public int WaitTime { get; set; }

        public void IncrementWaitTime()
        {
            WaitTime++;
        }

        public void EnterElevator(ElevatorModel elevator)
        {
            CurrentElevator = elevator;
        }

        public void ExitElevator()
        {
            CurrentElevator = null;
        }
    }
}