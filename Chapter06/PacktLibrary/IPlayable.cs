using static System.Console;
namespace Packt.Shared
{
  public interface IPlayable
  {
    void Play();

    void Pause();
    void Stop()
    {
      WriteLine("this is a default method form th Interface STOP.");
    }
  }
}