
namespace TheElevatorProblem.Pages.ElevatorProblem
{
    public class ElevatorModel
    {
        public int Id { get; set; }
        public FloorModel CurrentFloor { get; set; }
        public CurrentDirection CurrentDirection { get; set; } = CurrentDirection.Wait;
    }

    public enum CurrentDirection { Wait, Up, Down }
}