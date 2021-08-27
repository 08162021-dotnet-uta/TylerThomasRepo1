using Xunit;
using Project0.StoreApplication.Storage.Repositories;

//a test suite in xUnit is just a standard class with methods implementing each unit test
// return to https://auth0.com/blog/xunit-to-test-csharp-code/
namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    [Fact]
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity to test
      var sut = StoreRepository.Instance;

      // act = execute sut for data
      var actual = sut.Stores;

      // assert
      Assert.NotNull(actual);
    }
    /*public class Validator
    {

    }*/
  }
}
