namespace Individual.Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }
        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
        }
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)

        {
            if (!DoorIsOpen)
            {
                if ((desiredFloor >= CurrentLevel) && (desiredFloor <= NumberOfLevels))
                {
                    CurrentLevel = desiredFloor++;
                }
            }
        }
            public void GoDown(int desiredFloor)
            {
                if (!DoorIsOpen)
                {
                    if (CurrentLevel > 1)
                    {
                        CurrentLevel = desiredFloor--;
                    }

                }
            }

        }

    }

