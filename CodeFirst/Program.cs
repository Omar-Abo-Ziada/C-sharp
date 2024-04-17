namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.Depatments.Add(new Depatment() { Name="HR"});
            context.Depatments.Add(new Depatment() { Name = "Finance" });
            context.Depatments.Add(new Depatment() { Name="SD"});

            context.SaveChanges();
        }
    }
}
