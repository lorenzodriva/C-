class CuentaBancaria
{
    private string _titular;

    private decimal _saldo;
    public CuentaBancaria(string titular, decimal saldo)
    {
        _titular = titular;
        _saldo = saldo;
    }
    public string Titular
    {
        get { return _titular; }
        set { _titular = value; }
    }
    public decimal Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Deposito exitoso. \nCantidad depositada: {cantidad} \nSaldo Actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("No podes depositar menos que 0");
        }
    }
    public void Retirar(decimal cantidad)
    {
        if (cantidad >= 1 && cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. \nCantidad retirada: {cantidad} \nSaldo Actual: {Saldo}");
        }
    }
}
class Program
{
    static void Main()
    {
        CuentaBancaria unaCuenta = new CuentaBancaria("Pepita", 1000);
        unaCuenta.Depositar(300);
        unaCuenta.Retirar(150);
        Console.WriteLine($"Saldo final: {unaCuenta.Saldo}");
    }
}