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
	int number = 10;
%>
<%@
	include file="includeSub.jspf"
%>
<h3> 공통 변수 DataFolder = <%= dataFolder %></h3> 
</body>
</html>