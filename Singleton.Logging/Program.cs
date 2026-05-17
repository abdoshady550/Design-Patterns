using Singleton.Logging;

internal class Program
{
    static MemoryLogger logger;
    private static void Main(string[] args)
    {
        AssignVoucher("ashady@meccano,io", "VOUCHER-1234");
        UseVoucher("VOUCHER-1234");
        logger.ShowLog();
        Console.ReadKey();
    }
    static void AssignVoucher(string email,string voucher)
    {
        //logger = new MemoryLogger();
        logger = MemoryLogger.GetLogger;


        logger.LogInfo($"Voucher '{voucher}' assigned");

        logger.LogError($"Unable to send email '{email}'.");

    }
    static void UseVoucher(string voucher)
    {
        //logger = new MemoryLogger();
        logger = MemoryLogger.GetLogger;

        logger.LogWarning($"3 attempts made to validate the voucher");

        logger.LogInfo($"Voucher '{voucher}' is used");


    }

}