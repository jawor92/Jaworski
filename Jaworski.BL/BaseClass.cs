namespace Jaworski.BL
{
    public abstract class BaseClass
    {
        public bool IsNew { get; set; }
        public bool IsChanged { get; set; }
        public StateObiect StanObiektu { get; set; }
        public bool CorrectData
        {
            get
            {
                return true;
            }
        }
    }

    public enum StateObiect
    {
        Active,
        Removed
    }
}