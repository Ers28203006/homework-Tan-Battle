namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        public Tank(string tankName, int tankLevelAmunition,
            int tankLevelArmor, int tankLevelAgility)
        {
            TankName = tankName;
            TankLevelAmunition = tankLevelAmunition;
            TankLevelArmor = tankLevelArmor;
            TankLevelAgility = tankLevelAgility;

        }
        public string TankName { get; set; }
        public int TankLevelAmunition { get; set; }
        public int TankLevelArmor { get; set; }
        public int TankLevelAgility { get; set; }

        public static string operator *(Tank tankAlly, Tank tankEnemy)
        {
            if (
                (tankAlly.TankLevelAmunition > tankEnemy.TankLevelAmunition &&
                tankAlly.TankLevelArmor > tankEnemy.TankLevelArmor &&
                tankAlly.TankLevelAgility > tankEnemy.TankLevelAgility) ||

                (tankAlly.TankLevelAmunition > tankEnemy.TankLevelAmunition &&
                tankAlly.TankLevelArmor > tankEnemy.TankLevelArmor &&
                tankAlly.TankLevelAgility < tankEnemy.TankLevelAgility) ||

                (tankAlly.TankLevelAmunition > tankEnemy.TankLevelAmunition &&
                tankAlly.TankLevelArmor < tankEnemy.TankLevelArmor &&
                tankAlly.TankLevelAgility > tankEnemy.TankLevelAgility) ||

                (tankAlly.TankLevelAmunition < tankEnemy.TankLevelAmunition &&
                tankAlly.TankLevelArmor > tankEnemy.TankLevelArmor &&
                tankAlly.TankLevelAgility > tankEnemy.TankLevelAgility)
                )
            {
                return tankAlly.TankName;
            }

            else if (
               (tankAlly.TankLevelAmunition == tankEnemy.TankLevelAmunition &&
               tankAlly.TankLevelArmor == tankEnemy.TankLevelArmor &&
               tankAlly.TankLevelAgility == tankEnemy.TankLevelAgility) ||

               (tankAlly.TankLevelAmunition == tankEnemy.TankLevelAmunition &&
               (
               (tankAlly.TankLevelArmor > tankEnemy.TankLevelArmor) ||
               (tankAlly.TankLevelArmor < tankEnemy.TankLevelArmor)
               ) &&
               tankAlly.TankLevelAgility == tankEnemy.TankLevelAgility) ||

              (
               ((tankAlly.TankLevelAmunition < tankEnemy.TankLevelAmunition) ||
               (tankAlly.TankLevelAmunition > tankEnemy.TankLevelAmunition)
              ) &&
               tankAlly.TankLevelArmor == tankEnemy.TankLevelArmor &&
               tankAlly.TankLevelAgility == tankEnemy.TankLevelAgility) ||

               (tankAlly.TankLevelAmunition == tankEnemy.TankLevelAmunition &&
               tankAlly.TankLevelArmor == tankEnemy.TankLevelArmor &&
               (tankAlly.TankLevelAgility > tankEnemy.TankLevelAgility) ||
                (tankAlly.TankLevelAgility < tankEnemy.TankLevelAgility))
               )
            {
                int resultAlly = tankAlly.TankLevelArmor * tankAlly.TankLevelAmunition * tankAlly.TankLevelAgility;
                int resultEnemy = tankEnemy.TankLevelAgility * tankEnemy.TankLevelAmunition * tankEnemy.TankLevelArmor;

                if (resultAlly > resultEnemy)
                {
                    return tankAlly.TankName;
                }
                else if (resultAlly < resultEnemy)
                {
                    return tankEnemy.TankName;
                }
                else
                {
                    return "ни чья!";
                }
            }
            else
            {
                return tankEnemy.TankName;
            }
        }

        public void ShowTankParametrs()
        {
            System.Console.WriteLine("Танк: "+TankName);
            System.Console.WriteLine("Боекомплект: "+ TankLevelAmunition);
            System.Console.WriteLine("Уровень брони: "+TankLevelArmor);
            System.Console.WriteLine("Уровень маневренности: " + TankLevelAgility);
            System.Console.WriteLine();
            System.Console.WriteLine("****************************");
        }


    }
}
