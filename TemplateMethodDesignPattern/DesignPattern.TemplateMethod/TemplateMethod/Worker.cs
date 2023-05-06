namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public abstract class Worker
    {
        public abstract string GetUp(string wakeUpClock);
        public abstract string Breakfast(string eatClock);
        public abstract string GoToWork(string goToWorkClock);
        public abstract string WorkTime(string workTime);
        public abstract string ReturnHome(string returnHomeClock);
        public abstract string Relax(string relaxTime);
        public abstract string Sleep(string sleepClock);
    }
}
