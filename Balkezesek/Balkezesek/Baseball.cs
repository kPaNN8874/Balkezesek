public class Baseball
{
    public Baseball(string sor)
    {
        string[] sorelemek = sor.Split(';');
        this.Nev = sorelemek[0];
        this.Elso = Convert.ToDateTime(sorelemek[1]);
        this.Utolso = Convert.ToDateTime(sorelemek[2]);
        this.Suly = Convert.ToInt32(sorelemek[3]);
        this.Magassag = Convert.ToDouble(sorelemek[4]);
    }
    public string Nev { get;}
    public DateTime Elso { get;}
    public DateTime Utolso { get;}
    public int Suly { get;}
    public double Magassag { get;}
}
}