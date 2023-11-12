# SerilogDemo

Demo for Structured Logging in .NET Core apps using Serilog and Seq.

## Steps:
- Run Seq: `docker run -d --restart unless-stopped --name seq -e ACCEPT_EULA=Y -v C:\Demos\Logs:/data -p 8081:80 datalust/seq:latest`

Reference: https://www.youtube.com/watch?v=_iryZxv8Rxw&t=291s&ab_channel=IAmTimCorey
