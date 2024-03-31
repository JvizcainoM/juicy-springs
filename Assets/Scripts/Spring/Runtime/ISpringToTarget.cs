namespace LlamAcademy.Spring.Runtime
{
    public interface ISpring<in T>
    {
        void SpringTo(T target);
    }
}
