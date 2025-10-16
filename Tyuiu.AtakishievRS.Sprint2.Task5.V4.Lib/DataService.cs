using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtakishievRS.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string card;
            switch (value)
            {
                case 1:
                    card = "пики";
                    break;
                case 2:
                    card = "трефы";
                    break;
                case 3:
                    card = "бубны";
                    break;
                case 4:
                    card = "червы";
                    break;
                default:
                    card = "Не верный номер масти";
                    break;
            }
            return card;
        }
    }
}
