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
	String id = "ADMIN";
	String pw = "admin";
%>

<jsp:forward page="to.jsp">
	<jsp:param name="id" value="<%=id %>"/>
	<jsp:param name="pw" value="<%=pw %>"/>
	
</jsp:forward>
</body>
</html>