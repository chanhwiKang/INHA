<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
setAttribute.jsp
<%
	request.setCharacterEncoding("utf-8");
	request.setAttribute("id", "adminID");
	request.setAttribute("pw", "adminPW");
%>
<jsp:forward page="getAttribute.jsp"/>
</body>
</html>