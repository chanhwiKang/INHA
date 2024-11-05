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
include 전 name parameter Value: <%=request.getParameter("name") %>
<hr>
<jsp:include page="body_sub.jsp">
	<jsp:param name="name" value="홍길동"/>
</jsp:include>
<hr>
include 후 name parameter Value: <%=request.getParameter("name") %>
</body>
</html>