
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
<p>
    <%
        Dim remoteServer
        set remoteServer = Server.CreateObject("VisaHelloWorld.ServerApp2")
        response.write(remoteServer.HelloWorld("ASP Page"))
    %>
</p>
</body>
</html>