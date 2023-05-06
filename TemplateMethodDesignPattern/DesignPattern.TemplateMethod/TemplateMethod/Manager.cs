namespace DesignPattern.TemplateMethod.TemplateMethod
{
    public class Manager : Worker
    {
        public override string Breakfast(string eatClock)
        {
            return eatClock;
        }
        public override string GetUp(string wakeUpClock)
        {
            return wakeUpClock;
        }
        public override string GoToWork(string goToWorkClock)
        {
            return goToWorkClock;
        }
        public override string Relax(string relaxTime)
        {
            return relaxTime;
        }
        public override string ReturnHome(string returnHomeClock)
        {
            return returnHomeClock;
        }
        public override string Sleep(string sleepClock)
        {
            return sleepClock;
        }
        public override string WorkTime(string workTime)
        {
            return workTime;
        }
    }
}
