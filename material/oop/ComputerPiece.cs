class ComputerPiece
{
    // prorpiété en lecture et écriture
    public int WattUsage { get; set; }
    // prorpiété en lecture seule
    public int Price { get; }

    public ComputerPiece(int price)
    {
        this.Price = price;
    }
}

class CPU : ComputerPiece
{
    public CPU(int price) : base(price)
    {
    }
    public int ClockSpeed { get; set; }
    public int CoreCount { get; set; }
}

class RAM : ComputerPiece
{
    public RAM(int price) : base(price)
    {
    }
    public int Capacity { get; set; }
}
