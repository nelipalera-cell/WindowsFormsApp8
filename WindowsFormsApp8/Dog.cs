
namespace WindowsFormsApp8
{
    public class Dog
    {
        private int energyCurrent = 0;
        private int energyMax = 0;

        private int hungryCurrent = 0;
        private int hungryMax = 0;

        private int happinessCurrent = 0;
        private int happinessMax = 0;

        public Dog()
        {
            energyMax = energyCurrent = 100;
            hungryCurrent = 0;
            hungryMax = 100;
            happinessMax = happinessCurrent = 100;
        }

        public int getEnergy()
        {
            return energyCurrent;
        }
        public int getHungry()
        {
            return hungryCurrent;
        }

        public int getHappiness()
        {
            return happinessCurrent;
        }

        public void increaseEnergy(int value)
        {
            if (energyMax < energyCurrent + value)
                energyCurrent = energyMax;
            else
                energyCurrent += value;
        }

        public void decreaseEnergy(int value)
        {
            if (energyCurrent - value < 0)
                energyCurrent = 0;
            else
                energyCurrent -= value;
        }

        public void increaseHungry(int value)
        {
            if (hungryMax < hungryCurrent + value)
                hungryCurrent = hungryMax;
            else
                hungryCurrent += value;
        }

        public void decreaseHungry(int value)
        {
            if (hungryCurrent - value < 0)
                hungryCurrent = 0;
            else
                hungryCurrent -= value;
        }

        public void increaseHappiness(int value)
        {
            if (happinessMax < happinessCurrent + value)
                happinessCurrent = happinessMax;
            else
                happinessCurrent += value;
        }

        public void decreaseHappiness(int value)
        {
            if (happinessCurrent - value < 0)
                happinessCurrent = 0;
            else
                happinessCurrent -= value;
        }
    }
}
