namespace Practice5.Task1.Model
{
    /// <summary>
    /// Подрядчик.
    /// </summary>
    public class Contractor : Employee
    {
        /// <summary>
        /// Почасовая ставка.
        /// </summary>
        public double HourlyRate { get; private set; }

        /// <summary>
        /// Количество отработанных часов.
        /// </summary>
        public int HoursWorked {  get; private set; }

        /// <summary>
        /// Рассчитать бонус.
        /// </summary>
        /// <returns></returns>
        public new double CalculateBonus()
        {
            return CalculateBonus(this.HoursWorked);
        }

        /// <summary>
        /// Рассчитать бонус.
        /// </summary>
        /// <returns></returns>
        public double CalculateBonus(int hoursWorked)
        {
            return this.HourlyRate * 0.1 * hoursWorked;
        }

        public Contractor() : this("", 0, 0, 0) { }

        public Contractor(string name, double salary, double hourlyRate, int hoursWorked) : base(name, salary)
        { 
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }
    }
}
