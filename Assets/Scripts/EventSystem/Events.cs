public class Events
{
    public class InputEvents
    {
        public const string validSwipeCaptured = "validSwipeCaptured";
        public const string validSwipeSetCaptured = "validSwipeSetCaptured";
    }

    public class UIEvents
    {

    }

    public class PlayerDataEvents
    {

    }

    public class GameEvents
    {
        public const string swipePhaseComplete = "swipePhaseComplete";
        public const string playerConnected = "playerConnected";
    }

    public class CheatEvents
    {
        public const string incrementCheatValue = "incrementCheatValue";
        public const string decrementCheatValue = "decrementCheatValue";
        public const string refreshCheats = "refreshCheatValue";
    }
}
