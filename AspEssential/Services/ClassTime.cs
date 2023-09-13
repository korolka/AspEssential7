namespace AspEssential.Services
{
    public class ClassTime:ITimeNow
    {
        public DateTime Time()
        {
            return DateTime.Now.ToLocalTime();
        }
    }
}
