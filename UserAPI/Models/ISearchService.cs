namespace UserAPI.Models.DTOs;

public interface ISearchService<T>
{
    T GetById(int id);
    T GetByName(string name);
    T GetByEmail(string email);
    List<T> GetByAge(int age);

}