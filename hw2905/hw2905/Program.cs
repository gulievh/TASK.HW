namespace hw2905  //taks 1
{
    class Program
    {
        static int CalculateAverageSalary(Engineer[] engineers)
        {
            int totalSalary = 0;
            foreach (Engineer engineer in engineers)
            {
                totalSalary += engineer.Salary;
            }
        }
    }
}

            

