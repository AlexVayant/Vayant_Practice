public class Payment
{
    private string _fio;
    private double _zarplata;
    private int _godnayma;
    private double _nadbavka;
    private int _dneyotrabotano;
    private int _rabochihdneyvnedele;

    public Payment(string fio, double zarplata, int godnayma, double nadbavka, int dneyotrabotano, int rabochihdneyvnedele)
    {
        _fio = fio;
        _zarplata = zarplata;
        _godnayma = godnayma;
        _nadbavka = nadbavka;
        _dneyotrabotano = dneyotrabotano;
        _rabochihdneyvnedele = rabochihdneyvnedele;
    }

    public double CalculateNachis()
    {
        return (_zarplata / _rabochihdneyvnedele) * _dneyotrabotano * (1 + (_nadbavka/100));
    }

    public double CalculateUderj()
    {
        double accruedAmount = CalculateNachis();
        return accruedAmount * (0.13 + 0.01);
    }

    public double CalculateItog()
    {
        return CalculateNachis() - CalculateUderj();
    }

    public int CalculateStaj()
    {
        return DateTime.Now.Year - _godnayma;
    }

    public override string ToString()
    {
        return $"ФИО: {_fio}\n" +
               $"Оклад: {_zarplata}\n" +
               $"Год поступления на работу: {_godnayma}\n" +
               $"Процент надбавки: {_nadbavka}\n" +
               $"Количество отработанных дней: {_dneyotrabotano}\n" +
               $"Количество рабочих дней: {_rabochihdneyvnedele}\n" +
               $"Начисленная сумма: {CalculateNachis()}\n" +
               $"Удержанная сумма: {CalculateUderj()}\n" +
               $"Сумма, выдаваемая на руки: {CalculateItog()}\n" +
               $"Стаж: {CalculateStaj()} год";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите ФИО:");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите оклад:");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите год поступления на работу:");
            int yearOfEmployment = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент надбавки:");
            double bonusPercent = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество отработанных дней:");
            int daysWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество рабочих дней:");
            int workingDays = int.Parse(Console.ReadLine());
            Payment payment = new Payment(fio, salary, yearOfEmployment, bonusPercent, daysWorked, workingDays);
            Console.WriteLine(payment.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Неверный формат данных");
        }
    }
}