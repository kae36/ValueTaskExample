namespace ConsoleApp
{
  public interface IRepository<T>
  {
    ValueTask<T> GetData();
    ValueTask<T> GetDataAsync();
  }
}
