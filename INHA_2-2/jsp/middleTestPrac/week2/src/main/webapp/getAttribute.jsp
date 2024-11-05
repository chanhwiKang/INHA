<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<%
	String id = request.getAttribute("id").toString();
	String pw = request.getAttribute("pw").toString();
%>
<%=id %><br>
<%=pw %>

</body>
</html>