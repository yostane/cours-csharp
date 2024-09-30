public enum Role
{
  Fighter, Mage, Spport, Shooter
}
public class Hero
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required Role Role { get; set; }
}
