namespace ConsoleSouls
{
    internal interface IScene : IDrawContent
    {
        bool IsCompleted { get; }
    }
}
