﻿namespace Authsignal.Tests;
public class ClientTests : TestBase
{
    [Fact]
    public async Task GetUser()
    {
        var response = await AuthsignalClient.GetUser(new UserRequest(UserId: "TestUserId"));

        Assert.NotNull(response);
    }
    [Fact]
    public async Task Track()
    {
        var response = await AuthsignalClient.Track(new (UserId: "TestUserId", Action: "Login"));

        Assert.NotNull(response);
    }
    [Fact]
    public async Task GetAction()
    {
        var response = await AuthsignalClient.GetAction(new(UserId: "TestUserId", Action: "Login", IdempotencyKey: Guid.NewGuid().ToString()));

        Assert.NotNull(response);
    }

    [Fact]
    public async Task LoginWithEmail()
    {
        var response = await AuthsignalClient.LoginWithEmail(new(Email: "test@authsignal.co.nz"));

        Assert.NotNull(response);
    }

    [Fact]
    public async Task ValidateChallenge()
    {
        var response = await AuthsignalClient.ValidateChallenge(new(UserId: "TestUserId", Token: "SomeToken"));

        Assert.NotNull(response);
    }

    [Fact]
    public async Task EnrollVerifiedAuthenticator()
    {
        var response = await AuthsignalClient.EnrollVerifiedAuthenticator(new(UserId: "TestUserId", OobChannel: "1"));

        Assert.NotNull(response);
    }
}
