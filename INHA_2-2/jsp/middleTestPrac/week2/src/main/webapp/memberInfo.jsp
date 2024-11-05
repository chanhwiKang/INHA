<%@page import="week2.MemberInfo"%>
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
	MemberInfo member = new MemberInfo("홍길동", 25);
	request.setAttribute("mem", member);
%>
<h3>MemberInfo</h3>
이름 변경 전 : ${mem.name } / ${mem.age }
${mem.setName("이순신") }<br>
이름 변경 후 : ${mem.name }
</body>
</html>