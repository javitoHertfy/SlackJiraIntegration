# Slack and Jira integration

This project allows to connect Jira and Slack and log hours from the command line of Slack, just simply type /yourcommand ISS-XX 1h

## Getting Started

The project is build under .NET Framework 4.5.2
It uses a Web API 2 without any security.

Nuget Packages:

* Atlassian.SDK
* Autofac
* log4net
* Newtonsoft.Json
* RestSharp
* Microsoft.AspNet.WebApi

### Prerequisities

In order to get it running you need to read this article:

https://github.com/mccreath/isitup-for-slack/blob/master/docs/TUTORIAL.md

and take a look to this other article to have a nice introduction about Slack commands:

https://slackhq.com/a-beginner-s-guide-to-your-first-bot-97e5b0b7843d#.b0g81aa4z



## Running the tests

No unit or integration test yet

Place this under Fiddler, postman or whatever tool you use:

```
http://localhost:50277/api/slack/slackcommand
```

Header
```
User-Agent: Fiddler
Host: localhost:50277
content-type: application/x-www-form-urlencoded
Content-Length: 243
```
Body
```
token=YOUR_TOKEN_HERE&team_id=T0001&team_domain=example&channel_id=C2147483705&channel_name=test&user_id=U2147483697&user_name=Steve&command=/weather&text=94070&response_url=https://hooks.slack.com/commands/1234/5678
```

## Deployment

I have use Web apps in azure to deploy it.
