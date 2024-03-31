namespace LlamAcademy.Spring.Runtime
{
    public interface INudge<in T>
    {
        void Nudge(T amount);
    }
}