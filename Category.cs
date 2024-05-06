public record Category (string categoryName)
{
    
    // Se la istanzio qui la lista anche vuota mi va in errore il test
    //public List<LedgerItem> ledger = new List<LedgerItem>();
    public List<LedgerItem> ledger;

    public bool AddDeposit(LedgerItem ledgerItem)
    {
        ledger.Add(ledgerItem);
        //Console.WriteLine($"AddDeposit:   {ledgerItem.Description} =>> {ledgerItem.amount}");
        return true;
    }

    public bool AddWithedraw(LedgerItem ledgerItem)
    {
        
        // modify manage Withedraw negative amount inside method
        //ledgerItem.amount = System.Math.Abs(ledgerItem.amount);
        
        bool result = false;
        
        //Console.WriteLine($"AddWithedraw: {ledgerItem.Description} =>> {ledgerItem.amount} (balance={getBalance()})");
        if(System.Math.Abs(ledgerItem.amount) <=  getBalance()){
            ledger.Add(ledgerItem);
            //Console.WriteLine($"AddWithedraw: {ledgerItem.Description} =>> {ledgerItem.amount}");
            result = true;
        } else {
            Console.WriteLine($"Don't possible Withedraw! ");
            result = false;
        }
        return result;

        
    }

    public int getBalance()
    {
        int balance = 0;
        foreach (var item in ledger)
        {
            balance += item.amount;
        }
        return balance;
    }

    public bool check_funds(int amount)
    {
        int balance = 0;
        bool result = false;
        foreach (var item in ledger)
        {
            balance += item.amount;
        }

        if(balance >= amount)
            result = true;

        return result;
    }
}

public record LedgerItem(String Description,int amount){}