<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<% request.setCharacterEncoding("utf-8"); %>
이 페이지는 from.jsp가 생성 

<jsp:forward page="to.jsp">
	<jsp:param value="admin" name="id"/>
	<jsp:param value="adminpw" name="pw"/>
	<jsp:param value="hong" name="name"/>
</jsp:forward>
forward actionTag 이후의 코드
</body>
</html>