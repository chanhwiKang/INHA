<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

이 페이지는 to.jsp가 생성 
<%
	String id = request.getParameter("id");
	String pw = request.getParameter("pw");
	String name = request.getParameter("name");
%>
<h3>jsp param 액션태그 결과 </h3>
<h4>
	id : <%= id %><br>
	pw : <%= pw %><br>
	name : <%= name %>
</h4>
</body>
</html>