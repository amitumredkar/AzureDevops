using Xunit;
using SimpleAPI.Controllers;
using SimpleAPI.Models;
using System.Collections.Generic;

namespace SimpleAPI.Test;

public class EmployeeUnitTest
{
    
    [Fact]
    public void Task_GetEmployee_Return_OkResult()
    {
        IEmployeeRepository repository = new MockEmployeeRepository();

        //Arrange
        var controller = new EmployeeController(repository);
        //Act
        var data = controller.Get();

        //Assert
        Assert.IsAssignableFrom<IEnumerable<Employee>>(data);
    }
}