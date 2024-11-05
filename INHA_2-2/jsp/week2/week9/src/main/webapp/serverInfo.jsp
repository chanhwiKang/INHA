<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h3>Server version 정보 </h3>
<%=application.getSetverInfo() %>
<br>
<h3>Servlet version 정보 </h3>
<%=application.getMajorVersion() %>.<%=application.getMinorVersion() %>
</body>
</html>