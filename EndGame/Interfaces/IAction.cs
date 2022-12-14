namespace EndGame.Interfaces;

public interface IAction
{
    public string Name { get; set; }
    public void Execute();
}