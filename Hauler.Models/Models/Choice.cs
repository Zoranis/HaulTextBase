namespace HaulTextBase.Game
{
    public class Choice
    {
        public Action Action { get; set; }
        public string Description { get; set; }
        public string Result { get; set; } = "Undefined result!";
    }
}