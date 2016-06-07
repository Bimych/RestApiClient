Symphony REST API Client Library for .NET
=========================================

This is a .NET client library for the Symphony REST API, the technology used to create integrated bots on the Symphony platform. Detailed documentation of the Symphony REST API can be found at [developers.symphony.com](https://developers.symphony.com/).

## Features

 * Client code and model objects for all API endpoints.
 * Automatic token management for authentication.
 * Event-based data feed for processing inbound messages.
 * Builder for constructing formatted messages (MessageML).

## Supported Platforms

The project currently targets .NET Framework 4.5. Support for .NET Core is planned, but needs work to resolve a dependency on [RestSharp](https://github.com/restsharp/RestSharp/issues/664) brought in by code generated by [swagger-codegen](https://github.com/swagger-api/swagger-codegen/).

## Getting Started

Symphony's REST API have been logically divided into sub-APIs. To use the client library, a SessionManager is first created to handle authentication for a bot user, and relevant instances of the sub-APIs are created depending on what functions the bot user requires.

This example shows how to subscribe to a bot user's incoming messages using the DatafeedAPI:

```
var certificate = new X509Certificate2(@"botuser.p12", "password");
var sessionManager = new SessionManager("https://keymanager:8444/sessionauth/", "https://keymanager:8444/keyauth/", certificate);
var agentApiFactory = new AgentApiFactory("https://agentapi:8446/agent");
var datafeedApi = agentApiFactory.CreateDatafeedApi(sessionManager);
datafeedApi.OnMessage += (sender, event) =>
{
    Console.WriteLine(event.Message._Message);
};
datafeedApi.Listen();
```

The following code snippet shows how to find a user by email address and send a formatted message:

```
var podApiFactory = new PodApiFactory("https://agentapi:8446/pod");
var usersApi = podApiFactory.CreateUsersApi(sessionManager);
var streamsApi = podApiFactory.CreateStreamsApi(sessionManager);
var user = usersApi.GetUser("jforsell@factset.com");
var stream = streamsApi.CreateStream(new UserIdList {user.Id});
messagesApi.PostMessage(
    stream.Id, new MessageSubmission()
    {
        Format = MessageSubmission.FormatEnum.Messageml,
        Message = new MessageBuilder().Text("hello ").Bold("world").ToString()
    });
```

## Building

After cloning or downloading the source, it can be built in Visual Studio or with MSBuild.    

### Generated Code

The library depends on code that has been generated from Symphony's YAML spec files using swagger-codegen. These files reside in the project SymphonyOSS.AgentApiClient.Generated and were generated using [this branch of swagger-codegen](https://github.com/jimschubert/swagger-codegen/tree/cs/req_properties_2584). The next major release of swagger-codegen, v2.2.0, is expected to include the necessary fixes from this branch.

In case there is a need to regenerate the code from Symphony's YAML specs:

 1. Make sure Java is installed.
 2. Find the generate.bat script in the SymphonyOSS.RestApiClient.Generated\OpenApi folder, and if necessary, edit it to pick up a different set of YAML specs. 
 3. Put swagger-codegen-cli.jar in the same folder as the generate.bat script. The JAR file can be downloaded from [Maven Central](http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/) or built from [source](https://github.com/swagger-api/swagger-codegen).
 4. Run generate.bat.
 5. Build the solution in Visual Studio or using MSBuild.

## Contribute

This project was initiated at [FactSet](https://www.factset.com) and has been developed as open-source from the very beginning.

Contributions are accepted via GitHub pull requests. All contributors must be covered by contributor license agreements to comply with the [Code Contribution Process](https://symphonyoss.atlassian.net/wiki/display/FM/Code+Contribution+Process).

## Release Notes

Release 0.1.0 (June 6, 2016)

 * Initial release. Code generated from agentAPI v1.38.0, authenticatorAPI v1.0, and podAPI v1.38.0, found in agent-sdk-1.38.0-2016-05-27.tar.gz.