using System;
using System.Collections.Generic;
using GitHubActions.Sample.Api.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace GitHubActions.Sample.Api.UnitTests;

[TestFixture]
public class ActionsControllerTest
{
    [Test]
    public void TestController()
    {
        var _logger = new Mock<ILogger<ActionsController>>();
            
        var controller = new ActionsController(_logger.Object);

        var apiResponse = controller.Get();

        var result = (OkObjectResult)apiResponse.Result;

        Assert.That(result.StatusCode == StatusCodes.Status200OK);
    }
}